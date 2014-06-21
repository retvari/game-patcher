using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace David.Patcher.Source_files
{
    class Networking
    {
        public static void CheckNetwork()
        {
            Common.ChangeStatus(Texts.Keys.CONNECTING);

            BackgroundWorker backgroundWorker = new BackgroundWorker();

            backgroundWorker.DoWork              += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted  += backgroundWorker_RunWorkerCompleted;

            if(backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText(Texts.Keys.UNKNOWNERROR, "CheckNetwork isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                client.OpenRead(Globals.ServerURL);

                e.Result = true;
            }
            catch
            {
                e.Result = false;
            }
        }

        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!Convert.ToBoolean(e.Result))
            {
                MessageBox.Show(Texts.GetText(Texts.Keys.NONETWORK));
                Application.Exit();
            }
            else
            {
                ListDownloader.DownloadList();
            }
        }
    }
}
