namespace CarRentalAutomation
{
    partial class Finance
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
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lblRentEnd = new Label();
            lblRentStart = new Label();
            dgvPayments = new DataGridView();
            btnFilter = new Button();
            _lblGelenOdeme = new Label();
            lblGelenOdeme = new Label();
            _lblGidenOdeme = new Label();
            lblGidenOdeme = new Label();
            btnGider = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpEndDate.Location = new Point(335, 95);
            dtpEndDate.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(222, 25);
            dtpEndDate.TabIndex = 41;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpStartDate.Location = new Point(335, 51);
            dtpStartDate.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(222, 25);
            dtpStartDate.TabIndex = 40;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // lblRentEnd
            // 
            lblRentEnd.AutoSize = true;
            lblRentEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentEnd.Location = new Point(58, 100);
            lblRentEnd.Name = "lblRentEnd";
            lblRentEnd.Size = new Size(111, 21);
            lblRentEnd.TabIndex = 39;
            lblRentEnd.Text = "TARİH BİTİŞİ :";
            // 
            // lblRentStart
            // 
            lblRentStart.AutoSize = true;
            lblRentStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentStart.Location = new Point(58, 56);
            lblRentStart.Name = "lblRentStart";
            lblRentStart.Size = new Size(161, 21);
            lblRentStart.TabIndex = 38;
            lblRentStart.Text = "TARİH BAŞLANGICI :";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeColumns = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.ColumnHeadersHeight = 25;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPayments.Location = new Point(58, 147);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPayments.RowTemplate.Height = 35;
            dgvPayments.RowTemplate.ReadOnly = true;
            dgvPayments.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1079, 751);
            dgvPayments.TabIndex = 37;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(184, 12, 9);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFilter.Image = Properties.Resources.Ionic_Ionicons_Search_circle_32;
            btnFilter.ImageAlign = ContentAlignment.MiddleRight;
            btnFilter.Location = new Point(920, 51);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(217, 69);
            btnFilter.TabIndex = 42;
            btnFilter.Text = "FİLTRELE";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // _lblGelenOdeme
            // 
            _lblGelenOdeme.AutoSize = true;
            _lblGelenOdeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblGelenOdeme.Location = new Point(1224, 147);
            _lblGelenOdeme.Name = "_lblGelenOdeme";
            _lblGelenOdeme.Size = new Size(202, 21);
            _lblGelenOdeme.TabIndex = 46;
            _lblGelenOdeme.Text = "GELEN ÖDEME TOPLAMI :";
            // 
            // lblGelenOdeme
            // 
            lblGelenOdeme.BorderStyle = BorderStyle.FixedSingle;
            lblGelenOdeme.FlatStyle = FlatStyle.Flat;
            lblGelenOdeme.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGelenOdeme.Location = new Point(1224, 179);
            lblGelenOdeme.Name = "lblGelenOdeme";
            lblGelenOdeme.Size = new Size(197, 56);
            lblGelenOdeme.TabIndex = 45;
            lblGelenOdeme.Text = "0 TL";
            lblGelenOdeme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblGidenOdeme
            // 
            _lblGidenOdeme.AutoSize = true;
            _lblGidenOdeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblGidenOdeme.Location = new Point(1224, 278);
            _lblGidenOdeme.Name = "_lblGidenOdeme";
            _lblGidenOdeme.Size = new Size(202, 21);
            _lblGidenOdeme.TabIndex = 48;
            _lblGidenOdeme.Text = "GİDEN ÖDEME TOPLAMI :";
            // 
            // lblGidenOdeme
            // 
            lblGidenOdeme.BorderStyle = BorderStyle.FixedSingle;
            lblGidenOdeme.FlatStyle = FlatStyle.Flat;
            lblGidenOdeme.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGidenOdeme.Location = new Point(1224, 310);
            lblGidenOdeme.Name = "lblGidenOdeme";
            lblGidenOdeme.Size = new Size(197, 56);
            lblGidenOdeme.TabIndex = 47;
            lblGidenOdeme.Text = "0 TL";
            lblGidenOdeme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGider
            // 
            btnGider.BackColor = Color.FromArgb(184, 12, 9);
            btnGider.FlatStyle = FlatStyle.Flat;
            btnGider.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGider.Image = Properties.Resources.Ionic_Ionicons_Search_circle_32;
            btnGider.ImageAlign = ContentAlignment.MiddleRight;
            btnGider.Location = new Point(1219, 829);
            btnGider.Name = "btnGider";
            btnGider.Size = new Size(202, 69);
            btnGider.TabIndex = 49;
            btnGider.Text = "GİDER GİR";
            btnGider.UseVisualStyleBackColor = false;
            btnGider.Click += btnGider_Click;
            // 
            // Finance
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 910);
            Controls.Add(btnGider);
            Controls.Add(_lblGidenOdeme);
            Controls.Add(lblGidenOdeme);
            Controls.Add(_lblGelenOdeme);
            Controls.Add(lblGelenOdeme);
            Controls.Add(btnFilter);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblRentEnd);
            Controls.Add(lblRentStart);
            Controls.Add(dgvPayments);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Finance";
            Text = "Finance";
            Load += Finance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label lblRentEnd;
        private Label lblRentStart;
        private DataGridView dgvPayments;
        private Button btnFilter;
        private Label _lblGelenOdeme;
        private Label lblGelenOdeme;
        private Label _lblGidenOdeme;
        private Label lblGidenOdeme;
        private Button btnGider;
    }
}