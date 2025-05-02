namespace CarRentalAutomation
{
    partial class Cars
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
            pnlScreens = new Panel();
            btnCarList = new Button();
            SuspendLayout();
            // 
            // pnlScreens
            // 
            pnlScreens.BackColor = SystemColors.ActiveBorder;
            pnlScreens.Location = new Point(12, 65);
            pnlScreens.Name = "pnlScreens";
            pnlScreens.Size = new Size(1481, 833);
            pnlScreens.TabIndex = 3;
            // 
            // btnCarList
            // 
            btnCarList.BackColor = Color.FromArgb(182, 12, 9);
            btnCarList.FlatStyle = FlatStyle.Flat;
            btnCarList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCarList.Image = Properties.Resources.Ionic_Ionicons_List_circle_32;
            btnCarList.ImageAlign = ContentAlignment.MiddleRight;
            btnCarList.Location = new Point(12, 10);
            btnCarList.Name = "btnCarList";
            btnCarList.Size = new Size(197, 49);
            btnCarList.TabIndex = 4;
            btnCarList.Text = "ARAÇ LİSTESİ";
            btnCarList.UseVisualStyleBackColor = false;
            btnCarList.Click += btnCarList_Click;
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 910);
            Controls.Add(btnCarList);
            Controls.Add(pnlScreens);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cars";
            Text = "Cars";
            Load += Cars_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlScreens;
        private Button btnCarList;
    }
}