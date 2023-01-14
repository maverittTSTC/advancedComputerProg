namespace MAverittACSM1
{
    public partial class frmSplash : Form
    {
        public int timeLeft { get; set; }
        

        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                this.Hide();
                new frmMain().Show();
                tmrSplash.Stop();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            bkgWorker.WorkerReportsProgress= true;
            bkgWorker.RunWorkerAsync();
            timeLeft = 160;
            tmrSplash.Start();
        }

        private void bkgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(150);
                bkgWorker.ReportProgress(i);
            }
        }

        private void bkgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pgrSplash.Value = e.ProgressPercentage;
            lblProgress.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
        }
    }
}