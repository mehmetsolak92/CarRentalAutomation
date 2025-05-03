namespace CarRentalAutomation
{
    partial class MainForm
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
            pnlSide = new FlowLayoutPanel();
            pnlUser = new Panel();
            label2 = new Label();
            label1 = new Label();
            pbUserImg = new PictureBox();
            btnMenuHome = new Button();
            btnMenuRent = new Button();
            btnMenuCars = new Button();
            btnMenuCustomers = new Button();
            btnMenuFinance = new Button();
            btnMenuReports = new Button();
            btnMenuSettings = new Button();
            pnlFooter = new Panel();
            label3 = new Label();
            pnlScreens = new Panel();
            pnlSide.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserImg).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(184, 12, 9);
            pnlSide.Controls.Add(pnlUser);
            pnlSide.Controls.Add(btnMenuHome);
            pnlSide.Controls.Add(btnMenuRent);
            pnlSide.Controls.Add(btnMenuCars);
            pnlSide.Controls.Add(btnMenuCustomers);
            pnlSide.Controls.Add(btnMenuFinance);
            pnlSide.Controls.Add(btnMenuReports);
            pnlSide.Controls.Add(btnMenuSettings);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(207, 941);
            pnlSide.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(label2);
            pnlUser.Controls.Add(label1);
            pnlUser.Controls.Add(pbUserImg);
            pnlUser.Location = new Point(3, 3);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(197, 150);
            pnlUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(8, 106);
            label2.Name = "label2";
            label2.Size = new Size(185, 23);
            label2.TabIndex = 2;
            label2.Text = "user";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(48, 83);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 1;
            label1.Text = "Aktif Kullanıcı:";
            // 
            // pbUserImg
            // 
            pbUserImg.Image = Properties.Resources.Ionic_Ionicons_Person_circle_64;
            pbUserImg.Location = new Point(68, 9);
            pbUserImg.Name = "pbUserImg";
            pbUserImg.Size = new Size(64, 64);
            pbUserImg.TabIndex = 0;
            pbUserImg.TabStop = false;
            // 
            // btnMenuHome
            // 
            btnMenuHome.FlatStyle = FlatStyle.Flat;
            btnMenuHome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuHome.Image = Properties.Resources.Ionic_Ionicons_Home_32;
            btnMenuHome.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuHome.Location = new Point(3, 159);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.Size = new Size(197, 49);
            btnMenuHome.TabIndex = 2;
            btnMenuHome.Text = "ANA SAYFA";
            btnMenuHome.UseVisualStyleBackColor = true;
            btnMenuHome.Click += btnMenuHome_Click;
            // 
            // btnMenuRent
            // 
            btnMenuRent.FlatStyle = FlatStyle.Flat;
            btnMenuRent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuRent.Image = Properties.Resources.Ionic_Ionicons_Exit_32;
            btnMenuRent.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuRent.Location = new Point(3, 214);
            btnMenuRent.Name = "btnMenuRent";
            btnMenuRent.Size = new Size(197, 49);
            btnMenuRent.TabIndex = 3;
            btnMenuRent.Text = "KİRALAMALAR";
            btnMenuRent.UseVisualStyleBackColor = true;
            btnMenuRent.Click += btnMenuRent_Click;
            // 
            // btnMenuCars
            // 
            btnMenuCars.FlatStyle = FlatStyle.Flat;
            btnMenuCars.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuCars.Image = Properties.Resources.Ionic_Ionicons_Car_32;
            btnMenuCars.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuCars.Location = new Point(3, 269);
            btnMenuCars.Name = "btnMenuCars";
            btnMenuCars.Size = new Size(197, 49);
            btnMenuCars.TabIndex = 4;
            btnMenuCars.Text = "ARAÇLAR";
            btnMenuCars.UseVisualStyleBackColor = true;
            btnMenuCars.Click += btnMenuCars_Click;
            // 
            // btnMenuCustomers
            // 
            btnMenuCustomers.FlatStyle = FlatStyle.Flat;
            btnMenuCustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuCustomers.Image = Properties.Resources.Ionic_Ionicons_People_sharp_32;
            btnMenuCustomers.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuCustomers.Location = new Point(3, 324);
            btnMenuCustomers.Name = "btnMenuCustomers";
            btnMenuCustomers.Size = new Size(197, 49);
            btnMenuCustomers.TabIndex = 5;
            btnMenuCustomers.Text = "MÜŞTERİLER";
            btnMenuCustomers.UseVisualStyleBackColor = true;
            btnMenuCustomers.Click += btnMenuCustomers_Click;
            // 
            // btnMenuFinance
            // 
            btnMenuFinance.FlatStyle = FlatStyle.Flat;
            btnMenuFinance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuFinance.Image = Properties.Resources.Ionic_Ionicons_Journal_outline_32;
            btnMenuFinance.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuFinance.Location = new Point(3, 379);
            btnMenuFinance.Name = "btnMenuFinance";
            btnMenuFinance.Size = new Size(197, 49);
            btnMenuFinance.TabIndex = 6;
            btnMenuFinance.Text = "FİNANS";
            btnMenuFinance.UseVisualStyleBackColor = true;
            btnMenuFinance.Click += btnMenuFinance_Click;
            // 
            // btnMenuReports
            // 
            btnMenuReports.FlatStyle = FlatStyle.Flat;
            btnMenuReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuReports.Image = Properties.Resources.Ionic_Ionicons_Document_text_32;
            btnMenuReports.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuReports.Location = new Point(3, 434);
            btnMenuReports.Name = "btnMenuReports";
            btnMenuReports.Size = new Size(197, 49);
            btnMenuReports.TabIndex = 7;
            btnMenuReports.Text = "RAPORLAR";
            btnMenuReports.UseVisualStyleBackColor = true;
            btnMenuReports.Click += btnMenuReports_Click;
            // 
            // btnMenuSettings
            // 
            btnMenuSettings.FlatStyle = FlatStyle.Flat;
            btnMenuSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuSettings.Image = Properties.Resources.Ionic_Ionicons_Construct_32;
            btnMenuSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuSettings.Location = new Point(3, 489);
            btnMenuSettings.Name = "btnMenuSettings";
            btnMenuSettings.Size = new Size(197, 49);
            btnMenuSettings.TabIndex = 8;
            btnMenuSettings.Text = "AYARLAR";
            btnMenuSettings.UseVisualStyleBackColor = true;
            btnMenuSettings.Click += btnMenuSettings_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(184, 12, 9);
            pnlFooter.Controls.Add(label3);
            pnlFooter.Location = new Point(0, 904);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1711, 37);
            pnlFooter.TabIndex = 1;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(1515, 9);
            label3.Name = "label3";
            label3.Size = new Size(193, 19);
            label3.TabIndex = 2;
            label3.Text = "Car Rental Automation v1.00";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlScreens
            // 
            pnlScreens.BackColor = SystemColors.ActiveBorder;
            pnlScreens.Location = new Point(206, 0);
            pnlScreens.Name = "pnlScreens";
            pnlScreens.Size = new Size(1505, 910);
            pnlScreens.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1711, 941);
            Controls.Add(pnlScreens);
            Controls.Add(pnlSide);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += HomePage_Load;
            pnlSide.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserImg).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlSide;
        private Button btnMenuHome;
        private Panel pnlUser;
        private Button btnMenuRent;
        private Button btnMenuCars;
        private Button btnMenuCustomers;
        private Button btnMenuFinance;
        private Button btnMenuReports;
        private Button btnMenuSettings;
        private PictureBox pbUserImg;
        private Label label2;
        private Label label1;
        private Panel pnlFooter;
        private Label label3;
        public Panel pnlScreens;
    }
}
