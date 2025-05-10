namespace CarRentalAutomation
{
    partial class HomePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            _lblKasaTutari = new Label();
            lblKasaTutari = new Label();
            pnlKasaTutari = new Panel();
            pnlCars = new Panel();
            lblMusaitAraclar = new Label();
            dgvCars = new DataGridView();
            panel3 = new Panel();
            _lblKullanilamazArac = new Label();
            lblKullanilamazArac = new Label();
            _lblKullanilabilirArac = new Label();
            lblKullanilabilirArac = new Label();
            _lblToplamAracSayisi = new Label();
            lblToplamAracSayisi = new Label();
            dgvBakim = new DataGridView();
            pnlBakim = new Panel();
            lblBakim = new Label();
            pnlCarReturn = new Panel();
            _lblCarReturn2 = new Label();
            lblCarReturn2 = new Label();
            _lblCarReturn = new Label();
            lblCarReturn = new Label();
            pnlChart = new Panel();
            chartDailyRentals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            dgvSigorta = new DataGridView();
            pnlSigorta = new Panel();
            lblSigorta = new Label();
            pnlKasaTutari.SuspendLayout();
            pnlCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBakim).BeginInit();
            pnlBakim.SuspendLayout();
            pnlCarReturn.SuspendLayout();
            pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDailyRentals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSigorta).BeginInit();
            pnlSigorta.SuspendLayout();
            SuspendLayout();
            // 
            // _lblKasaTutari
            // 
            _lblKasaTutari.AutoSize = true;
            _lblKasaTutari.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblKasaTutari.Location = new Point(53, 31);
            _lblKasaTutari.Name = "_lblKasaTutari";
            _lblKasaTutari.Size = new Size(110, 21);
            _lblKasaTutari.TabIndex = 39;
            _lblKasaTutari.Text = "KASA TUTARI";
            // 
            // lblKasaTutari
            // 
            lblKasaTutari.BackColor = SystemColors.Control;
            lblKasaTutari.BorderStyle = BorderStyle.FixedSingle;
            lblKasaTutari.FlatStyle = FlatStyle.Flat;
            lblKasaTutari.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKasaTutari.Location = new Point(13, 54);
            lblKasaTutari.Name = "lblKasaTutari";
            lblKasaTutari.Size = new Size(197, 63);
            lblKasaTutari.TabIndex = 38;
            lblKasaTutari.Text = "0 TL";
            lblKasaTutari.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlKasaTutari
            // 
            pnlKasaTutari.BackColor = Color.FromArgb(184, 12, 9);
            pnlKasaTutari.BorderStyle = BorderStyle.FixedSingle;
            pnlKasaTutari.Controls.Add(_lblKasaTutari);
            pnlKasaTutari.Controls.Add(lblKasaTutari);
            pnlKasaTutari.Location = new Point(42, 40);
            pnlKasaTutari.Name = "pnlKasaTutari";
            pnlKasaTutari.Size = new Size(224, 150);
            pnlKasaTutari.TabIndex = 40;
            // 
            // pnlCars
            // 
            pnlCars.BackColor = Color.FromArgb(184, 12, 9);
            pnlCars.BorderStyle = BorderStyle.FixedSingle;
            pnlCars.Controls.Add(lblMusaitAraclar);
            pnlCars.Location = new Point(42, 225);
            pnlCars.Name = "pnlCars";
            pnlCars.Size = new Size(392, 331);
            pnlCars.TabIndex = 41;
            // 
            // lblMusaitAraclar
            // 
            lblMusaitAraclar.AutoSize = true;
            lblMusaitAraclar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMusaitAraclar.Location = new Point(122, 17);
            lblMusaitAraclar.Name = "lblMusaitAraclar";
            lblMusaitAraclar.Size = new Size(146, 21);
            lblMusaitAraclar.TabIndex = 40;
            lblMusaitAraclar.Text = "MÜSAİT ARAÇLAR";
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeColumns = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.ColumnHeadersHeight = 25;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCars.Location = new Point(46, 267);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCars.RowTemplate.Height = 35;
            dgvCars.RowTemplate.ReadOnly = true;
            dgvCars.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(384, 285);
            dgvCars.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(184, 12, 9);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(_lblKullanilamazArac);
            panel3.Controls.Add(lblKullanilamazArac);
            panel3.Controls.Add(_lblKullanilabilirArac);
            panel3.Controls.Add(lblKullanilabilirArac);
            panel3.Controls.Add(_lblToplamAracSayisi);
            panel3.Controls.Add(lblToplamAracSayisi);
            panel3.Location = new Point(300, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 150);
            panel3.TabIndex = 41;
            // 
            // _lblKullanilamazArac
            // 
            _lblKullanilamazArac.AutoSize = true;
            _lblKullanilamazArac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblKullanilamazArac.Location = new Point(442, 31);
            _lblKullanilamazArac.Name = "_lblKullanilamazArac";
            _lblKullanilamazArac.Size = new Size(178, 21);
            _lblKullanilamazArac.TabIndex = 43;
            _lblKullanilamazArac.Text = "KULLANILAMAZ ARAÇ";
            // 
            // lblKullanilamazArac
            // 
            lblKullanilamazArac.BackColor = SystemColors.Control;
            lblKullanilamazArac.BorderStyle = BorderStyle.FixedSingle;
            lblKullanilamazArac.FlatStyle = FlatStyle.Flat;
            lblKullanilamazArac.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullanilamazArac.Location = new Point(473, 54);
            lblKullanilamazArac.Name = "lblKullanilamazArac";
            lblKullanilamazArac.Size = new Size(97, 63);
            lblKullanilamazArac.TabIndex = 42;
            lblKullanilamazArac.Text = "0";
            lblKullanilamazArac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblKullanilabilirArac
            // 
            _lblKullanilabilirArac.AutoSize = true;
            _lblKullanilabilirArac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblKullanilabilirArac.Location = new Point(235, 31);
            _lblKullanilabilirArac.Name = "_lblKullanilabilirArac";
            _lblKullanilabilirArac.Size = new Size(180, 21);
            _lblKullanilabilirArac.TabIndex = 41;
            _lblKullanilabilirArac.Text = "KULLANILABİLİR ARAÇ";
            // 
            // lblKullanilabilirArac
            // 
            lblKullanilabilirArac.BackColor = SystemColors.Control;
            lblKullanilabilirArac.BorderStyle = BorderStyle.FixedSingle;
            lblKullanilabilirArac.FlatStyle = FlatStyle.Flat;
            lblKullanilabilirArac.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullanilabilirArac.Location = new Point(266, 54);
            lblKullanilabilirArac.Name = "lblKullanilabilirArac";
            lblKullanilabilirArac.Size = new Size(97, 63);
            lblKullanilabilirArac.TabIndex = 40;
            lblKullanilabilirArac.Text = "0";
            lblKullanilabilirArac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblToplamAracSayisi
            // 
            _lblToplamAracSayisi.AutoSize = true;
            _lblToplamAracSayisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblToplamAracSayisi.Location = new Point(39, 31);
            _lblToplamAracSayisi.Name = "_lblToplamAracSayisi";
            _lblToplamAracSayisi.Size = new Size(172, 21);
            _lblToplamAracSayisi.TabIndex = 39;
            _lblToplamAracSayisi.Text = "TOPLAM ARAÇ SAYISI";
            // 
            // lblToplamAracSayisi
            // 
            lblToplamAracSayisi.BackColor = SystemColors.Control;
            lblToplamAracSayisi.BorderStyle = BorderStyle.FixedSingle;
            lblToplamAracSayisi.FlatStyle = FlatStyle.Flat;
            lblToplamAracSayisi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamAracSayisi.Location = new Point(70, 54);
            lblToplamAracSayisi.Name = "lblToplamAracSayisi";
            lblToplamAracSayisi.Size = new Size(97, 63);
            lblToplamAracSayisi.TabIndex = 38;
            lblToplamAracSayisi.Text = "0";
            lblToplamAracSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBakim
            // 
            dgvBakim.AllowUserToAddRows = false;
            dgvBakim.AllowUserToDeleteRows = false;
            dgvBakim.AllowUserToResizeColumns = false;
            dgvBakim.AllowUserToResizeRows = false;
            dgvBakim.ColumnHeadersHeight = 25;
            dgvBakim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBakim.Location = new Point(475, 279);
            dgvBakim.MultiSelect = false;
            dgvBakim.Name = "dgvBakim";
            dgvBakim.ReadOnly = true;
            dgvBakim.RowHeadersVisible = false;
            dgvBakim.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBakim.RowTemplate.Height = 35;
            dgvBakim.RowTemplate.ReadOnly = true;
            dgvBakim.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvBakim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBakim.Size = new Size(482, 273);
            dgvBakim.TabIndex = 42;
            // 
            // pnlBakim
            // 
            pnlBakim.BackColor = Color.FromArgb(184, 12, 9);
            pnlBakim.BorderStyle = BorderStyle.FixedSingle;
            pnlBakim.Controls.Add(lblBakim);
            pnlBakim.Location = new Point(471, 225);
            pnlBakim.Name = "pnlBakim";
            pnlBakim.Size = new Size(490, 331);
            pnlBakim.TabIndex = 43;
            // 
            // lblBakim
            // 
            lblBakim.AutoSize = true;
            lblBakim.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBakim.Location = new Point(131, 17);
            lblBakim.Name = "lblBakim";
            lblBakim.Size = new Size(227, 21);
            lblBakim.TabIndex = 40;
            lblBakim.Text = "BAKIMI YAKLAŞAN ARAÇLAR";
            // 
            // pnlCarReturn
            // 
            pnlCarReturn.BackColor = Color.FromArgb(184, 12, 9);
            pnlCarReturn.BorderStyle = BorderStyle.FixedSingle;
            pnlCarReturn.Controls.Add(_lblCarReturn2);
            pnlCarReturn.Controls.Add(lblCarReturn2);
            pnlCarReturn.Controls.Add(_lblCarReturn);
            pnlCarReturn.Controls.Add(lblCarReturn);
            pnlCarReturn.Location = new Point(994, 40);
            pnlCarReturn.Name = "pnlCarReturn";
            pnlCarReturn.Size = new Size(476, 150);
            pnlCarReturn.TabIndex = 44;
            // 
            // _lblCarReturn2
            // 
            _lblCarReturn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblCarReturn2.Location = new Point(258, 21);
            _lblCarReturn2.Name = "_lblCarReturn2";
            _lblCarReturn2.Size = new Size(166, 42);
            _lblCarReturn2.TabIndex = 41;
            _lblCarReturn2.Text = "YARIN DÖNECEK ARAÇ SAYISI";
            _lblCarReturn2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCarReturn2
            // 
            lblCarReturn2.BackColor = SystemColors.Control;
            lblCarReturn2.BorderStyle = BorderStyle.FixedSingle;
            lblCarReturn2.FlatStyle = FlatStyle.Flat;
            lblCarReturn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCarReturn2.Location = new Point(293, 65);
            lblCarReturn2.Name = "lblCarReturn2";
            lblCarReturn2.Size = new Size(97, 63);
            lblCarReturn2.TabIndex = 40;
            lblCarReturn2.Text = "0";
            lblCarReturn2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _lblCarReturn
            // 
            _lblCarReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblCarReturn.Location = new Point(51, 21);
            _lblCarReturn.Name = "_lblCarReturn";
            _lblCarReturn.Size = new Size(166, 42);
            _lblCarReturn.TabIndex = 39;
            _lblCarReturn.Text = "BUGÜN DÖNECEK ARAÇ SAYISI";
            _lblCarReturn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCarReturn
            // 
            lblCarReturn.BackColor = SystemColors.Control;
            lblCarReturn.BorderStyle = BorderStyle.FixedSingle;
            lblCarReturn.FlatStyle = FlatStyle.Flat;
            lblCarReturn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCarReturn.Location = new Point(86, 65);
            lblCarReturn.Name = "lblCarReturn";
            lblCarReturn.Size = new Size(97, 63);
            lblCarReturn.TabIndex = 38;
            lblCarReturn.Text = "0";
            lblCarReturn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.FromArgb(184, 12, 9);
            pnlChart.BorderStyle = BorderStyle.FixedSingle;
            pnlChart.Controls.Add(chartDailyRentals);
            pnlChart.Controls.Add(label2);
            pnlChart.Location = new Point(42, 582);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(1428, 296);
            pnlChart.TabIndex = 44;
            // 
            // chartDailyRentals
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = 90;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            chartDailyRentals.ChartAreas.Add(chartArea2);
            chartDailyRentals.Location = new Point(14, 38);
            chartDailyRentals.Name = "chartDailyRentals";
            chartDailyRentals.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Günlük Araç Adetleri";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chartDailyRentals.Series.Add(series2);
            chartDailyRentals.Size = new Size(1409, 253);
            chartDailyRentals.TabIndex = 41;
            chartDailyRentals.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(585, 14);
            label2.Name = "label2";
            label2.Size = new Size(256, 21);
            label2.TabIndex = 40;
            label2.Text = "GÜN BAZLI KİRALAMA ADETLERİ";
            // 
            // dgvSigorta
            // 
            dgvSigorta.AllowUserToAddRows = false;
            dgvSigorta.AllowUserToDeleteRows = false;
            dgvSigorta.AllowUserToResizeColumns = false;
            dgvSigorta.AllowUserToResizeRows = false;
            dgvSigorta.ColumnHeadersHeight = 25;
            dgvSigorta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSigorta.Location = new Point(998, 279);
            dgvSigorta.MultiSelect = false;
            dgvSigorta.Name = "dgvSigorta";
            dgvSigorta.ReadOnly = true;
            dgvSigorta.RowHeadersVisible = false;
            dgvSigorta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSigorta.RowTemplate.Height = 35;
            dgvSigorta.RowTemplate.ReadOnly = true;
            dgvSigorta.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvSigorta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSigorta.Size = new Size(468, 273);
            dgvSigorta.TabIndex = 45;
            // 
            // pnlSigorta
            // 
            pnlSigorta.BackColor = Color.FromArgb(184, 12, 9);
            pnlSigorta.BorderStyle = BorderStyle.FixedSingle;
            pnlSigorta.Controls.Add(lblSigorta);
            pnlSigorta.Location = new Point(994, 225);
            pnlSigorta.Name = "pnlSigorta";
            pnlSigorta.Size = new Size(476, 331);
            pnlSigorta.TabIndex = 46;
            // 
            // lblSigorta
            // 
            lblSigorta.AutoSize = true;
            lblSigorta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSigorta.Location = new Point(92, 17);
            lblSigorta.Name = "lblSigorta";
            lblSigorta.Size = new Size(290, 21);
            lblSigorta.TabIndex = 40;
            lblSigorta.Text = "SİGORTA BİTİMİ YAKLAŞAN ARAÇLAR";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1505, 910);
            Controls.Add(dgvSigorta);
            Controls.Add(pnlSigorta);
            Controls.Add(pnlChart);
            Controls.Add(pnlCarReturn);
            Controls.Add(dgvBakim);
            Controls.Add(pnlBakim);
            Controls.Add(panel3);
            Controls.Add(dgvCars);
            Controls.Add(pnlCars);
            Controls.Add(pnlKasaTutari);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomePage";
            ShowIcon = false;
            Text = "HomePage";
            Load += HomePage_Load;
            pnlKasaTutari.ResumeLayout(false);
            pnlKasaTutari.PerformLayout();
            pnlCars.ResumeLayout(false);
            pnlCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBakim).EndInit();
            pnlBakim.ResumeLayout(false);
            pnlBakim.PerformLayout();
            pnlCarReturn.ResumeLayout(false);
            pnlChart.ResumeLayout(false);
            pnlChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDailyRentals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSigorta).EndInit();
            pnlSigorta.ResumeLayout(false);
            pnlSigorta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label _lblKasaTutari;
        private Label lblKasaTutari;
        private Panel pnlKasaTutari;
        private Panel pnlCars;
        private Label lblMusaitAraclar;
        private DataGridView dgvCars;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label _lblToplamAracSayisi;
        private Label lblToplamAracSayisi;
        private Label _lblKullanilamazArac;
        private Label lblKullanilamazArac;
        private Label _lblKullanilabilirArac;
        private Label lblKullanilabilirArac;
        private DataGridView dgvBakim;
        private Panel pnlBakim;
        private Label lblBakim;
        private Panel pnlCarReturn;
        private Label _lblCarReturn;
        private Label lblCarReturn;
        private Panel pnlChart;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyRentals;
        private DataGridView dgvSigorta;
        private Panel pnlSigorta;
        private Label lblSigorta;
        private Label _lblCarReturn2;
        private Label lblCarReturn2;
    }
}