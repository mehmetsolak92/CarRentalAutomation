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
    public partial class SettingsUsersAddEdit : BaseForm
    {
        int personelId = 0;

        public SettingsUsersAddEdit(int _personelId)
        {
            InitializeComponent();
            personelId = _personelId;
        }

        private void SettingsUsersAddEdit_Load(object sender, EventArgs e)
        {
            cmbGorev.DataSource = Constants.Gorevler;

            if (personelId > 0)
            {
                this.Text = "PERSONEL GÜNCELLE";
                this.Size = new Size(this.Width, this.Height - 88);
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y - 88);
                btnCancel.Location = new Point(btnCancel.Location.X, btnCancel.Location.Y - 88);
                lblPassword.Visible = false;
                lblPasswordR.Visible = false;
                txtPassword.Visible = false;
                txtPasswordR.Visible = false;

                ReadSStaffData(personelId);
            }
            else
            {
                this.Text = "YENİ PERSONEL EKLE";
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
            if (!Methods.TelefonDogrula(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, "Geçerli bir telefon numarası giriniz!");
                isValid = false;
            }
            if (!Methods.EmailDogrula(txtMail.Text))
            {
                errorProvider1.SetError(txtMail, "Geçerli bir mail adresi giriniz!");
                isValid = false;
            }

            if (!Methods.TcDogrula(txtTcKimlikNo.Text))
            {
                errorProvider1.SetError(txtTcKimlikNo, "Geçerli bir TC Kimlik No giriniz!");
                isValid = false;
            }

            if (cmbGorev.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbGorev, "Personelin görevini seçiniz!");
                isValid = false;
            }

            if (personelId == 0)
            {
                if (!Methods.IsPasswordStrong(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Parola en az 4 karakter ve en az 1 harf 1 sayı içermelidir!");
                    isValid = false;
                }

                if (txtPassword.Text != txtPasswordR.Text)
                {
                    errorProvider1.SetError(txtPasswordR, "Şifre tekrarı parola ile uyuşmuyor!");
                    isValid = false;
                }
            }
           

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string msgStr = string.Empty;
                if (personelId == 0) msgStr = "Yeni personel eklenecek. Emin misiniz?"; else msgStr = "Personel güncellenecek. Emin misiniz?";
                DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (personelId == 0) InsertStaffToDB(); else UpdateStaffData();

                    if (this.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void InsertStaffToDB()
        {
            try
            {
                string query = $"INSERT INTO Personeller (AdSoyad, Sifre, Gorev, Telefon, Email, TcNo) " +
                    $"VALUES ('{txtAdSoyad.Text}', '{Methods.ComputeSha256Hash(txtPassword.Text)}', '{cmbGorev.Text}', {txtTelefon.Text}, '{txtMail.Text}', '{txtTcKimlikNo.Text}')";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Data.GetStaffsData();
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

        private void UpdateStaffData()
        {

            try
            {
                string query = $"UPDATE Personeller SET AdSoyad = '{txtAdSoyad.Text}', Telefon = '{txtTelefon.Text}', Email = '{txtMail.Text}'" +
                $", TcNo = '{txtTcKimlikNo.Text}', Gorev = '{cmbGorev.Text}' WHERE PersonelId = {personelId}";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Data.GetStaffsData();
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

        void ReadSStaffData(int ID)
        {
            try
            {
                string query = $"SELECT * FROM Personeller WHERE PersonelId = {ID}";

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
                            cmbGorev.Text = Convert.ToString(reader["Gorev"]);

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

        

       
    }
}
