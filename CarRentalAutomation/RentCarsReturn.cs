using CarRentalAutomation.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class RentCarsReturn : BaseForm
    {
        int kiralamaId = 0;
        public RentCarsReturn(int _kiralamaId)
        {
            InitializeComponent();
            kiralamaId = _kiralamaId;
        }

        int toplamTutar = 0;
        int odenenTutar = 0;
        private void RentCarsReturn_Load(object sender, EventArgs e)
        {
            rbNakit.Checked = true;
            lblKalanTutar.Text = CalculateRemainingPrice().ToString() + " TL";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (UserLogin loginForm = new UserLogin())
            {
                loginForm.DialogResult = DialogResult.Cancel;

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    InsertCarReturnToDb();
                    UpdateRentalStatus();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
           
        }

        private int CalculateRemainingPrice()
        {
            try
            {
                string query = $"SELECT ToplamTutar FROM Kiralama WHERE KiralamaId = {kiralamaId}";
                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        toplamTutar = Convert.ToInt32(result);
                    }
                }
                query = $"SELECT SUM(OdemeTutari) FROM OdemeDetaylari WHERE KiralamaId = {kiralamaId}";
                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        odenenTutar = Convert.ToInt32(result);
                    }
                }

                int kalanTutar = toplamTutar - odenenTutar;
                if (kalanTutar < 0)
                {
                    kalanTutar = 0;
                }

                if (kalanTutar == 0)
                {
                    btnSave.Enabled = true;
                }
                return kalanTutar;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);
                return 0;
            }
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    string query = $"INSERT INTO OdemeDetaylari (KiralamaId, OdemeTarihi, OdemeTutari, OdemeSekli, OdemeTuru) VALUES ({kiralamaId},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}', {txtOdenenTutar.Text.Replace(",", ".")}, '{(rbNakit.Checked ? "Nakit" : "Kredi Kartı")}', 'Gelir')";
                    using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        lblKalanTutar.Text = CalculateRemainingPrice().ToString() + " TL";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                    Methods.WriteLog(trace, ex);
                }
            }
        }

        private void txtOdenenTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtOdenenTutar.Text) || Convert.ToInt32(txtOdenenTutar.Text) <= 0)
            {
                errorProvider1.SetError(txtOdenenTutar, "Ödeme Tutarı Giriniz!");
                isValid = false;
            }

            if (Convert.ToInt32(txtOdenenTutar.Text) > CalculateRemainingPrice())
            {
                errorProvider1.SetError(txtOdenenTutar, "Ödeme Tutarı Kalan Tutarı Aşamaz!");
                isValid = false;
            }
           


            return isValid;
        }

        private void InsertCarReturnToDb()
        {
            try
            {
                string query = $"INSERT INTO AracTeslimKayitlari (KiralamaId, TeslimAlanPersonelId, TeslimTarihi, TeslimNotu) VALUES ({kiralamaId}, {Constants.ActiveUser.PersonelId},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}', '{txtTeslimNotu.Text}')";
                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);

            }
        }

        private void UpdateRentalStatus()
        {
            try
            {
                string query = $"UPDATE Kiralama SET Durum = 'Tamamlandı' WHERE KiralamaId = {kiralamaId}";
                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
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
