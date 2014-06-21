using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace David.Patcher.Source_files
{
    class Starter
    {
        public static void Start()
        {
            if (!File.Exists(Globals.BinaryName))
            {
                MessageBox.Show(Texts.GetText(Texts.Keys.MISSINGBINARY, Globals.BinaryName));
                return;
            }

            try
            {
                Process startProcess = new Process();
                startProcess.StartInfo.FileName = Globals.BinaryName;
                startProcess.StartInfo.UseShellExecute = false;
                startProcess.Start();
            }
            catch
            {
                MessageBox.Show(Texts.GetText(Texts.Keys.CANNOTSTART, Globals.BinaryName));
                Application.Exit();
            }
        }
    }
}
