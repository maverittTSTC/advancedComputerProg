namespace MAverittACSM1
{
    partial class frmSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pgrSplash = new System.Windows.Forms.ProgressBar();
            this.bkgWorker = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrSplash
            // 
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // pgrSplash
            // 
            this.pgrSplash.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pgrSplash.Location = new System.Drawing.Point(114, 336);
            this.pgrSplash.Name = "pgrSplash";
            this.pgrSplash.Size = new System.Drawing.Size(550, 45);
            this.pgrSplash.Step = 15;
            this.pgrSplash.TabIndex = 0;
            // 
            // bkgWorker
            // 
            this.bkgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorker_DoWork);
            this.bkgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorker_ProgressChanged);
            // 
            // lblProgress
            // 
            this.lblProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProgress.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.Location = new System.Drawing.Point(295, 394);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(182, 38);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAverittACSM1.Properties.Resources.splashScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pgrSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSplash;
        private ProgressBar pgrSplash;
        private System.ComponentModel.BackgroundWorker bkgWorker;
        private Label lblProgress;
    }
}