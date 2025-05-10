namespace CarRentalAutomation
{
    partial class Settings
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
            btnPersonelSettings = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPersonelSettings
            // 
            btnPersonelSettings.BackColor = Color.FromArgb(184, 12, 9);
            btnPersonelSettings.FlatStyle = FlatStyle.Flat;
            btnPersonelSettings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonelSettings.Image = Properties.Resources.Ionic_Ionicons_Person_circle_64__1_;
            btnPersonelSettings.Location = new Point(23, 23);
            btnPersonelSettings.Name = "btnPersonelSettings";
            btnPersonelSettings.Size = new Size(167, 151);
            btnPersonelSettings.TabIndex = 38;
            btnPersonelSettings.Text = "PERSONEL YÖNETİMİ";
            btnPersonelSettings.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPersonelSettings.UseVisualStyleBackColor = false;
            btnPersonelSettings.Click += btnPersonelSettings_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnPersonelSettings);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(1690, 1002);
            flowLayoutPanel1.TabIndex = 39;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 1026);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPersonelSettings;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}