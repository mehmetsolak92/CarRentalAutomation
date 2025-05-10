using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalAutomation.Class;
using Microsoft.Data.SqlClient;

namespace CarRentalAutomation
{
    public partial class Finance : BaseForm
    {
        public Finance()
        {
            InitializeComponent();
        }

        decimal toplamGelir = 0;
        decimal toplamGider = 0;
        private void Finance_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            dtpStartDate.Value = DateTime.Now.Date.AddDays(-7);
            dtpEndDate.Value = DateTime.Now.Date.AddDays(7);
            ReadPayments();
            CalculatePayments();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            FinanceOutgoing financeOutgoing = new FinanceOutgoing();
            financeOutgoing.DialogResult = DialogResult.Cancel;
            DialogResult result = financeOutgoing.ShowDialog();

            if (result == DialogResult.OK)
            {
                ReadPayments();
            }
        }

        private void ReadPayments()
        {
            DataTable dataTable = new DataTable();

            string query = $"SELECT OdemeDetaylari.OdemeId, OdemeDetaylari.OdemeTuru, Kullanicilar.AdSoyad, OdemeDetaylari.OdemeTarihi, OdemeDetaylari.OdemeTutari, OdemeDetaylari.OdemeSekli, OdemeDetaylari.Aciklama FROM OdemeDetaylari " +
                $"LEFT JOIN Kiralama ON OdemeDetaylari.KiralamaId = Kiralama.KiralamaId " +
                $"LEFT JOIN Kullanicilar ON Kiralama.KullaniciId = Kullanicilar.KullaniciId " +
                $"WHERE OdemeDetaylari.OdemeTarihi >= '{dtpStartDate.Value.Date.ToString("yyyy-MM-dd")}' AND OdemeDetaylari.OdemeTarihi <= '{dtpEndDate.Value.Date.ToString("yyyy-MM-dd")}'";
            dataTable = SQL.Select(query);
            dgvPayments.DataSource = dataTable;
            EditDgvPayments();
        }

        private void EditDgvPayments()
        {
            dgvPayments.Columns["OdemeId"].HeaderText = "ID";
            dgvPayments.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dgvPayments.Columns["OdemeTarihi"].HeaderText = "Ödeme Tarihi";
            dgvPayments.Columns["OdemeTutari"].HeaderText = "Ödeme Tutarı";
            dgvPayments.Columns["OdemeSekli"].HeaderText = "Ödeme Şekli";
            dgvPayments.Columns["Aciklama"].HeaderText = "Açıklama";
            dgvPayments.Columns["OdemeTuru"].HeaderText = "Gelir-Gider";

            dgvPayments.Columns["OdemeId"].Width = 50;
            dgvPayments.Columns["AdSoyad"].Width = 120;
            dgvPayments.Columns["OdemeTarihi"].Width = 120;
            dgvPayments.Columns["OdemeTutari"].Width = 120;
            dgvPayments.Columns["OdemeSekli"].Width = 120;
            dgvPayments.Columns["Aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPayments.Columns["OdemeTuru"].Width = 120;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ReadPayments();
            CalculatePayments();
        }

        private void CalculatePayments()
        {
            try
            {
                string query = $"SELECT SUM(OdemeTutari) FROM OdemeDetaylari WHERE OdemeTuru = 'Gelir' " +
                    $"AND OdemeDetaylari.OdemeTarihi >= '{dtpStartDate.Value.Date.ToString("yyyy-MM-dd")}' AND OdemeDetaylari.OdemeTarihi <= '{dtpEndDate.Value.Date.ToString("yyyy-MM-dd")}'";
                using (SqlConnection conn = new SqlConnection(Constants.SQLPath))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value) toplamGelir = Convert.ToDecimal(result); else toplamGelir = 0;
                    }
                }

                query = $"SELECT SUM(OdemeTutari) FROM OdemeDetaylari WHERE OdemeTuru = 'Gider' " +
                    $"AND OdemeDetaylari.OdemeTarihi >= '{dtpStartDate.Value.Date.ToString("yyyy-MM-dd")}' AND OdemeDetaylari.OdemeTarihi <= '{dtpEndDate.Value.Date.ToString("yyyy-MM-dd")}'";
                using (SqlConnection conn = new SqlConnection(Constants.SQLPath))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value) toplamGider = Convert.ToDecimal(result); else toplamGider = 0;
                    }
                }

                lblGelenOdeme.Text = toplamGelir.ToString() + " TL";
                lblGidenOdeme.Text = toplamGider.ToString() + " TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);
            }
        }
    }
}
