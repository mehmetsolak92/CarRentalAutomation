namespace CarRentalAutomation
{
    partial class SettingsUsers
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
            gbPersonel = new GroupBox();
            dgvStaffs = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnChangePass = new Button();
            gbPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).BeginInit();
            SuspendLayout();
            // 
            // gbPersonel
            // 
            gbPersonel.Controls.Add(dgvStaffs);
            gbPersonel.Location = new Point(12, 12);
            gbPersonel.Name = "gbPersonel";
            gbPersonel.Size = new Size(998, 460);
            gbPersonel.TabIndex = 0;
            gbPersonel.TabStop = false;
            gbPersonel.Text = "Personel Listesi";
            // 
            // dgvStaffs
            // 
            dgvStaffs.AllowUserToAddRows = false;
            dgvStaffs.AllowUserToDeleteRows = false;
            dgvStaffs.AllowUserToResizeColumns = false;
            dgvStaffs.AllowUserToResizeRows = false;
            dgvStaffs.ColumnHeadersHeight = 25;
            dgvStaffs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStaffs.Location = new Point(6, 24);
            dgvStaffs.MultiSelect = false;
            dgvStaffs.Name = "dgvStaffs";
            dgvStaffs.ReadOnly = true;
            dgvStaffs.RowHeadersVisible = false;
            dgvStaffs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStaffs.RowTemplate.Height = 35;
            dgvStaffs.RowTemplate.ReadOnly = true;
            dgvStaffs.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffs.Size = new Size(986, 424);
            dgvStaffs.TabIndex = 33;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 12, 9);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Image = Properties.Resources.Ionic_Ionicons_Trash_32;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(1016, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(197, 49);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(182, 12, 9);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.Image = Properties.Resources.Ionic_Ionicons_Create_32;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(1016, 91);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(197, 49);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "DÜZENLE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(182, 12, 9);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Image = Properties.Resources.Ionic_Ionicons_Add_circle_32;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(1016, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 49);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "YENİ KAYIT";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(182, 12, 9);
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnChangePass.Image = Properties.Resources.Ionic_Ionicons_Create_32;
            btnChangePass.ImageAlign = ContentAlignment.MiddleRight;
            btnChangePass.Location = new Point(1016, 146);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(197, 49);
            btnChangePass.TabIndex = 9;
            btnChangePass.Text = "ŞİFRE DEĞİŞTİR";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // SettingsUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 480);
            Controls.Add(btnChangePass);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(gbPersonel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsUsers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "KULLANICI AYARLARI";
            Load += SettingsUsers_Load;
            gbPersonel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPersonel;
        private DataGridView dgvStaffs;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnChangePass;
    }
}