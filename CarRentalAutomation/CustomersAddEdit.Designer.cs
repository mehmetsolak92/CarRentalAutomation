namespace CarRentalAutomation
{
    partial class CustomersAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersAddEdit));
            btnSave = new Button();
            btnCancel = new Button();
            txtAdSoyad = new TextBox();
            lblAdSoyad = new Label();
            lblTelefon = new Label();
            lblMail = new Label();
            lblTcKimlik = new Label();
            lblEhliyetNo = new Label();
            lblEhliyetTarih = new Label();
            lblEhliyetSinif = new Label();
            cmbEhliyetSinif = new ComboBox();
            dtpEhliyetTarih = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            txtTelefon = new TextBox();
            txtMail = new TextBox();
            txtTcKimlikNo = new TextBox();
            txtEhliyetNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(182, 12, 9);
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Ionic_Ionicons_Checkmark_circle_32;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(80, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(197, 56);
            btnSave.TabIndex = 8;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Ionic_Ionicons_Close_circle_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(295, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(197, 56);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdSoyad.Location = new Point(274, 36);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(222, 29);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAdSoyad.Location = new Point(76, 44);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(98, 21);
            lblAdSoyad.TabIndex = 8;
            lblAdSoyad.Text = "AD SOYAD :";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefon.Location = new Point(76, 87);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(86, 21);
            lblTelefon.TabIndex = 9;
            lblTelefon.Text = "TELEFON :";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMail.Location = new Point(76, 130);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(57, 21);
            lblMail.TabIndex = 10;
            lblMail.Text = "MAİL :";
            // 
            // lblTcKimlik
            // 
            lblTcKimlik.AutoSize = true;
            lblTcKimlik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTcKimlik.Location = new Point(76, 173);
            lblTcKimlik.Name = "lblTcKimlik";
            lblTcKimlik.Size = new Size(122, 21);
            lblTcKimlik.TabIndex = 11;
            lblTcKimlik.Text = "TC KİMLİK NO :";
            // 
            // lblEhliyetNo
            // 
            lblEhliyetNo.AutoSize = true;
            lblEhliyetNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEhliyetNo.Location = new Point(76, 216);
            lblEhliyetNo.Name = "lblEhliyetNo";
            lblEhliyetNo.Size = new Size(109, 21);
            lblEhliyetNo.TabIndex = 12;
            lblEhliyetNo.Text = "EHLİYET NO :";
            // 
            // lblEhliyetTarih
            // 
            lblEhliyetTarih.AutoSize = true;
            lblEhliyetTarih.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEhliyetTarih.Location = new Point(76, 260);
            lblEhliyetTarih.Name = "lblEhliyetTarih";
            lblEhliyetTarih.Size = new Size(135, 21);
            lblEhliyetTarih.TabIndex = 13;
            lblEhliyetTarih.Text = "EHLİYET TARİHİ :";
            // 
            // lblEhliyetSinif
            // 
            lblEhliyetSinif.AutoSize = true;
            lblEhliyetSinif.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEhliyetSinif.Location = new Point(76, 303);
            lblEhliyetSinif.Name = "lblEhliyetSinif";
            lblEhliyetSinif.Size = new Size(129, 21);
            lblEhliyetSinif.TabIndex = 14;
            lblEhliyetSinif.Text = "EHLİYET SINIFI :";
            // 
            // cmbEhliyetSinif
            // 
            cmbEhliyetSinif.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEhliyetSinif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbEhliyetSinif.FormattingEnabled = true;
            cmbEhliyetSinif.Location = new Point(274, 295);
            cmbEhliyetSinif.Name = "cmbEhliyetSinif";
            cmbEhliyetSinif.Size = new Size(222, 29);
            cmbEhliyetSinif.TabIndex = 7;
            // 
            // dtpEhliyetTarih
            // 
            dtpEhliyetTarih.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpEhliyetTarih.Location = new Point(274, 256);
            dtpEhliyetTarih.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpEhliyetTarih.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpEhliyetTarih.Name = "dtpEhliyetTarih";
            dtpEhliyetTarih.Size = new Size(222, 25);
            dtpEhliyetTarih.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelefon.Location = new Point(274, 79);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(222, 29);
            txtTelefon.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMail.Location = new Point(274, 122);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(222, 29);
            txtMail.TabIndex = 3;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTcKimlikNo.Location = new Point(274, 165);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(222, 29);
            txtTcKimlikNo.TabIndex = 4;
            // 
            // txtEhliyetNo
            // 
            txtEhliyetNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEhliyetNo.Location = new Point(274, 208);
            txtEhliyetNo.Name = "txtEhliyetNo";
            txtEhliyetNo.Size = new Size(222, 29);
            txtEhliyetNo.TabIndex = 5;
            // 
            // CustomersAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 430);
            Controls.Add(txtEhliyetNo);
            Controls.Add(txtTcKimlikNo);
            Controls.Add(txtMail);
            Controls.Add(txtTelefon);
            Controls.Add(dtpEhliyetTarih);
            Controls.Add(cmbEhliyetSinif);
            Controls.Add(lblEhliyetSinif);
            Controls.Add(lblEhliyetTarih);
            Controls.Add(lblEhliyetNo);
            Controls.Add(lblTcKimlik);
            Controls.Add(lblMail);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomersAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "YENİ KULLANICI EKLE";
            Load += CustomersAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtAdSoyad;
        private Label lblAdSoyad;
        private Label lblTelefon;
        private Label lblMail;
        private Label lblTcKimlik;
        private Label lblEhliyetNo;
        private Label lblEhliyetTarih;
        private Label lblEhliyetSinif;
        private ComboBox cmbEhliyetSinif;
        private DateTimePicker dtpEhliyetTarih;
        private ErrorProvider errorProvider1;
        private TextBox txtEhliyetNo;
        private TextBox txtTcKimlikNo;
        private TextBox txtMail;
        private TextBox txtTelefon;
    }
}