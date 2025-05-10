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
    public partial class Customers : BaseForm
    {
        public Customers()
        {
            InitializeComponent();
        }

        int oldSelectedIndex = 0;


        private void Customers_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            GetCustomersData();
        }

        private void GetCustomersData()
        {
            string query = "SELECT * FROM Kullanicilar";
            DataTable dataTable = SQL.Select(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                dgvCustomers.DataSource = dataTable;
            }
            EditDgvCustomers();
        }

        private void EditDgvCustomers()
        {
            if (dgvCustomers.Rows.Count == 0) return;
            dgvCustomers.Columns["KullaniciId"].HeaderText = "ID";
            dgvCustomers.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dgvCustomers.Columns["Telefon"].HeaderText = "Telefon";
            dgvCustomers.Columns["Email"].HeaderText = "Mail";
            dgvCustomers.Columns["TcNo"].HeaderText = "TC Kimlik No";
            dgvCustomers.Columns["EhliyetNo"].HeaderText = "Ehliyet No";
            dgvCustomers.Columns["EhliyetTarihi"].HeaderText = "Ehliyet Geçerlilik Tarihi";
            dgvCustomers.Columns["EhliyetSinifi"].HeaderText = "Ehliyet Sınıfı";

            dgvCustomers.Columns["KullaniciId"].Width = 50;
            dgvCustomers.Columns["AdSoyad"].Width = 150;
            dgvCustomers.Columns["Telefon"].Width = 150;
            dgvCustomers.Columns["Email"].Width = 250;
            dgvCustomers.Columns["TcNo"].Width = 150;
            dgvCustomers.Columns["EhliyetNo"].Width = 150;
            dgvCustomers.Columns["EhliyetTarihi"].Width = 150;
            dgvCustomers.Columns["EhliyetSinifi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            if (oldSelectedIndex > dgvCustomers.Rows.Count - 1)
            {
                oldSelectedIndex = dgvCustomers.Rows.Count - 1;
            }
            dgvCustomers.Rows[oldSelectedIndex].Selected = true;

            dgvCustomers.ColumnHeadersHeight = 35;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = new CustomersAddEdit(0).ShowDialog();

            if (result == DialogResult.OK)
            {
                GetCustomersData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            int kullaniciId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["KullaniciId"].Value);
            oldSelectedIndex = dgvCustomers.CurrentRow.Index;
            DialogResult result = new CustomersAddEdit(kullaniciId).ShowDialog();

            if (result == DialogResult.OK)
            {
                GetCustomersData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Silme işlemi için önce kullanıcı seçmelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kullaniciId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["KullaniciId"].Value);
            oldSelectedIndex = dgvCustomers.CurrentRow.Index;
            string msgStr = "Kullanıcı silinecek. Emin misiniz?";
            DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (SQL.Delete("Kullanicilar", "KullaniciId", kullaniciId) >= 1)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinirken hata oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                GetCustomersData();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            Data.ExportToExcel(dgvCustomers, "Kullanıcılar");
        }
    }
}
