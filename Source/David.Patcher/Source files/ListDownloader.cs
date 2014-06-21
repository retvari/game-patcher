using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace David.Patcher.Source_files
{
    class ListDownloader
    {
        public static void DownloadList()
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();

            Common.ChangeStatus(Texts.Keys.LISTDOWNLOAD);

            backgroundWorker.DoWork              += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted  += backgroundWorker_RunWorkerCompleted;

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText(Texts.Keys.UNKNOWNERROR, "DownloadList isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient    webClient      = new WebClient();
            Stream       stream         = webClient.OpenRead(Globals.ServerURL + Globals.PatchlistName);
            StreamReader streamReader   = new StreamReader(stream);

            while (!streamReader.EndOfStream)
            {
                ListProcessor.AddFile(streamReader.ReadLine());
            }
        }

        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileChecker.CheckFiles();
        }
    }
}
