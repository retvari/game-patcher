using Cyclic.Redundancy.Check;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace David.Lister
{
    public partial class lForm : Form
    {
        string[] Files;

        public lForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            StartBrowsing();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveFromPath(filePath.SelectedText);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Files = GetFiles(e.Argument);

            for (int i = 0; i < Files.Length; i++)
            {
                backgroundWorker.ReportProgress(i + 1, GetFileData(Files[i]));
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateResult(e.UserState);

            UpdateProgressBar(ComputeProgress(e.ProgressPercentage));
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableButtons();
        }

        private void DisableButtons()
        {
            Progress.Value = 0;
            Result.Clear();
            saveButton.Enabled   = false;
            removeButton.Enabled = false;
            browseButton.Enabled = false;
        }

        private void EnableButtons()
        {
            saveButton.Enabled   = true;
            removeButton.Enabled = true;
            browseButton.Enabled = true;
        }

        public string[] GetFiles(object Path)
        {
            return Directory.GetFiles(Path.ToString(), "*.*", System.IO.SearchOption.AllDirectories);
        }

        public int GetFilesCount(string[] Files)
        {
            return Files.Length;
        }

        public string GetFileData(string File)
        {
            FileInfo fileInfo = new FileInfo(File);

            return File + " " + GetHash(File) + " " + fileInfo.Length;
        }

        private string GetHash(string Name)
        {
            if (Name == string.Empty)
                return null;

            CRC crc = new CRC();

            string Hash = string.Empty;

            try
            {
                using (FileStream fileStream = File.Open(Name, FileMode.Open))
                {
                    foreach (byte b in crc.ComputeHash(fileStream))
                    {
                        Hash += b.ToString("x2").ToLower();
                    }
                }
            }
            catch
            {
                MessageBox.Show(Name + " cannot be opened.");
            }

            return Hash;
        }

        private void UpdateResult(object Data)
        {
            if(!Result.IsDisposed)
            {
                Result.AppendText(Data.ToString().Replace(@"\", "/") + Environment.NewLine);
            }
        }

        private int ComputeProgress(int Percent)
        {
            return (100 * Percent) / Files.Length;
        }

        private void UpdateProgressBar(int Percent)
        {
            if (Percent < 0 || Percent > 100)
                return;

            if(!Progress.IsDisposed)
            {
                Progress.Value = Percent;
            }
        }

        private void RemoveFromPath(string Remove)
        {
            if (Remove == string.Empty)
                return;

            Result.Text = Result.Text.Replace(Remove, string.Empty);
            filePath.Text = filePath.Text.Replace(Remove, string.Empty);
        }

        private void StartBrowsing()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DisableButtons();
                filePath.Text = folderBrowserDialog.SelectedPath.Replace(@"\", "/");

                if(!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void SaveList()
        {
            saveFileDialog.FileName = "patchlist.txt";
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.Write(Result.Text);
                }
            }
        }
    }
}
