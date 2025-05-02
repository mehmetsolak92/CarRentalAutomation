namespace CarRentalAutomation
{
    partial class CarsAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsAddEdit));
            btnSave = new Button();
            btnCancel = new Button();
            txtPlaka = new TextBox();
            lblPlaka = new Label();
            lblMarka = new Label();
            lblModel = new Label();
            lblYil = new Label();
            lblVites = new Label();
            lblYakit = new Label();
            lblRenk = new Label();
            lblKilometre = new Label();
            lblUcret = new Label();
            lblSigorta = new Label();
            cmbMarka = new ComboBox();
            cmbModel = new ComboBox();
            cmbYil = new ComboBox();
            cmbVites = new ComboBox();
            cmbYakit = new ComboBox();
            cmbRenk = new ComboBox();
            txtKilometre = new TextBox();
            txtUcret = new TextBox();
            dtpSigorta = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
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
            btnSave.Location = new Point(80, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(197, 56);
            btnSave.TabIndex = 5;
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
            btnCancel.Location = new Point(295, 482);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(197, 56);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPlaka
            // 
            txtPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPlaka.Location = new Point(274, 35);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(222, 29);
            txtPlaka.TabIndex = 7;
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPlaka.Location = new Point(76, 44);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(68, 21);
            lblPlaka.TabIndex = 8;
            lblPlaka.Text = "PLAKA :";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMarka.Location = new Point(76, 87);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(75, 21);
            lblMarka.TabIndex = 9;
            lblMarka.Text = "MARKA :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblModel.Location = new Point(76, 130);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(74, 21);
            lblModel.TabIndex = 10;
            lblModel.Text = "MODEL :";
            // 
            // lblYil
            // 
            lblYil.AutoSize = true;
            lblYil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblYil.Location = new Point(76, 173);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(41, 21);
            lblYil.TabIndex = 11;
            lblYil.Text = "YIL :";
            // 
            // lblVites
            // 
            lblVites.AutoSize = true;
            lblVites.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVites.Location = new Point(76, 216);
            lblVites.Name = "lblVites";
            lblVites.Size = new Size(94, 21);
            lblVites.TabIndex = 12;
            lblVites.Text = "VİTES TİPİ :";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblYakit.Location = new Point(76, 260);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(95, 21);
            lblYakit.TabIndex = 13;
            lblYakit.Text = "YAKIT TİPİ :";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRenk.Location = new Point(76, 303);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(60, 21);
            lblRenk.TabIndex = 14;
            lblRenk.Text = "RENK :";
            // 
            // lblKilometre
            // 
            lblKilometre.AutoSize = true;
            lblKilometre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKilometre.Location = new Point(76, 346);
            lblKilometre.Name = "lblKilometre";
            lblKilometre.Size = new Size(105, 21);
            lblKilometre.TabIndex = 15;
            lblKilometre.Text = "KİLOMETRE :";
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUcret.Location = new Point(76, 389);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(138, 21);
            lblUcret.TabIndex = 16;
            lblUcret.Text = "GÜNLÜK ÜCRET :";
            // 
            // lblSigorta
            // 
            lblSigorta.AutoSize = true;
            lblSigorta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSigorta.Location = new Point(76, 432);
            lblSigorta.Name = "lblSigorta";
            lblSigorta.Size = new Size(181, 21);
            lblSigorta.TabIndex = 17;
            lblSigorta.Text = "SİGORTA BİTİŞ TARİHİ :";
            // 
            // cmbMarka
            // 
            cmbMarka.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(274, 78);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(222, 29);
            cmbMarka.TabIndex = 18;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(274, 121);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(222, 29);
            cmbModel.TabIndex = 19;
            // 
            // cmbYil
            // 
            cmbYil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbYil.FormattingEnabled = true;
            cmbYil.Location = new Point(274, 164);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(222, 29);
            cmbYil.TabIndex = 20;
            // 
            // cmbVites
            // 
            cmbVites.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVites.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbVites.FormattingEnabled = true;
            cmbVites.Location = new Point(274, 207);
            cmbVites.Name = "cmbVites";
            cmbVites.Size = new Size(222, 29);
            cmbVites.TabIndex = 21;
            // 
            // cmbYakit
            // 
            cmbYakit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYakit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbYakit.FormattingEnabled = true;
            cmbYakit.Location = new Point(274, 250);
            cmbYakit.Name = "cmbYakit";
            cmbYakit.Size = new Size(222, 29);
            cmbYakit.TabIndex = 22;
            // 
            // cmbRenk
            // 
            cmbRenk.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRenk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbRenk.FormattingEnabled = true;
            cmbRenk.Location = new Point(274, 290);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(222, 29);
            cmbRenk.TabIndex = 23;
            // 
            // txtKilometre
            // 
            txtKilometre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKilometre.Location = new Point(274, 337);
            txtKilometre.Name = "txtKilometre";
            txtKilometre.Size = new Size(222, 29);
            txtKilometre.TabIndex = 24;
            // 
            // txtUcret
            // 
            txtUcret.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtUcret.Location = new Point(274, 380);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(222, 29);
            txtUcret.TabIndex = 25;
            // 
            // dtpSigorta
            // 
            dtpSigorta.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpSigorta.Location = new Point(274, 430);
            dtpSigorta.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpSigorta.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpSigorta.Name = "dtpSigorta";
            dtpSigorta.Size = new Size(222, 25);
            dtpSigorta.TabIndex = 27;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // CarsAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 564);
            Controls.Add(dtpSigorta);
            Controls.Add(txtUcret);
            Controls.Add(txtKilometre);
            Controls.Add(cmbRenk);
            Controls.Add(cmbYakit);
            Controls.Add(cmbVites);
            Controls.Add(cmbYil);
            Controls.Add(cmbModel);
            Controls.Add(cmbMarka);
            Controls.Add(lblSigorta);
            Controls.Add(lblUcret);
            Controls.Add(lblKilometre);
            Controls.Add(lblRenk);
            Controls.Add(lblYakit);
            Controls.Add(lblVites);
            Controls.Add(lblYil);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Controls.Add(lblPlaka);
            Controls.Add(txtPlaka);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarsAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "YENİ ARAÇ EKLE";
            Load += CarsAddEdit_Load;
            KeyDown += CarsAddEdit_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtPlaka;
        private Label lblPlaka;
        private Label lblMarka;
        private Label lblModel;
        private Label lblYil;
        private Label lblVites;
        private Label lblYakit;
        private Label lblRenk;
        private Label lblKilometre;
        private Label lblUcret;
        private Label lblSigorta;
        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private ComboBox cmbYil;
        private ComboBox cmbVites;
        private ComboBox cmbYakit;
        private ComboBox cmbRenk;
        private TextBox txtKilometre;
        private TextBox txtUcret;
        private DateTimePicker dtpSigorta;
        private ErrorProvider errorProvider1;
    }
}