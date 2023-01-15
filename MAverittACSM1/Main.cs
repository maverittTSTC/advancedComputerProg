using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAverittACSM1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuColor_Red_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void mnuColor_Blue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void mnuColor_Green_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void mnuColor_Yellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private void frmMain_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
