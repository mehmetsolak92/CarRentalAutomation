using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CarRentalAutomation.Class;
using Microsoft.Data.SqlClient;

namespace CarRentalAutomation
{
    public partial class HomePage : BaseForm
    {
        public HomePage()
        {

            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            KasaTutariHesapla();
            GetAvailableCars();
            GetCarsCount();
            GetBakim();
            GetTodayReturnCount();
            LoadDailyRentalsChart();
            GetSigorta();
        }

        private void KasaTutariHesapla()
        {
            decimal toplamGelir = 0;
            decimal toplamGider = 0;

            string query = $"SELECT SUM(OdemeTutari) FROM OdemeDetaylari WHERE OdemeTuru = 'Gelir'";
            object result = SQL.SelectScalar(query);
            if (result != DBNull.Value) toplamGelir = Convert.ToDecimal(result); else toplamGelir = 0;

            query = $"SELECT SUM(OdemeTutari) FROM OdemeDetaylari WHERE OdemeTuru = 'Gider'";
            result = SQL.SelectScalar(query);
            if (result != DBNull.Value) toplamGider = Convert.ToDecimal(result); else toplamGider = 0;

            lblKasaTutari.Text = (toplamGelir - toplamGider).ToString() + " TL";

        }

        private void GetAvailableCars()
        {
            string query = "SELECT Plaka,Marka,Model,Yil FROM Araclar WHERE Durum = 'Müsait'";
            DataTable dataTable = new DataTable();
            dataTable = SQL.Select(query);
            dgvCars.DataSource = dataTable;
            EditDgvCars();
        }

        private void EditDgvCars()
        {
            if (dgvCars.Rows.Count == 0) return;
            dgvCars.Columns["Plaka"].HeaderText = "Plaka";
            dgvCars.Columns["Marka"].HeaderText = "Marka";
            dgvCars.Columns["Model"].HeaderText = "Model";
            dgvCars.Columns["Yil"].HeaderText = "Yil";

            dgvCars.Columns["Plaka"].Width = 100;
            dgvCars.Columns["Marka"].Width = 100;
            dgvCars.Columns["Model"].Width = 100;
            dgvCars.Columns["Yil"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCars.ColumnHeadersHeight = 35;
        }

        private void GetCarsCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM Araclar";
            count = (int)SQL.SelectScalar(query);
            lblToplamAracSayisi.Text = count.ToString();

            query = "SELECT COUNT(*) FROM Araclar WHERE Durum = 'Müsait'";
            count = (int)SQL.SelectScalar(query);
            lblKullanilabilirArac.Text = count.ToString();

            query = "SELECT COUNT(*) FROM Araclar WHERE Durum = 'Pasif'";
            count = (int)SQL.SelectScalar(query);
            lblKullanilamazArac.Text = count.ToString();

        }

        private void GetTodayReturnCount()
        {
            string query = @"SELECT COUNT(*) FROM Kiralama WHERE BitisTarihi = CAST(GETDATE() AS DATE)";
            int count = (int)SQL.SelectScalar(query);
            lblCarReturn.Text = count.ToString();

            query = @"SELECT COUNT(*) FROM Kiralama WHERE BitisTarihi = CAST(GETDATE() + 1 AS DATE)";
            count = (int)SQL.SelectScalar(query);
            lblCarReturn2.Text = count.ToString();

        }

        private void GetBakim()
        {
            string query = @"SELECT Araclar.AracId, Araclar.Plaka, 
                            ISNULL(CONVERT(varchar, MAX(BakimKayitlari.BakimTarihi), 23), 'Yok') AS SonBakimTarihi,
                            ISNULL(CAST(MAX(BakimKayitlari.Kilometre) AS varchar), 'Yok') AS SonBakimKm, Araclar.Kilometre
                            FROM Araclar
                            LEFT JOIN BakimKayitlari ON Araclar.AracId = BakimKayitlari.AracId
                            GROUP BY Araclar.AracId, Araclar.Plaka, Araclar.Kilometre
                            HAVING 
                            MAX(BakimKayitlari.BakimTarihi) IS NULL
                            OR MAX(BakimKayitlari.Kilometre) IS NULL
                            OR DATEDIFF(DAY, ISNULL(MAX(BakimKayitlari.BakimTarihi), '1900-01-01'), GETDATE()) >= 335
                            OR (Araclar.Kilometre - ISNULL(MAX(BakimKayitlari.Kilometre), 0)) >= 9000";

            DataTable dataTable = new DataTable();
            dataTable = SQL.Select(query);
            dgvBakim.DataSource = dataTable;
            EditDgvBakim();
        }



        private void EditDgvBakim()
        {
            if (dgvBakim.Rows.Count == 0) return;
            dgvBakim.Columns["AracId"].HeaderText = "ID";
            dgvBakim.Columns["Plaka"].HeaderText = "Plaka";
            dgvBakim.Columns["SonBakimTarihi"].HeaderText = "Son Bakım Tarihi";
            dgvBakim.Columns["SonBakimKm"].HeaderText = "Son Bakım Km";
            dgvBakim.Columns["Kilometre"].HeaderText = "Güncel Km";

            dgvBakim.Columns["AracId"].Width = 50;
            dgvBakim.Columns["Plaka"].Width = 100;
            dgvBakim.Columns["SonBakimTarihi"].Width = 125;
            dgvBakim.Columns["SonBakimKm"].Width = 125;
            dgvBakim.Columns["Kilometre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBakim.ColumnHeadersHeight = 35;

        }

        private void LoadDailyRentalsChart()
        {
            DateTime sorguBaslangici = DateTime.Today.AddDays(-29);
            DateTime sorguSonu = DateTime.Today;

            chartDailyRentals.Series[0].Points.Clear(); 

            chartDailyRentals.Series[0].XValueType = ChartValueType.Date;

            
            chartDailyRentals.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MMM";
            chartDailyRentals.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chartDailyRentals.ChartAreas[0].AxisX.Interval = 1;
            chartDailyRentals.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

            chartDailyRentals.ChartAreas[0].AxisY.IsStartedFromZero = true; 
            chartDailyRentals.ChartAreas[0].AxisY.Interval = 1; 
            chartDailyRentals.ChartAreas[0].AxisY.LabelStyle.Format = "0"; 

            string query = @"SELECT COUNT(Kiralama.KiralamaId) 
                 FROM Araclar 
                 LEFT JOIN Kiralama ON Kiralama.AracId = Araclar.AracId 
                 WHERE @Tarih BETWEEN Kiralama.BaslangicTarihi AND Kiralama.BitisTarihi";

            using (SqlConnection connection = new SqlConnection(Constants.SQLPath))
            {
                connection.Open();

                for (DateTime date = sorguBaslangici; date <= sorguSonu; date = date.AddDays(1))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Tarih", date);

                        int count = (int)cmd.ExecuteScalar();

                        
                        chartDailyRentals.Series[0].Points.AddXY(date, count);
                    }
                }
            }
        }


        private void GetSigorta()
        {
            string query = @"SELECT AracId, Plaka, SigortaBitisTarihi, DATEDIFF(day, GETDATE(), SigortaBitisTarihi) AS KalanGun FROM Araclar
                             WHERE DATEDIFF(day, GETDATE(), SigortaBitisTarihi) BETWEEN 0 AND 30 ORDER BY SigortaBitisTarihi ASC";
            DataTable dataTable = new DataTable();
            dataTable = SQL.Select(query);
            dgvSigorta.DataSource = dataTable;
            EditDgvSigorta();
        }

        private void EditDgvSigorta()
        {
   
            dgvSigorta.Columns["AracId"].HeaderText = "ID";
            dgvSigorta.Columns["Plaka"].HeaderText = "Plaka";
            dgvSigorta.Columns["SigortaBitisTarihi"].HeaderText = "Sigorta Bitiş Tarihi";
            dgvSigorta.Columns["KalanGun"].HeaderText = "Kalan Gün";

            dgvSigorta.Columns["AracId"].Width = 50;
            dgvSigorta.Columns["Plaka"].Width = 125;
            dgvSigorta.Columns["SigortaBitisTarihi"].Width = 200;
            dgvSigorta.Columns["KalanGun"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSigorta.ColumnHeadersHeight = 35;
        }

    }
}
