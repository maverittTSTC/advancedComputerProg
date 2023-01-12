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
            if (timeLeft> 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                tmrSplash.Stop();
                new frmMain().Show();
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
            pBar.Location = new System.Drawing.Point(125, 350);
            pBar.Name = "prgSplash";
            pBar.Width= 550;
            pBar.Height= 45;
            Controls.Add(pBar);
            //pBar.Dock = DockStyle.Bottom;
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            pBar.Value= 0;


            //pBar.Value= timeLeft;
            timeLeft = 10;
            tmrSplash.Start();
            
        }
    }
}