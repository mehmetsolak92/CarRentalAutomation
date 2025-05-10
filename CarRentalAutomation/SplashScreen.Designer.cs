namespace CarRentalAutomation
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            timerFadeIn = new System.Windows.Forms.Timer(components);
            timerFadeOut = new System.Windows.Forms.Timer(components);
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Black;
            progressBar1.Location = new Point(0, 375);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(600, 25);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CAR_RENTAL_AUTOMATION;
            pictureBox1.Location = new Point(150, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timerFadeIn
            // 
            timerFadeIn.Interval = 50;
            timerFadeIn.Tick += timerFadeIn_Tick;
            // 
            // timerFadeOut
            // 
            timerFadeOut.Interval = 50;
            timerFadeOut.Tick += timerFadeOut_Tick;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(339, 353);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(261, 19);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(184, 12, 9);
            ClientSize = new Size(600, 400);
            Controls.Add(lblStatus);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
        private Label lblStatus;
    }
}