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
    public partial class CarsList : BaseForm
    {
        public CarsList()
        {
            InitializeComponent();
        }

        int oldSelectedIndex = 0;
        private void CarsList_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
            GetCarsData();

        }

        private void GetCarsData()
        {
            string query = "SELECT * FROM Araclar";
            DataTable dataTable = SQL.Select(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                dgvCars.DataSource = dataTable;
            }
            EditDgvCars();

        }

        private void EditDgvCars()
        {
            if (dgvCars.Rows.Count == 0) return;
            dgvCars.Columns["AracId"].HeaderText = "ID";
            dgvCars.Columns["Plaka"].HeaderText = "Plaka";
            dgvCars.Columns["Marka"].HeaderText = "Marka";
            dgvCars.Columns["Model"].HeaderText = "Model";
            dgvCars.Columns["Yil"].HeaderText = "Yil";
            dgvCars.Columns["VitesTipi"].HeaderText = "Vites Tipi";
            dgvCars.Columns["YakitTipi"].HeaderText = "Yakıt Tipi";
            dgvCars.Columns["Renk"].HeaderText = "Renk";
            dgvCars.Columns["Kilometre"].HeaderText = "Kilometre";
            dgvCars.Columns["GunlukKiraUcreti"].HeaderText = "Günlük Ücret";
            dgvCars.Columns["Durum"].HeaderText = "Durum";
            dgvCars.Columns["SigortaBitisTarihi"].HeaderText = "Sigorta Bitiş Tarihi";

            dgvCars.Columns["AracId"].Width = 50;
            dgvCars.Columns["Plaka"].Width = 100;
            dgvCars.Columns["Marka"].Width = 100;
            dgvCars.Columns["Model"].Width = 100;
            dgvCars.Columns["Yil"].Width = 50;
            dgvCars.Columns["VitesTipi"].Width = 100;
            dgvCars.Columns["YakitTipi"].Width = 100;
            dgvCars.Columns["Renk"].Width = 100;
            dgvCars.Columns["Kilometre"].Width = 100;
            dgvCars.Columns["GunlukKiraUcreti"].Width = 100;
            dgvCars.Columns["Durum"].Width = 100;
            dgvCars.Columns["SigortaBitisTarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (oldSelectedIndex > dgvCars.Rows.Count - 1)
            {
                oldSelectedIndex = dgvCars.Rows.Count - 1;
            }
            dgvCars.Rows[oldSelectedIndex].Selected = true;

            dgvCars.ColumnHeadersHeight = 35;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = new CarsAddEdit(0).ShowDialog();

            if (result == DialogResult.OK)
            {
                GetCarsData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null) return;
            int aracId = Convert.ToInt32(dgvCars.CurrentRow.Cells["AracId"].Value);
            oldSelectedIndex = dgvCars.CurrentRow.Index;
            DialogResult result = new CarsAddEdit(aracId).ShowDialog();

            if (result == DialogResult.OK)
            {
                GetCarsData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show("Silme işlemi için önce araç seçmelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int aracId = Convert.ToInt32(dgvCars.CurrentRow.Cells["AracId"].Value);
            oldSelectedIndex = dgvCars.CurrentRow.Index;
            string msgStr = "Araç silinecek. Emin misiniz?";
            DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (SQL.Delete("Araclar", "AracId", aracId) >= 1)
                {
                    MessageBox.Show("Araç başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Araç silinirken hata oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                GetCarsData();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            Data.ExportToExcel(dgvCars, "Araçlar");
        }
    }
}
