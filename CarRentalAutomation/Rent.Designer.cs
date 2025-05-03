namespace CarRentalAutomation
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            lblRentStart = new Label();
            lblRentEnd = new Label();
            dtpRentStart = new DateTimePicker();
            dtpRentEnd = new DateTimePicker();
            btnSearchCar = new Button();
            dgvCars = new DataGridView();
            lblPriceTitle = new Label();
            lblTotalPrice = new Label();
            btnRent = new Button();
            cmbYakit = new ComboBox();
            cmbVites = new ComboBox();
            lblYakit = new Label();
            lblVites = new Label();
            cmbKullanici = new ComboBox();
            lblKullanici = new Label();
            pictureBox1 = new PictureBox();
            gbKullanici = new GroupBox();
            lblEhliyetSinif = new Label();
            lblEhliyetTarih = new Label();
            lblEhliyetNo = new Label();
            lblTc = new Label();
            lblTelefon = new Label();
            lblMail = new Label();
            _lblEhliyetSinif = new Label();
            _lblEhliyetTarih = new Label();
            _lblEhliyetNo = new Label();
            _lblTc = new Label();
            _lblTelefon = new Label();
            _lblMail = new Label();
            label1 = new Label();
            lblKiralamaSüresi = new Label();
            txtAciklama = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnActiveRents = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblRentStart
            // 
            lblRentStart.AutoSize = true;
            lblRentStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentStart.Location = new Point(58, 56);
            lblRentStart.Name = "lblRentStart";
            lblRentStart.Size = new Size(196, 21);
            lblRentStart.TabIndex = 9;
            lblRentStart.Text = "KİRALAMA BAŞLANGICI :";
            // 
            // lblRentEnd
            // 
            lblRentEnd.AutoSize = true;
            lblRentEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentEnd.Location = new Point(58, 100);
            lblRentEnd.Name = "lblRentEnd";
            lblRentEnd.Size = new Size(146, 21);
            lblRentEnd.TabIndex = 10;
            lblRentEnd.Text = "KİRALAMA BİTİŞİ :";
            // 
            // dtpRentStart
            // 
            dtpRentStart.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpRentStart.Location = new Point(335, 51);
            dtpRentStart.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpRentStart.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpRentStart.Name = "dtpRentStart";
            dtpRentStart.Size = new Size(222, 25);
            dtpRentStart.TabIndex = 28;
            dtpRentStart.ValueChanged += dtpRentStart_ValueChanged;
            // 
            // dtpRentEnd
            // 
            dtpRentEnd.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpRentEnd.Location = new Point(335, 95);
            dtpRentEnd.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpRentEnd.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpRentEnd.Name = "dtpRentEnd";
            dtpRentEnd.Size = new Size(222, 25);
            dtpRentEnd.TabIndex = 29;
            dtpRentEnd.ValueChanged += dtpRentEnd_ValueChanged;
            // 
            // btnSearchCar
            // 
            btnSearchCar.BackColor = Color.FromArgb(184, 12, 9);
            btnSearchCar.FlatStyle = FlatStyle.Flat;
            btnSearchCar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSearchCar.Image = Properties.Resources.Ionic_Ionicons_Search_circle_32;
            btnSearchCar.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchCar.Location = new Point(1047, 47);
            btnSearchCar.Name = "btnSearchCar";
            btnSearchCar.Size = new Size(217, 69);
            btnSearchCar.TabIndex = 30;
            btnSearchCar.Text = "ARAÇLARI LİSTELE";
            btnSearchCar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearchCar.UseVisualStyleBackColor = false;
            btnSearchCar.Click += btnSearchCar_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeColumns = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.ColumnHeadersHeight = 25;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCars.Location = new Point(58, 147);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCars.RowTemplate.Height = 35;
            dgvCars.RowTemplate.ReadOnly = true;
            dgvCars.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(953, 751);
            dgvCars.TabIndex = 31;
            dgvCars.SelectionChanged += dgvCars_SelectionChanged;
            // 
            // lblPriceTitle
            // 
            lblPriceTitle.AutoSize = true;
            lblPriceTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPriceTitle.Location = new Point(1069, 799);
            lblPriceTitle.Name = "lblPriceTitle";
            lblPriceTitle.Size = new Size(136, 21);
            lblPriceTitle.TabIndex = 32;
            lblPriceTitle.Text = "TOPLAM TUTAR :";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPrice.FlatStyle = FlatStyle.Flat;
            lblTotalPrice.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalPrice.Location = new Point(1047, 829);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(217, 69);
            lblTotalPrice.TabIndex = 33;
            lblTotalPrice.Text = "0 TL";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRent
            // 
            btnRent.BackColor = Color.FromArgb(184, 12, 9);
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRent.Image = Properties.Resources.Ionic_Ionicons_Arrow_forward_circle_32;
            btnRent.ImageAlign = ContentAlignment.MiddleRight;
            btnRent.Location = new Point(1270, 829);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(217, 69);
            btnRent.TabIndex = 34;
            btnRent.Text = "KİRALA";
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // cmbYakit
            // 
            cmbYakit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYakit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbYakit.FormattingEnabled = true;
            cmbYakit.Location = new Point(789, 91);
            cmbYakit.Name = "cmbYakit";
            cmbYakit.Size = new Size(222, 29);
            cmbYakit.TabIndex = 38;
            // 
            // cmbVites
            // 
            cmbVites.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVites.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbVites.FormattingEnabled = true;
            cmbVites.Location = new Point(789, 47);
            cmbVites.Name = "cmbVites";
            cmbVites.Size = new Size(222, 29);
            cmbVites.TabIndex = 37;
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblYakit.Location = new Point(609, 99);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(95, 21);
            lblYakit.TabIndex = 36;
            lblYakit.Text = "YAKIT TİPİ :";
            // 
            // lblVites
            // 
            lblVites.AutoSize = true;
            lblVites.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVites.Location = new Point(610, 55);
            lblVites.Name = "lblVites";
            lblVites.Size = new Size(94, 21);
            lblVites.TabIndex = 35;
            lblVites.Text = "VİTES TİPİ :";
            // 
            // cmbKullanici
            // 
            cmbKullanici.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKullanici.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(1159, 147);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(222, 29);
            cmbKullanici.TabIndex = 40;
            cmbKullanici.SelectedIndexChanged += cmbKullanici_SelectedIndexChanged;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKullanici.Location = new Point(1053, 155);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(100, 21);
            lblKullanici.TabIndex = 39;
            lblKullanici.Text = "KULLANICI :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ionic_Ionicons_Add_circle_32;
            pictureBox1.Location = new Point(1387, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // gbKullanici
            // 
            gbKullanici.Controls.Add(lblEhliyetSinif);
            gbKullanici.Controls.Add(lblEhliyetTarih);
            gbKullanici.Controls.Add(lblEhliyetNo);
            gbKullanici.Controls.Add(lblTc);
            gbKullanici.Controls.Add(lblTelefon);
            gbKullanici.Controls.Add(lblMail);
            gbKullanici.Controls.Add(_lblEhliyetSinif);
            gbKullanici.Controls.Add(_lblEhliyetTarih);
            gbKullanici.Controls.Add(_lblEhliyetNo);
            gbKullanici.Controls.Add(_lblTc);
            gbKullanici.Controls.Add(_lblTelefon);
            gbKullanici.Controls.Add(_lblMail);
            gbKullanici.Location = new Point(1029, 183);
            gbKullanici.Name = "gbKullanici";
            gbKullanici.Size = new Size(464, 252);
            gbKullanici.TabIndex = 42;
            gbKullanici.TabStop = false;
            gbKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // lblEhliyetSinif
            // 
            lblEhliyetSinif.BorderStyle = BorderStyle.FixedSingle;
            lblEhliyetSinif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEhliyetSinif.Location = new Point(153, 199);
            lblEhliyetSinif.Name = "lblEhliyetSinif";
            lblEhliyetSinif.Size = new Size(271, 21);
            lblEhliyetSinif.TabIndex = 54;
            lblEhliyetSinif.Text = "-";
            // 
            // lblEhliyetTarih
            // 
            lblEhliyetTarih.BorderStyle = BorderStyle.FixedSingle;
            lblEhliyetTarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEhliyetTarih.Location = new Point(153, 165);
            lblEhliyetTarih.Name = "lblEhliyetTarih";
            lblEhliyetTarih.Size = new Size(271, 21);
            lblEhliyetTarih.TabIndex = 53;
            lblEhliyetTarih.Text = "-";
            // 
            // lblEhliyetNo
            // 
            lblEhliyetNo.BorderStyle = BorderStyle.FixedSingle;
            lblEhliyetNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEhliyetNo.Location = new Point(153, 131);
            lblEhliyetNo.Name = "lblEhliyetNo";
            lblEhliyetNo.Size = new Size(271, 21);
            lblEhliyetNo.TabIndex = 52;
            lblEhliyetNo.Text = "-";
            // 
            // lblTc
            // 
            lblTc.BorderStyle = BorderStyle.FixedSingle;
            lblTc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTc.Location = new Point(153, 97);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(271, 21);
            lblTc.TabIndex = 51;
            lblTc.Text = "-";
            // 
            // lblTelefon
            // 
            lblTelefon.BorderStyle = BorderStyle.FixedSingle;
            lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTelefon.Location = new Point(153, 63);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(271, 21);
            lblTelefon.TabIndex = 50;
            lblTelefon.Text = "-";
            // 
            // lblMail
            // 
            lblMail.BorderStyle = BorderStyle.FixedSingle;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(153, 29);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(271, 21);
            lblMail.TabIndex = 49;
            lblMail.Text = "-";
            // 
            // _lblEhliyetSinif
            // 
            _lblEhliyetSinif.AutoSize = true;
            _lblEhliyetSinif.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblEhliyetSinif.Location = new Point(12, 200);
            _lblEhliyetSinif.Name = "_lblEhliyetSinif";
            _lblEhliyetSinif.Size = new Size(115, 21);
            _lblEhliyetSinif.TabIndex = 48;
            _lblEhliyetSinif.Text = "Ehliyet Sınıfı :";
            // 
            // _lblEhliyetTarih
            // 
            _lblEhliyetTarih.AutoSize = true;
            _lblEhliyetTarih.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblEhliyetTarih.Location = new Point(12, 166);
            _lblEhliyetTarih.Name = "_lblEhliyetTarih";
            _lblEhliyetTarih.Size = new Size(118, 21);
            _lblEhliyetTarih.TabIndex = 47;
            _lblEhliyetTarih.Text = "Ehliyet Tarihi :";
            // 
            // _lblEhliyetNo
            // 
            _lblEhliyetNo.AutoSize = true;
            _lblEhliyetNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblEhliyetNo.Location = new Point(12, 132);
            _lblEhliyetNo.Name = "_lblEhliyetNo";
            _lblEhliyetNo.Size = new Size(94, 21);
            _lblEhliyetNo.TabIndex = 46;
            _lblEhliyetNo.Text = "Ehliyet No:";
            // 
            // _lblTc
            // 
            _lblTc.AutoSize = true;
            _lblTc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblTc.Location = new Point(12, 98);
            _lblTc.Name = "_lblTc";
            _lblTc.Size = new Size(36, 21);
            _lblTc.TabIndex = 45;
            _lblTc.Text = "TC :";
            // 
            // _lblTelefon
            // 
            _lblTelefon.AutoSize = true;
            _lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblTelefon.Location = new Point(12, 64);
            _lblTelefon.Name = "_lblTelefon";
            _lblTelefon.Size = new Size(75, 21);
            _lblTelefon.TabIndex = 44;
            _lblTelefon.Text = "Telefon :";
            // 
            // _lblMail
            // 
            _lblMail.AutoSize = true;
            _lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblMail.Location = new Point(12, 30);
            _lblMail.Name = "_lblMail";
            _lblMail.Size = new Size(52, 21);
            _lblMail.TabIndex = 43;
            _lblMail.Text = "Mail :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(1047, 470);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 43;
            label1.Text = "Kiralama Süresi :";
            // 
            // lblKiralamaSüresi
            // 
            lblKiralamaSüresi.BorderStyle = BorderStyle.FixedSingle;
            lblKiralamaSüresi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKiralamaSüresi.Location = new Point(1189, 470);
            lblKiralamaSüresi.Name = "lblKiralamaSüresi";
            lblKiralamaSüresi.Size = new Size(270, 21);
            lblKiralamaSüresi.TabIndex = 55;
            lblKiralamaSüresi.Text = "-";
            // 
            // txtAciklama
            // 
            txtAciklama.BorderStyle = BorderStyle.FixedSingle;
            txtAciklama.Location = new Point(1047, 547);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(412, 249);
            txtAciklama.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(1047, 507);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 57;
            label2.Text = "Kiralama Notu :";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // btnActiveRents
            // 
            btnActiveRents.BackColor = Color.FromArgb(184, 12, 9);
            btnActiveRents.FlatStyle = FlatStyle.Flat;
            btnActiveRents.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnActiveRents.Image = Properties.Resources.Ionic_Ionicons_Car_32;
            btnActiveRents.ImageAlign = ContentAlignment.MiddleRight;
            btnActiveRents.Location = new Point(1270, 47);
            btnActiveRents.Name = "btnActiveRents";
            btnActiveRents.Size = new Size(217, 69);
            btnActiveRents.TabIndex = 58;
            btnActiveRents.Text = "AKTİF KİRALAMALAR";
            btnActiveRents.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnActiveRents.UseVisualStyleBackColor = false;
            btnActiveRents.Click += btnActiveRents_Click;
            // 
            // Rent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 910);
            Controls.Add(btnActiveRents);
            Controls.Add(label2);
            Controls.Add(txtAciklama);
            Controls.Add(lblKiralamaSüresi);
            Controls.Add(label1);
            Controls.Add(gbKullanici);
            Controls.Add(pictureBox1);
            Controls.Add(cmbKullanici);
            Controls.Add(lblKullanici);
            Controls.Add(cmbYakit);
            Controls.Add(cmbVites);
            Controls.Add(lblYakit);
            Controls.Add(lblVites);
            Controls.Add(btnRent);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblPriceTitle);
            Controls.Add(dgvCars);
            Controls.Add(btnSearchCar);
            Controls.Add(dtpRentEnd);
            Controls.Add(dtpRentStart);
            Controls.Add(lblRentEnd);
            Controls.Add(lblRentStart);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Rent";
            Text = "Rent";
            Load += Rent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbKullanici.ResumeLayout(false);
            gbKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRentStart;
        private Label lblRentEnd;
        private DateTimePicker dtpRentStart;
        private DateTimePicker dtpRentEnd;
        private Button btnSearchCar;
        private DataGridView dgvCars;
        private Label lblPriceTitle;
        private Label lblTotalPrice;
        private Button btnRent;
        private ComboBox cmbYakit;
        private ComboBox cmbVites;
        private Label lblYakit;
        private Label lblVites;
        private ComboBox cmbKullanici;
        private Label lblKullanici;
        private PictureBox pictureBox1;
        private GroupBox gbKullanici;
        private Label _lblEhliyetNo;
        private Label _lblTc;
        private Label _lblTelefon;
        private Label _lblMail;
        private Label _lblEhliyetSinif;
        private Label _lblEhliyetTarih;
        private Label lblEhliyetSinif;
        private Label lblEhliyetTarih;
        private Label lblEhliyetNo;
        private Label lblTc;
        private Label lblTelefon;
        private Label lblMail;
        private Label label1;
        private Label lblKiralamaSüresi;
        private TextBox txtAciklama;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Button btnActiveRents;
    }
}