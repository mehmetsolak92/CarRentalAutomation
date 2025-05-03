namespace CarRentalAutomation
{
    partial class RentActiveList
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
            dgvActiveRents = new DataGridView();
            dtpRentEnd = new DateTimePicker();
            dtpRentStart = new DateTimePicker();
            lblRentEnd = new Label();
            lblRentStart = new Label();
            btnFilter = new Button();
            gbKullanici = new GroupBox();
            lblAdSoyad = new Label();
            _lblAdSoyad = new Label();
            lblTelefon = new Label();
            lblMail = new Label();
            _lblTelefon = new Label();
            _lblMail = new Label();
            gbArac = new GroupBox();
            lblPlaka = new Label();
            _lblPlaka = new Label();
            lblRenk = new Label();
            lblYil = new Label();
            lblModel = new Label();
            lblMarka = new Label();
            _lblRenk = new Label();
            _lblYil = new Label();
            _lblModel = new Label();
            _lblMarka = new Label();
            btnCancel = new Button();
            btnTeslimAl = new Button();
            btnRentPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActiveRents).BeginInit();
            gbKullanici.SuspendLayout();
            gbArac.SuspendLayout();
            SuspendLayout();
            // 
            // dgvActiveRents
            // 
            dgvActiveRents.AllowUserToAddRows = false;
            dgvActiveRents.AllowUserToDeleteRows = false;
            dgvActiveRents.AllowUserToResizeColumns = false;
            dgvActiveRents.AllowUserToResizeRows = false;
            dgvActiveRents.ColumnHeadersHeight = 25;
            dgvActiveRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvActiveRents.Location = new Point(58, 147);
            dgvActiveRents.MultiSelect = false;
            dgvActiveRents.Name = "dgvActiveRents";
            dgvActiveRents.ReadOnly = true;
            dgvActiveRents.RowHeadersVisible = false;
            dgvActiveRents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvActiveRents.RowTemplate.Height = 35;
            dgvActiveRents.RowTemplate.ReadOnly = true;
            dgvActiveRents.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvActiveRents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveRents.Size = new Size(953, 751);
            dgvActiveRents.TabIndex = 32;
            dgvActiveRents.SelectionChanged += dgvActiveRents_SelectionChanged;
            // 
            // dtpRentEnd
            // 
            dtpRentEnd.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpRentEnd.Location = new Point(335, 95);
            dtpRentEnd.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpRentEnd.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpRentEnd.Name = "dtpRentEnd";
            dtpRentEnd.Size = new Size(222, 25);
            dtpRentEnd.TabIndex = 36;
            // 
            // dtpRentStart
            // 
            dtpRentStart.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpRentStart.Location = new Point(335, 51);
            dtpRentStart.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpRentStart.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpRentStart.Name = "dtpRentStart";
            dtpRentStart.Size = new Size(222, 25);
            dtpRentStart.TabIndex = 35;
            // 
            // lblRentEnd
            // 
            lblRentEnd.AutoSize = true;
            lblRentEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentEnd.Location = new Point(58, 100);
            lblRentEnd.Name = "lblRentEnd";
            lblRentEnd.Size = new Size(146, 21);
            lblRentEnd.TabIndex = 34;
            lblRentEnd.Text = "KİRALAMA BİTİŞİ :";
            // 
            // lblRentStart
            // 
            lblRentStart.AutoSize = true;
            lblRentStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentStart.Location = new Point(58, 56);
            lblRentStart.Name = "lblRentStart";
            lblRentStart.Size = new Size(196, 21);
            lblRentStart.TabIndex = 33;
            lblRentStart.Text = "KİRALAMA BAŞLANGICI :";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(184, 12, 9);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFilter.Image = Properties.Resources.Ionic_Ionicons_Search_circle_32;
            btnFilter.ImageAlign = ContentAlignment.MiddleRight;
            btnFilter.Location = new Point(794, 51);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(217, 69);
            btnFilter.TabIndex = 37;
            btnFilter.Text = "FİLTRELE";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // gbKullanici
            // 
            gbKullanici.Controls.Add(lblAdSoyad);
            gbKullanici.Controls.Add(_lblAdSoyad);
            gbKullanici.Controls.Add(lblTelefon);
            gbKullanici.Controls.Add(lblMail);
            gbKullanici.Controls.Add(_lblTelefon);
            gbKullanici.Controls.Add(_lblMail);
            gbKullanici.Location = new Point(1029, 147);
            gbKullanici.Name = "gbKullanici";
            gbKullanici.Size = new Size(464, 137);
            gbKullanici.TabIndex = 43;
            gbKullanici.TabStop = false;
            gbKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.BorderStyle = BorderStyle.FixedSingle;
            lblAdSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.Location = new Point(153, 22);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(271, 21);
            lblAdSoyad.TabIndex = 56;
            lblAdSoyad.Text = "-";
            // 
            // _lblAdSoyad
            // 
            _lblAdSoyad.AutoSize = true;
            _lblAdSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblAdSoyad.Location = new Point(12, 22);
            _lblAdSoyad.Name = "_lblAdSoyad";
            _lblAdSoyad.Size = new Size(90, 21);
            _lblAdSoyad.TabIndex = 55;
            _lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblTelefon
            // 
            lblTelefon.BorderStyle = BorderStyle.FixedSingle;
            lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTelefon.Location = new Point(153, 102);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(271, 21);
            lblTelefon.TabIndex = 50;
            lblTelefon.Text = "-";
            // 
            // lblMail
            // 
            lblMail.BorderStyle = BorderStyle.FixedSingle;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(153, 62);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(271, 21);
            lblMail.TabIndex = 49;
            lblMail.Text = "-";
            // 
            // _lblTelefon
            // 
            _lblTelefon.AutoSize = true;
            _lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblTelefon.Location = new Point(12, 102);
            _lblTelefon.Name = "_lblTelefon";
            _lblTelefon.Size = new Size(75, 21);
            _lblTelefon.TabIndex = 44;
            _lblTelefon.Text = "Telefon :";
            // 
            // _lblMail
            // 
            _lblMail.AutoSize = true;
            _lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblMail.Location = new Point(12, 62);
            _lblMail.Name = "_lblMail";
            _lblMail.Size = new Size(52, 21);
            _lblMail.TabIndex = 43;
            _lblMail.Text = "Mail :";
            // 
            // gbArac
            // 
            gbArac.Controls.Add(lblPlaka);
            gbArac.Controls.Add(_lblPlaka);
            gbArac.Controls.Add(lblRenk);
            gbArac.Controls.Add(lblYil);
            gbArac.Controls.Add(lblModel);
            gbArac.Controls.Add(lblMarka);
            gbArac.Controls.Add(_lblRenk);
            gbArac.Controls.Add(_lblYil);
            gbArac.Controls.Add(_lblModel);
            gbArac.Controls.Add(_lblMarka);
            gbArac.Location = new Point(1029, 290);
            gbArac.Name = "gbArac";
            gbArac.Size = new Size(464, 216);
            gbArac.TabIndex = 57;
            gbArac.TabStop = false;
            gbArac.Text = "Araç Bilgileri";
            // 
            // lblPlaka
            // 
            lblPlaka.BorderStyle = BorderStyle.FixedSingle;
            lblPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPlaka.Location = new Point(153, 22);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(271, 21);
            lblPlaka.TabIndex = 56;
            lblPlaka.Text = "-";
            // 
            // _lblPlaka
            // 
            _lblPlaka.AutoSize = true;
            _lblPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblPlaka.Location = new Point(12, 22);
            _lblPlaka.Name = "_lblPlaka";
            _lblPlaka.Size = new Size(60, 21);
            _lblPlaka.TabIndex = 55;
            _lblPlaka.Text = "Plaka :";
            // 
            // lblRenk
            // 
            lblRenk.BorderStyle = BorderStyle.FixedSingle;
            lblRenk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRenk.Location = new Point(153, 182);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(271, 21);
            lblRenk.TabIndex = 52;
            lblRenk.Text = "-";
            // 
            // lblYil
            // 
            lblYil.BorderStyle = BorderStyle.FixedSingle;
            lblYil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYil.Location = new Point(153, 142);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(271, 21);
            lblYil.TabIndex = 51;
            lblYil.Text = "-";
            // 
            // lblModel
            // 
            lblModel.BorderStyle = BorderStyle.FixedSingle;
            lblModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblModel.Location = new Point(153, 102);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(271, 21);
            lblModel.TabIndex = 50;
            lblModel.Text = "-";
            // 
            // lblMarka
            // 
            lblMarka.BorderStyle = BorderStyle.FixedSingle;
            lblMarka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMarka.Location = new Point(153, 62);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(271, 21);
            lblMarka.TabIndex = 49;
            lblMarka.Text = "-";
            // 
            // _lblRenk
            // 
            _lblRenk.AutoSize = true;
            _lblRenk.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblRenk.Location = new Point(12, 182);
            _lblRenk.Name = "_lblRenk";
            _lblRenk.Size = new Size(56, 21);
            _lblRenk.TabIndex = 46;
            _lblRenk.Text = "Renk :";
            // 
            // _lblYil
            // 
            _lblYil.AutoSize = true;
            _lblYil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblYil.Location = new Point(12, 142);
            _lblYil.Name = "_lblYil";
            _lblYil.Size = new Size(38, 21);
            _lblYil.TabIndex = 45;
            _lblYil.Text = "Yıl :";
            // 
            // _lblModel
            // 
            _lblModel.AutoSize = true;
            _lblModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblModel.Location = new Point(12, 102);
            _lblModel.Name = "_lblModel";
            _lblModel.Size = new Size(67, 21);
            _lblModel.TabIndex = 44;
            _lblModel.Text = "Model :";
            // 
            // _lblMarka
            // 
            _lblMarka.AutoSize = true;
            _lblMarka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblMarka.Location = new Point(12, 62);
            _lblMarka.Name = "_lblMarka";
            _lblMarka.Size = new Size(66, 21);
            _lblMarka.TabIndex = 43;
            _lblMarka.Text = "Marka :";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(184, 12, 9);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Ionic_Ionicons_Close_circle_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(1041, 829);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(217, 69);
            btnCancel.TabIndex = 58;
            btnCancel.Text = "İPTAL ET";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.BackColor = Color.FromArgb(184, 12, 9);
            btnTeslimAl.FlatStyle = FlatStyle.Flat;
            btnTeslimAl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTeslimAl.Image = Properties.Resources.Ionic_Ionicons_Enter_32;
            btnTeslimAl.ImageAlign = ContentAlignment.MiddleRight;
            btnTeslimAl.Location = new Point(1264, 829);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(217, 69);
            btnTeslimAl.TabIndex = 59;
            btnTeslimAl.Text = "TESLİM AL";
            btnTeslimAl.UseVisualStyleBackColor = false;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // btnRentPage
            // 
            btnRentPage.BackColor = Color.FromArgb(184, 12, 9);
            btnRentPage.FlatStyle = FlatStyle.Flat;
            btnRentPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRentPage.Image = Properties.Resources.Ionic_Ionicons_Car_32;
            btnRentPage.ImageAlign = ContentAlignment.MiddleRight;
            btnRentPage.Location = new Point(1270, 47);
            btnRentPage.Name = "btnRentPage";
            btnRentPage.Size = new Size(217, 69);
            btnRentPage.TabIndex = 60;
            btnRentPage.Text = "KİRALAMA SAYFASI";
            btnRentPage.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRentPage.UseVisualStyleBackColor = false;
            btnRentPage.Click += button1_Click;
            // 
            // RentActiveList
            // 
            ClientSize = new Size(1505, 910);
            Controls.Add(btnRentPage);
            Controls.Add(btnTeslimAl);
            Controls.Add(btnCancel);
            Controls.Add(gbArac);
            Controls.Add(gbKullanici);
            Controls.Add(btnFilter);
            Controls.Add(dtpRentEnd);
            Controls.Add(dtpRentStart);
            Controls.Add(lblRentEnd);
            Controls.Add(lblRentStart);
            Controls.Add(dgvActiveRents);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RentActiveList";
            Load += RentActiveList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActiveRents).EndInit();
            gbKullanici.ResumeLayout(false);
            gbKullanici.PerformLayout();
            gbArac.ResumeLayout(false);
            gbArac.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvActiveRents;
        private DateTimePicker dtpRentEnd;
        private DateTimePicker dtpRentStart;
        private Label lblRentEnd;
        private Label lblRentStart;
        private Button btnFilter;
        private GroupBox gbKullanici;
        private Label lblTelefon;
        private Label lblMail;
        private Label _lblTelefon;
        private Label _lblMail;
        private GroupBox gbArac;
        private Label lblPlaka;
        private Label _lblPlaka;
        private Label lblRenk;
        private Label lblYil;
        private Label lblModel;
        private Label lblMarka;
        private Label _lblRenk;
        private Label _lblYil;
        private Label _lblModel;
        private Label _lblMarka;
        private Label lblAdSoyad;
        private Label _lblAdSoyad;
        private Button btnCancel;
        private Button btnTeslimAl;
        private Button btnRentPage;
    }
}