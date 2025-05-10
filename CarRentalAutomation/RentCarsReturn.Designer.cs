namespace CarRentalAutomation
{
    partial class RentCarsReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCarsReturn));
            lblTeslimNotu = new Label();
            txtTeslimNotu = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblKalanTutar = new Label();
            btnOdemeAl = new Button();
            _lblKalanTutar = new Label();
            txtOdenenTutar = new TextBox();
            lblOdenenTutar = new Label();
            rbKrediKarti = new RadioButton();
            rbNakit = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTeslimNotu
            // 
            lblTeslimNotu.AutoSize = true;
            lblTeslimNotu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTeslimNotu.Location = new Point(12, 9);
            lblTeslimNotu.Name = "lblTeslimNotu";
            lblTeslimNotu.Size = new Size(122, 21);
            lblTeslimNotu.TabIndex = 9;
            lblTeslimNotu.Text = "TESLİM NOTU :";
            // 
            // txtTeslimNotu
            // 
            txtTeslimNotu.Location = new Point(12, 33);
            txtTeslimNotu.Multiline = true;
            txtTeslimNotu.Name = "txtTeslimNotu";
            txtTeslimNotu.Size = new Size(519, 154);
            txtTeslimNotu.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Ionic_Ionicons_Close_circle_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(283, 499);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(197, 56);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(182, 12, 9);
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Ionic_Ionicons_Checkmark_circle_32;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(68, 499);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(197, 56);
            btnSave.TabIndex = 11;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblKalanTutar
            // 
            lblKalanTutar.BorderStyle = BorderStyle.FixedSingle;
            lblKalanTutar.FlatStyle = FlatStyle.Flat;
            lblKalanTutar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKalanTutar.Location = new Point(167, 220);
            lblKalanTutar.Name = "lblKalanTutar";
            lblKalanTutar.Size = new Size(197, 56);
            lblKalanTutar.TabIndex = 35;
            lblKalanTutar.Text = "0 TL";
            lblKalanTutar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.BackColor = Color.FromArgb(182, 12, 9);
            btnOdemeAl.FlatAppearance.BorderColor = Color.Black;
            btnOdemeAl.FlatStyle = FlatStyle.Flat;
            btnOdemeAl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdemeAl.Image = Properties.Resources.Ionic_Ionicons_Receipt_32;
            btnOdemeAl.ImageAlign = ContentAlignment.MiddleRight;
            btnOdemeAl.Location = new Point(167, 407);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(197, 56);
            btnOdemeAl.TabIndex = 36;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // _lblKalanTutar
            // 
            _lblKalanTutar.AutoSize = true;
            _lblKalanTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblKalanTutar.Location = new Point(207, 199);
            _lblKalanTutar.Name = "_lblKalanTutar";
            _lblKalanTutar.Size = new Size(121, 21);
            _lblKalanTutar.TabIndex = 37;
            _lblKalanTutar.Text = "KALAN TUTAR:";
            // 
            // txtOdenenTutar
            // 
            txtOdenenTutar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOdenenTutar.Location = new Point(167, 309);
            txtOdenenTutar.Name = "txtOdenenTutar";
            txtOdenenTutar.Size = new Size(197, 43);
            txtOdenenTutar.TabIndex = 46;
            txtOdenenTutar.TextAlign = HorizontalAlignment.Center;
            txtOdenenTutar.KeyPress += txtOdenenTutar_KeyPress;
            // 
            // lblOdenenTutar
            // 
            lblOdenenTutar.AutoSize = true;
            lblOdenenTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOdenenTutar.Location = new Point(201, 285);
            lblOdenenTutar.Name = "lblOdenenTutar";
            lblOdenenTutar.Size = new Size(136, 21);
            lblOdenenTutar.TabIndex = 45;
            lblOdenenTutar.Text = "ÖDENEN TUTAR:";
            // 
            // rbKrediKarti
            // 
            rbKrediKarti.AutoSize = true;
            rbKrediKarti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbKrediKarti.Location = new Point(266, 370);
            rbKrediKarti.Name = "rbKrediKarti";
            rbKrediKarti.Size = new Size(98, 19);
            rbKrediKarti.TabIndex = 44;
            rbKrediKarti.TabStop = true;
            rbKrediKarti.Text = "KREDİ KARTI";
            rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.CheckAlign = ContentAlignment.MiddleRight;
            rbNakit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbNakit.Location = new Point(167, 370);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new Size(61, 19);
            rbNakit.TabIndex = 43;
            rbNakit.TabStop = true;
            rbNakit.Text = "NAKİT";
            rbNakit.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // RentCarsReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 565);
            Controls.Add(txtOdenenTutar);
            Controls.Add(lblOdenenTutar);
            Controls.Add(rbKrediKarti);
            Controls.Add(rbNakit);
            Controls.Add(_lblKalanTutar);
            Controls.Add(btnOdemeAl);
            Controls.Add(lblKalanTutar);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTeslimNotu);
            Controls.Add(lblTeslimNotu);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RentCarsReturn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ARAÇ TESLİM AL";
            Load += RentCarsReturn_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTeslimNotu;
        private TextBox txtTeslimNotu;
        private Button btnCancel;
        private Button btnSave;
        private Label lblKalanTutar;
        private Button btnOdemeAl;
        private Label _lblKalanTutar;
        private TextBox txtOdenenTutar;
        private Label lblOdenenTutar;
        private RadioButton rbKrediKarti;
        private RadioButton rbNakit;
        private ErrorProvider errorProvider1;
    }
}