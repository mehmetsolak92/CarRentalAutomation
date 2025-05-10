namespace CarRentalAutomation
{
    partial class CarsList
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
            dgvCars = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExportCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeColumns = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.ColumnHeadersHeight = 25;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCars.Location = new Point(12, 11);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCars.RowTemplate.Height = 35;
            dgvCars.RowTemplate.ReadOnly = true;
            dgvCars.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1254, 809);
            dgvCars.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(182, 12, 9);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Image = Properties.Resources.Ionic_Ionicons_Add_circle_32;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(1272, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 49);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "YENİ KAYIT";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(182, 12, 9);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.Image = Properties.Resources.Ionic_Ionicons_Create_32;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(1272, 66);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(197, 49);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "DÜZENLE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 12, 9);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Image = Properties.Resources.Ionic_Ionicons_Trash_32;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(1272, 121);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(197, 49);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.FromArgb(182, 12, 9);
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExportCsv.Image = Properties.Resources.Icons8_Windows_8_Logos_Excel_32;
            btnExportCsv.ImageAlign = ContentAlignment.MiddleRight;
            btnExportCsv.Location = new Point(1272, 176);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(197, 49);
            btnExportCsv.TabIndex = 6;
            btnExportCsv.Text = "DIŞA AKTAR";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // CarsList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 833);
            Controls.Add(btnExportCsv);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCars);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarsList";
            Text = "Cars";
            Load += CarsList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCars;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExportCsv;
    }
}