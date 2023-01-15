namespace MAverittACSM1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Yellow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuColor,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Size = new System.Drawing.Size(93, 22);
            this.mnuFile_Exit.Text = "E&xit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColor_Red,
            this.mnuColor_Blue,
            this.mnuColor_Green,
            this.mnuColor_Yellow});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(48, 20);
            this.mnuColor.Text = "&Color";
            // 
            // mnuColor_Red
            // 
            this.mnuColor_Red.Name = "mnuColor_Red";
            this.mnuColor_Red.Size = new System.Drawing.Size(108, 22);
            this.mnuColor_Red.Text = "&Red";
            this.mnuColor_Red.Click += new System.EventHandler(this.mnuColor_Red_Click);
            // 
            // mnuColor_Blue
            // 
            this.mnuColor_Blue.Name = "mnuColor_Blue";
            this.mnuColor_Blue.Size = new System.Drawing.Size(108, 22);
            this.mnuColor_Blue.Text = "&Blue";
            this.mnuColor_Blue.Click += new System.EventHandler(this.mnuColor_Blue_Click);
            // 
            // mnuColor_Green
            // 
            this.mnuColor_Green.Name = "mnuColor_Green";
            this.mnuColor_Green.Size = new System.Drawing.Size(108, 22);
            this.mnuColor_Green.Text = "&Green";
            this.mnuColor_Green.Click += new System.EventHandler(this.mnuColor_Green_Click);
            // 
            // mnuColor_Yellow
            // 
            this.mnuColor_Yellow.Name = "mnuColor_Yellow";
            this.mnuColor_Yellow.Size = new System.Drawing.Size(108, 22);
            this.mnuColor_Yellow.Text = "&Yellow";
            this.mnuColor_Yellow.Click += new System.EventHandler(this.mnuColor_Yellow_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(107, 22);
            this.mnuHelp_About.Text = "&About";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_Closed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFile_Exit;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuColor_Red;
        private ToolStripMenuItem mnuColor_Blue;
        private ToolStripMenuItem mnuColor_Green;
        private ToolStripMenuItem mnuColor_Yellow;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuHelp_About;
    }
}