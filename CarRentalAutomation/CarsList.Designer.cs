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
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(12, 12);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(1460, 843);
            dgvCars.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(182, 12, 9);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Image = Properties.Resources.Ionic_Ionicons_Add_circle_32;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(1478, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 49);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "YENİ KAYIT";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(182, 12, 9);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Image = Properties.Resources.Ionic_Ionicons_Create_32;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(1478, 67);
            button1.Name = "button1";
            button1.Size = new Size(197, 49);
            button1.TabIndex = 4;
            button1.Text = "DÜZENLE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(182, 12, 9);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Image = Properties.Resources.Ionic_Ionicons_Trash_32;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(1478, 122);
            button2.Name = "button2";
            button2.Size = new Size(197, 49);
            button2.TabIndex = 5;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = false;
            // 
            // CarsList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 867);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
    }
}