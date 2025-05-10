namespace CarRentalAutomation
{
    partial class SettingsUsersAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUsersAddEdit));
            btnSave = new Button();
            btnCancel = new Button();
            txtAdSoyad = new TextBox();
            lblAdSoyad = new Label();
            lblTelefon = new Label();
            lblMail = new Label();
            lblTcKimlik = new Label();
            lblEhliyetNo = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtTelefon = new TextBox();
            txtMail = new TextBox();
            txtTcKimlikNo = new TextBox();
            txtEhliyetNo = new TextBox();
            lblGorev = new Label();
            lblPassword = new Label();
            txtPasswordR = new TextBox();
            lblPasswordR = new Label();
            cmbGorev = new ComboBox();
            txtPassword = new TextBox();
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
            lblTelefon.Location = new Point(76, 86);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(86, 21);
            lblTelefon.TabIndex = 9;
            lblTelefon.Text = "TELEFON :";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMail.Location = new Point(76, 128);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(57, 21);
            lblMail.TabIndex = 10;
            lblMail.Text = "MAİL :";
            // 
            // lblTcKimlik
            // 
            lblTcKimlik.AutoSize = true;
            lblTcKimlik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTcKimlik.Location = new Point(76, 170);
            lblTcKimlik.Name = "lblTcKimlik";
            lblTcKimlik.Size = new Size(122, 21);
            lblTcKimlik.TabIndex = 11;
            lblTcKimlik.Text = "TC KİMLİK NO :";
            // 
            // lblEhliyetNo
            // 
            lblEhliyetNo.Location = new Point(0, 0);
            lblEhliyetNo.Name = "lblEhliyetNo";
            lblEhliyetNo.Size = new Size(100, 23);
            lblEhliyetNo.TabIndex = 0;
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
            txtTelefon.Location = new Point(274, 78);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(222, 29);
            txtTelefon.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMail.Location = new Point(274, 120);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(222, 29);
            txtMail.TabIndex = 3;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTcKimlikNo.Location = new Point(274, 162);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(222, 29);
            txtTcKimlikNo.TabIndex = 4;
            // 
            // txtEhliyetNo
            // 
            txtEhliyetNo.Location = new Point(0, 0);
            txtEhliyetNo.Name = "txtEhliyetNo";
            txtEhliyetNo.Size = new Size(100, 23);
            txtEhliyetNo.TabIndex = 0;
            // 
            // lblGorev
            // 
            lblGorev.AutoSize = true;
            lblGorev.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGorev.Location = new Point(76, 212);
            lblGorev.Name = "lblGorev";
            lblGorev.Size = new Size(71, 21);
            lblGorev.TabIndex = 13;
            lblGorev.Text = "GÖREV :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(76, 254);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 21);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "ŞİFRE :";
            // 
            // txtPasswordR
            // 
            txtPasswordR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPasswordR.Location = new Point(274, 288);
            txtPasswordR.Name = "txtPasswordR";
            txtPasswordR.Size = new Size(222, 29);
            txtPasswordR.TabIndex = 16;
            // 
            // lblPasswordR
            // 
            lblPasswordR.AutoSize = true;
            lblPasswordR.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPasswordR.Location = new Point(76, 296);
            lblPasswordR.Name = "lblPasswordR";
            lblPasswordR.Size = new Size(122, 21);
            lblPasswordR.TabIndex = 17;
            lblPasswordR.Text = "ŞİFRE TEKRAR :";
            // 
            // cmbGorev
            // 
            cmbGorev.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbGorev.FormattingEnabled = true;
            cmbGorev.Location = new Point(274, 204);
            cmbGorev.Name = "cmbGorev";
            cmbGorev.Size = new Size(222, 29);
            cmbGorev.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPassword.Location = new Point(274, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 29);
            txtPassword.TabIndex = 21;
            // 
            // SettingsUsersAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 430);
            Controls.Add(txtPassword);
            Controls.Add(cmbGorev);
            Controls.Add(txtPasswordR);
            Controls.Add(lblPasswordR);
            Controls.Add(lblPassword);
            Controls.Add(lblGorev);
            Controls.Add(txtTcKimlikNo);
            Controls.Add(txtMail);
            Controls.Add(txtTelefon);
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
            Name = "SettingsUsersAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "YENİ PERSONEL EKLE";
            Load += SettingsUsersAddEdit_Load;
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
        private ErrorProvider errorProvider1;
        private TextBox txtEhliyetNo;
        private TextBox txtTcKimlikNo;
        private TextBox txtMail;
        private TextBox txtTelefon;
        private TextBox txtPasswordR;
        private Label lblPasswordR;
        private TextBox textBox2;
        private Label lblPassword;
        private TextBox textBox1;
        private Label lblGorev;
        private ComboBox cmbGorev;
        private TextBox txtPassword;
    }
}