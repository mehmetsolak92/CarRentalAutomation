namespace CarRentalAutomation
{
    partial class Customers
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
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvCustomers = new DataGridView();
            pnlScreens = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            pnlScreens.SuspendLayout();
            SuspendLayout();
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
            btnDelete.TabIndex = 9;
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
            btnEdit.Location = new Point(1272, 66);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(197, 49);
            btnEdit.TabIndex = 8;
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
            btnAdd.Location = new Point(1272, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 49);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "YENİ KAYIT";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.ColumnHeadersHeight = 25;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Location = new Point(12, 11);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCustomers.RowTemplate.Height = 35;
            dgvCustomers.RowTemplate.ReadOnly = true;
            dgvCustomers.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1254, 809);
            dgvCustomers.TabIndex = 6;
            // 
            // pnlScreens
            // 
            pnlScreens.BackColor = Color.FromArgb(229, 231, 230);
            pnlScreens.Controls.Add(btnDelete);
            pnlScreens.Controls.Add(btnAdd);
            pnlScreens.Controls.Add(btnEdit);
            pnlScreens.Controls.Add(dgvCustomers);
            pnlScreens.Location = new Point(12, 65);
            pnlScreens.Name = "pnlScreens";
            pnlScreens.Size = new Size(1481, 833);
            pnlScreens.TabIndex = 10;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 910);
            Controls.Add(pnlScreens);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            pnlScreens.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvCustomers;
        private Panel pnlScreens;
    }
}