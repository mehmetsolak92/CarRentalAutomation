namespace CarRentalAutomation
{
    partial class FinanceOutgoing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceOutgoing));
            txtOdenenTutar = new TextBox();
            lblGiderTutari = new Label();
            rbKrediKarti = new RadioButton();
            rbNakit = new RadioButton();
            btnGiderGir = new Button();
            txtAciklama = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            lblOdemeTarihi = new Label();
            dtpPaymentDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtOdenenTutar
            // 
            txtOdenenTutar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOdenenTutar.Location = new Point(30, 49);
            txtOdenenTutar.Name = "txtOdenenTutar";
            txtOdenenTutar.Size = new Size(197, 43);
            txtOdenenTutar.TabIndex = 51;
            txtOdenenTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGiderTutari
            // 
            lblGiderTutari.AutoSize = true;
            lblGiderTutari.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGiderTutari.Location = new Point(64, 22);
            lblGiderTutari.Name = "lblGiderTutari";
            lblGiderTutari.Size = new Size(124, 21);
            lblGiderTutari.TabIndex = 50;
            lblGiderTutari.Text = "GİDER TUTARI :";
            // 
            // rbKrediKarti
            // 
            rbKrediKarti.AutoSize = true;
            rbKrediKarti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbKrediKarti.Location = new Point(129, 118);
            rbKrediKarti.Name = "rbKrediKarti";
            rbKrediKarti.Size = new Size(98, 19);
            rbKrediKarti.TabIndex = 49;
            rbKrediKarti.TabStop = true;
            rbKrediKarti.Text = "KREDİ KARTI";
            rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.CheckAlign = ContentAlignment.MiddleRight;
            rbNakit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbNakit.Location = new Point(30, 118);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new Size(61, 19);
            rbNakit.TabIndex = 48;
            rbNakit.TabStop = true;
            rbNakit.Text = "NAKİT";
            rbNakit.UseVisualStyleBackColor = true;
            // 
            // btnGiderGir
            // 
            btnGiderGir.BackColor = Color.FromArgb(182, 12, 9);
            btnGiderGir.FlatAppearance.BorderColor = Color.Black;
            btnGiderGir.FlatStyle = FlatStyle.Flat;
            btnGiderGir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiderGir.Image = Properties.Resources.Ionic_Ionicons_Receipt_32;
            btnGiderGir.ImageAlign = ContentAlignment.MiddleRight;
            btnGiderGir.Location = new Point(30, 412);
            btnGiderGir.Name = "btnGiderGir";
            btnGiderGir.Size = new Size(197, 63);
            btnGiderGir.TabIndex = 47;
            btnGiderGir.Text = "GİDER GİR";
            btnGiderGir.UseVisualStyleBackColor = false;
            btnGiderGir.Click += btnGiderGir_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(30, 234);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(197, 171);
            txtAciklama.TabIndex = 52;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // lblOdemeTarihi
            // 
            lblOdemeTarihi.AutoSize = true;
            lblOdemeTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOdemeTarihi.Location = new Point(64, 155);
            lblOdemeTarihi.Name = "lblOdemeTarihi";
            lblOdemeTarihi.Size = new Size(130, 21);
            lblOdemeTarihi.TabIndex = 53;
            lblOdemeTarihi.Text = "ÖDEME TARİHİ :";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpPaymentDate.Location = new Point(30, 188);
            dtpPaymentDate.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpPaymentDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(197, 25);
            dtpPaymentDate.TabIndex = 54;
            // 
            // FinanceOutgoing
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 492);
            Controls.Add(dtpPaymentDate);
            Controls.Add(lblOdemeTarihi);
            Controls.Add(txtAciklama);
            Controls.Add(txtOdenenTutar);
            Controls.Add(lblGiderTutari);
            Controls.Add(rbKrediKarti);
            Controls.Add(rbNakit);
            Controls.Add(btnGiderGir);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FinanceOutgoing";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FinanceOutgoing";
            Load += FinanceOutgoing_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOdenenTutar;
        private Label lblGiderTutari;
        private RadioButton rbKrediKarti;
        private RadioButton rbNakit;
        private Button btnGiderGir;
        private TextBox txtAciklama;
        private ErrorProvider errorProvider1;
        private Label lblOdemeTarihi;
        private DateTimePicker dtpPaymentDate;
    }
}