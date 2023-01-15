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
            //Decrement timer, when 0 hide form, show main form, stop timer
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                this.Hide();
                new Main().Show();
                tmrSplash.Stop();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Background worker for splash screen progress bar
            bkgWorker.WorkerReportsProgress= true;
            bkgWorker.RunWorkerAsync();
            //Timer for splash screen, closes after 15 seconds
            timeLeft = 150;
            tmrSplash.Start();
        }

        private void bkgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Progress bar percentage counter
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(150);
                bkgWorker.ReportProgress(i);
            }
        }

        private void bkgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            //Progress bar percentage displays
            pgrSplash.Value = e.ProgressPercentage;
            lblProgress.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
        }
    }
}