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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlSide = new FlowLayoutPanel();
            pnlUser = new Panel();
            lblActiveUser = new Label();
            _lblActiveUser = new Label();
            pbUserImg = new PictureBox();
            btnMenuHome = new Button();
            btnMenuRent = new Button();
            btnMenuCars = new Button();
            btnMenuCustomers = new Button();
            btnMenuFinance = new Button();
            btnMenuSettings = new Button();
            pnlFooter = new Panel();
            lblTime = new Label();
            lblVersion = new Label();
            pnlScreens = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
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
            pnlSide.Controls.Add(btnMenuSettings);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(207, 941);
            pnlSide.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(lblActiveUser);
            pnlUser.Controls.Add(_lblActiveUser);
            pnlUser.Controls.Add(pbUserImg);
            pnlUser.Location = new Point(3, 3);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(197, 150);
            pnlUser.TabIndex = 1;
            // 
            // lblActiveUser
            // 
            lblActiveUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblActiveUser.Location = new Point(8, 106);
            lblActiveUser.Name = "lblActiveUser";
            lblActiveUser.Size = new Size(185, 23);
            lblActiveUser.TabIndex = 2;
            lblActiveUser.Text = "user";
            lblActiveUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblActiveUser
            // 
            _lblActiveUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            _lblActiveUser.Location = new Point(8, 83);
            _lblActiveUser.Name = "_lblActiveUser";
            _lblActiveUser.Size = new Size(185, 23);
            _lblActiveUser.TabIndex = 1;
            _lblActiveUser.Text = "Aktif Kullanıcı:";
            _lblActiveUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbUserImg
            // 
            pbUserImg.Image = Properties.Resources.Ionic_Ionicons_Person_circle_64;
            pbUserImg.Location = new Point(68, 9);
            pbUserImg.Name = "pbUserImg";
            pbUserImg.Size = new Size(64, 64);
            pbUserImg.TabIndex = 0;
            pbUserImg.TabStop = false;
            pbUserImg.Click += pbUserImg_Click;
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
            // btnMenuSettings
            // 
            btnMenuSettings.FlatStyle = FlatStyle.Flat;
            btnMenuSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuSettings.Image = Properties.Resources.Ionic_Ionicons_Construct_32;
            btnMenuSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuSettings.Location = new Point(3, 434);
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
            pnlFooter.Controls.Add(lblTime);
            pnlFooter.Controls.Add(lblVersion);
            pnlFooter.Location = new Point(0, 904);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1711, 37);
            pnlFooter.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(1511, 12);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(193, 19);
            lblTime.TabIndex = 3;
            lblTime.Text = "00.00.0000 - 00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(1290, 12);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(193, 19);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Car Rental Automation v1.00";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlScreens
            // 
            pnlScreens.BackColor = SystemColors.ActiveBorder;
            pnlScreens.Location = new Point(206, 0);
            pnlScreens.Name = "pnlScreens";
            pnlScreens.Size = new Size(1505, 910);
            pnlScreens.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnMenuSettings;
        private PictureBox pbUserImg;
        private Label lblActiveUser;
        private Label _lblActiveUser;
        private Panel pnlFooter;
        private Label lblVersion;
        public Panel pnlScreens;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
