namespace CarRentalAutomation
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            pbUserImg = new PictureBox();
            txtPass = new TextBox();
            lblUser = new Label();
            lblPass = new Label();
            btnCancel = new Button();
            btnEnter = new Button();
            cmbUser = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUserImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbUserImg
            // 
            pbUserImg.Image = Properties.Resources.Ionic_Ionicons_Person_circle_64;
            pbUserImg.Location = new Point(127, 22);
            pbUserImg.Name = "pbUserImg";
            pbUserImg.Size = new Size(108, 107);
            pbUserImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserImg.TabIndex = 1;
            pbUserImg.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(33, 262);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(292, 25);
            txtPass.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUser.ForeColor = SystemColors.Control;
            lblUser.Location = new Point(106, 170);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(156, 26);
            lblUser.TabIndex = 4;
            lblUser.Text = "KULLANICI ADI";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            lblPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPass.ForeColor = SystemColors.Control;
            lblPass.Location = new Point(106, 233);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(156, 26);
            lblPass.TabIndex = 5;
            lblPass.Text = "ŞİFRE";
            lblPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(182, 12, 9);
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Ionic_Ionicons_Close_circle_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(182, 309);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 56);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.Control;
            btnEnter.FlatAppearance.BorderColor = Color.Black;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEnter.Image = Properties.Resources.Ionic_Ionicons_Checkmark_circle_32;
            btnEnter.ImageAlign = ContentAlignment.MiddleRight;
            btnEnter.Location = new Point(33, 309);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(143, 56);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "GİRİŞ";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // cmbUser
            // 
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(33, 199);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(292, 29);
            cmbUser.TabIndex = 21;
            cmbUser.SelectedIndexChanged += cmbUser_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(184, 12, 9);
            ClientSize = new Size(362, 379);
            Controls.Add(cmbUser);
            Controls.Add(btnCancel);
            Controls.Add(btnEnter);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(pbUserImg);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            Load += UserLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbUserImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUserImg;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblPass;
        private Button btnCancel;
        private Button btnEnter;
        private ComboBox cmbUser;
        private ErrorProvider errorProvider1;
    }
}