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
    public partial class SettingsUsersChangePassword : BaseForm
    {
        int personelId = 0;
        string oldPassword = "";

        public SettingsUsersChangePassword(int _personelId)
        {
            InitializeComponent();
            personelId = _personelId;
        }


        private void SettingsUsersChangePassword_Load(object sender, EventArgs e)
        {
            Personel personel = Constants.Personeller.FirstOrDefault(p => p.PersonelId == personelId);
            oldPassword = personel.Sifre;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string msgStr = string.Empty;
                msgStr = "Şifre değiştirilecek. Emin misiniz?";
                DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    ChangePassword();

                    if (this.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (Methods.ComputeSha256Hash(txtOldPassword.Text) != oldPassword)
            {
                errorProvider1.SetError(txtOldPassword, "Şifre yanlış girildi!");
                isValid = false;
            }

            if (Methods.ComputeSha256Hash(txtNewPassword.Text) == oldPassword)
            {
                errorProvider1.SetError(txtOldPassword, "Yeni şifre eskisiyle aynı olamaz!");
                isValid = false;
            }

            if (txtNewPassword.Text != txtNewPasswordR.Text)
            {
                errorProvider1.SetError(txtNewPasswordR, "Şifreler uyuşmuyor!");
                isValid = false;
            }

            if (!Methods.IsPasswordStrong(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "Parola en az 4 karakter ve en az 1 harf 1 sayı içermelidir!");
                isValid = false;
            }

            return isValid;
        }

        private void ChangePassword()
        {
            string newPassword = Methods.ComputeSha256Hash(txtNewPassword.Text);

            try
            {
                string query = $"UPDATE Personeller SET Sifre = '{newPassword}'  WHERE PersonelId = {personelId}";

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


        private void SettingsUsersChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
