using CarRentalAutomation.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class CustomersAddEdit : BaseForm
    {
        int musteriId = 0;

        public CustomersAddEdit(int _musteriId)
        {
            InitializeComponent();
            musteriId = _musteriId;
        }



        private void CustomersAddEdit_Load(object sender, EventArgs e)
        {
            cmbEhliyetSinif.DataSource = Constants.EhliyetSinifi;

            if (musteriId != 0)
            {
                ReadCustomerData(musteriId);
                this.Text = "KULLANICI GÜNCELLE";
            }
        }
        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                errorProvider1.SetError(txtAdSoyad, "Ad soyad boş bırakılamaz!");
                isValid = false;
            }
            if (!TelefonDogrula(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, "Geçerli bir telefon numarası giriniz!");
                isValid = false;
            }
            if (!EmailDogrula(txtMail.Text))
            {
                errorProvider1.SetError(txtMail, "Geçerli bir mail adresi giriniz!");
                isValid = false;
            }

            if (!TcDogrula(txtTcKimlikNo.Text))
            {
                errorProvider1.SetError(txtTcKimlikNo, "Geçerli bir TC Kimlik No giriniz!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtEhliyetNo.Text))
            {
                errorProvider1.SetError(txtEhliyetNo, "Vites tipi seçiniz!");
                isValid = false;
            }

            if (cmbEhliyetSinif.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbEhliyetSinif, "Yakıt tipi seçiniz!");
                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string msgStr = string.Empty;
                if (musteriId == 0) msgStr = "Yeni kullanıcı eklenecek. Emin misiniz?"; else msgStr = "Kullanıcı güncellenecek. Emin misiniz?";
                DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (musteriId == 0) InsertCustomerToDB(); else UpdateCustomerData();

                    if (this.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void InsertCustomerToDB()
        {
            try
            {
                string query = $"INSERT INTO Kullanicilar (AdSoyad, Telefon, Email, TcNo, EhliyetNo, EhliyetTarihi, EhliyetSinifi) " +
                    $"VALUES ('{txtAdSoyad.Text}', '{txtTelefon.Text}', '{txtMail.Text}', {txtTcKimlikNo.Text}, '{txtEhliyetNo.Text}', '{dtpEhliyetTarih.Value.Date.ToString("yyyy-MM-dd")}', '{cmbEhliyetSinif.Text}')";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Data.GetCustomersData();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustomerData()
        {

            try
            {
                string query = $"UPDATE Kullanicilar SET AdSoyad = '{txtAdSoyad.Text}', Telefon = '{txtTelefon.Text}', Email = '{txtMail.Text}'" +
                $", TcNo = {txtTcKimlikNo.Text}, EhliyetNo = '{txtEhliyetNo.Text}', EhliyetTarihi = '{dtpEhliyetTarih.Value.Date.ToString("yyyy-MM-dd")}'" +
                $", EhliyetSinifi = '{cmbEhliyetSinif.Text}' WHERE KullaniciId = {musteriId}";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Data.GetCustomersData();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void ReadCustomerData(int ID)
        {
            try
            {
                string query = $"SELECT * FROM Kullanicilar WHERE KullaniciId = {ID}";

                using SqlConnection con = new SqlConnection(Constants.SQLPath);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtAdSoyad.Text = Convert.ToString(reader["AdSoyad"]);
                            txtTelefon.Text = Convert.ToString(reader["Telefon"]);
                            txtMail.Text = Convert.ToString(reader["Email"]);
                            txtTcKimlikNo.Text = Convert.ToString(reader["TcNo"]);
                            txtEhliyetNo.Text = Convert.ToString(reader["EhliyetNo"]);
                            dtpEhliyetTarih.Value = Convert.ToDateTime(reader["EhliyetTarihi"]);
                            cmbEhliyetSinif.Text = Convert.ToString(reader["EhliyetSinifi"]);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CarsAddEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        public bool TcDogrula(string tc)
        {
            if (tc.Length != 11 || !long.TryParse(tc, out _) || tc[0] == '0')
                return false;

            int[] digits = tc.Select(c => int.Parse(c.ToString())).ToArray();

            int oddSum = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
            int evenSum = digits[1] + digits[3] + digits[5] + digits[7];

            int digit10 = ((oddSum * 7) - evenSum) % 10;
            int digit11 = digits.Take(10).Sum() % 10;

            return (digit10 == digits[9]) && (digit11 == digits[10]);
        }

        public bool EmailDogrula(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public bool TelefonDogrula(string telefon)
        {
            if (telefon.Length != 11)
                return false;

            if (!long.TryParse(telefon, out _))
                return false;

            if (!telefon.StartsWith("05"))
                return false;

            return true;
        }

        
    }
}
