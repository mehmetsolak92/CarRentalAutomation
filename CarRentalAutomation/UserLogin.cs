using CarRentalAutomation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class UserLogin : BaseForm
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        string selectedUserPass = string.Empty;
        private void UserLogin_Load(object sender, EventArgs e)
        {
            cmbUser.DataSource = Constants.Personeller;
            cmbUser.DisplayMember = "AdSoyad";
            cmbUser.ValueMember = "PersonelId";
            cmbUser.SelectedIndex = -1;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Constants.ActiveUser = Constants.Personeller.FirstOrDefault(p => p.PersonelId == Convert.ToInt32(cmbUser.SelectedValue));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedValue != null && int.TryParse(cmbUser.SelectedValue.ToString(), out int personelId))
            {
                var selectedUser = Constants.Personeller.FirstOrDefault(p => p.PersonelId == personelId);
                if (selectedUser != null)
                {
                    selectedUserPass = selectedUser.Sifre;
                }
            }
            else
            {
                selectedUserPass = string.Empty;
            }
        }


        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (Methods.ComputeSha256Hash(txtPass.Text) != selectedUserPass)
            {
                errorProvider1.SetError(txtPass, "Şifre yanlış girildi!");
                isValid = false;
            }
            if (cmbUser.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbUser, "Kullanıcı seçilmedi!");
                isValid = false;
            }
            return isValid;
        }
    }
}
