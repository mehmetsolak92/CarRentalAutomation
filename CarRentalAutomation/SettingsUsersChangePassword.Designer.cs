namespace CarRentalAutomation
{
    partial class SettingsUsersChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUsersChangePassword));
            lblNewPassword = new Label();
            lblOldPassword = new Label();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            lblNewPasswordR = new Label();
            txtNewPasswordR = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNewPassword.ForeColor = SystemColors.Control;
            lblNewPassword.Location = new Point(121, 63);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(156, 26);
            lblNewPassword.TabIndex = 9;
            lblNewPassword.Text = "YENİ ŞİFRE";
            lblNewPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOldPassword
            // 
            lblOldPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOldPassword.ForeColor = SystemColors.Control;
            lblOldPassword.Location = new Point(121, 8);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(156, 26);
            lblOldPassword.TabIndex = 8;
            lblOldPassword.Text = "ESKİ ŞİFRE";
            lblOldPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Location = new Point(48, 91);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(292, 25);
            txtNewPassword.TabIndex = 7;
            // 
            // txtOldPassword
            // 
            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtOldPassword.Location = new Point(48, 36);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(292, 25);
            txtOldPassword.TabIndex = 6;
            // 
            // lblNewPasswordR
            // 
            lblNewPasswordR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNewPasswordR.ForeColor = SystemColors.Control;
            lblNewPasswordR.Location = new Point(82, 118);
            lblNewPasswordR.Name = "lblNewPasswordR";
            lblNewPasswordR.Size = new Size(241, 26);
            lblNewPasswordR.TabIndex = 11;
            lblNewPasswordR.Text = "YENİ ŞİFRE TEKRARI";
            lblNewPasswordR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewPasswordR
            // 
            txtNewPasswordR.BorderStyle = BorderStyle.FixedSingle;
            txtNewPasswordR.Location = new Point(49, 146);
            txtNewPasswordR.Name = "txtNewPasswordR";
            txtNewPasswordR.PasswordChar = '*';
            txtNewPasswordR.Size = new Size(292, 25);
            txtNewPasswordR.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(182, 12, 9);
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Ionic_Ionicons_Close_circle_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(199, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 56);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Ionic_Ionicons_Checkmark_circle_32;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(54, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 56);
            btnSave.TabIndex = 12;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // SettingsUsersChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(184, 12, 9);
            ClientSize = new Size(391, 257);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblNewPasswordR);
            Controls.Add(txtNewPasswordR);
            Controls.Add(lblNewPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsUsersChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ŞİFRE DEĞİŞTİR";
            Load += SettingsUsersChangePassword_Load;
            KeyDown += SettingsUsersChangePassword_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewPassword;
        private Label lblOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Label lblNewPasswordR;
        private TextBox txtNewPasswordR;
        private Button btnCancel;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}