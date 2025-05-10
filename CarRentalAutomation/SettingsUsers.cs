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

namespace CarRentalAutomation
{
    public partial class SettingsUsers : BaseForm
    {
        public SettingsUsers()
        {
            InitializeComponent();
        }

        private void SettingsUsers_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            GetStaffsData();
        }

        private void GetStaffsData()
        {
            string query = "SELECT PersonelId,AdSoyad,TcNo,Telefon,Email,Gorev FROM Personeller";
            DataTable dataTable = SQL.Select(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                dgvStaffs.DataSource = dataTable;
            }
            EditDgvStaffs();
        }

        private void EditDgvStaffs()
        {
            if (dgvStaffs.Rows.Count == 0) return;
            dgvStaffs.Columns["PersonelId"].HeaderText = "ID";
            dgvStaffs.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dgvStaffs.Columns["Telefon"].HeaderText = "Telefon";
            dgvStaffs.Columns["Email"].HeaderText = "Mail";
            dgvStaffs.Columns["TcNo"].HeaderText = "TC Kimlik No";
            dgvStaffs.Columns["Gorev"].HeaderText = "Görev";

            dgvStaffs.Columns["PersonelId"].Width = 50;
            dgvStaffs.Columns["AdSoyad"].Width = 150;
            dgvStaffs.Columns["Telefon"].Width = 150;
            dgvStaffs.Columns["Email"].Width = 250;
            dgvStaffs.Columns["TcNo"].Width = 150;
            dgvStaffs.Columns["Gorev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvStaffs.ColumnHeadersHeight = 35;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Constants.ActiveUser.Gorev != "Yönetici")
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için yönetici yetkisine sahip olmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = new SettingsUsersAddEdit(0).ShowDialog();

            if (result == DialogResult.OK)
            {
                GetStaffsData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Constants.ActiveUser.Gorev != "Yönetici")
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için yönetici yetkisine sahip olmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvStaffs.CurrentRow == null) return;
            int personelId = Convert.ToInt32(dgvStaffs.CurrentRow.Cells["PersonelId"].Value);
            DialogResult result = new SettingsUsersAddEdit(personelId).ShowDialog();

            if (result == DialogResult.OK)
            {
                GetStaffsData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Constants.ActiveUser.Gorev != "Yönetici")
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için yönetici yetkisine sahip olmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvStaffs.CurrentRow == null)
            {
                MessageBox.Show("Silme işlemi için önce personel seçmelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int personelId = Convert.ToInt32(dgvStaffs.CurrentRow.Cells["PersonelId"].Value);
            string msgStr = "Personel silinecek. Emin misiniz?";
            DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (SQL.Delete("Personeller", "PersonelId", personelId) >= 1)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinirken hata oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GetStaffsData();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.CurrentRow == null) return;
            int personelId = Convert.ToInt32(dgvStaffs.CurrentRow.Cells["PersonelId"].Value);
            if (Constants.ActiveUser.Gorev == "Yönetici" || Constants.ActiveUser.PersonelId == personelId)
            {
                
                DialogResult result = new SettingsUsersChangePassword(personelId).ShowDialog();

                if (result == DialogResult.OK)
                {
                    GetStaffsData();
                }
            }
            else
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için yetkiniz yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                
        }
    }
}
