﻿using System;
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
    public partial class RentActiveList : BaseForm
    {
        public RentActiveList()
        {
            InitializeComponent();
        }

        public MainForm AnaForm { get; set; }
        string Durum = string.Empty;
        private void RentActiveList_Load(object sender, EventArgs e)
        {
            checkAktif.Checked = true;
            Durum = "Aktif";
            dtpRentStart.Value = DateTime.Now.Date.AddDays(-7);
            dtpRentEnd.Value = DateTime.Now.Date.AddDays(7);
            ReadActiveRentals();
        }

        private void ReadActiveRentals()
        {
            DataTable dataTable = new DataTable();

            string query = $"SELECT Kiralama.KiralamaId, Kiralama.AracId, Araclar.Plaka, Kiralama.KullaniciId, Kullanicilar.AdSoyad, Kiralama.BaslangicTarihi, Kiralama.BitisTarihi, Kiralama.ToplamTutar, Kiralama.Aciklama, Kiralama.Durum " +
                $"FROM Kiralama " +
                $"INNER JOIN Araclar ON Kiralama.AracId = Araclar.AracId " +
                $"INNER JOIN Kullanicilar ON Kiralama.KullaniciId = Kullanicilar.KullaniciId " +
                $"WHERE Kiralama.BaslangicTarihi >= '{dtpRentStart.Value.Date.ToString("yyyy-MM-dd")}' AND Kiralama.BitisTarihi <= '{dtpRentEnd.Value.Date.ToString("yyyy-MM-dd")}'";

            if (checkAktif.Checked && !checkTamamlandi.Checked)
            {
                query += " AND Kiralama.Durum = 'Aktif'";
            }
            else if (!checkAktif.Checked && checkTamamlandi.Checked)
            {
                query += " AND Kiralama.Durum = 'Tamamlandı'";
            }

            dataTable = SQL.Select(query);
            dgvActiveRents.DataSource = dataTable;
            EditDgvActiveRents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Rent rentPage = new Rent();
            rentPage.AnaForm = this.AnaForm;
            Methods.showFormInPanel(AnaForm.pnlScreens, rentPage);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ReadActiveRentals();
        }

        private void EditDgvActiveRents()
        {
            if (dgvActiveRents.Rows.Count == 0) return;
            dgvActiveRents.Columns["KiralamaId"].HeaderText = "ID";
            dgvActiveRents.Columns["Plaka"].HeaderText = "Plaka";
            dgvActiveRents.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dgvActiveRents.Columns["BaslangicTarihi"].HeaderText = "Başlangıç Tarihi";
            dgvActiveRents.Columns["BitisTarihi"].HeaderText = "Bitiş Tarihi";
            dgvActiveRents.Columns["ToplamTutar"].HeaderText = "Vites Tipi";
            dgvActiveRents.Columns["Aciklama"].HeaderText = "Açıklama";
            dgvActiveRents.Columns["Durum"].HeaderText = "Durum";

            dgvActiveRents.Columns["KiralamaId"].Width = 50;
            dgvActiveRents.Columns["Plaka"].Width = 120;
            dgvActiveRents.Columns["AdSoyad"].Width = 120;
            dgvActiveRents.Columns["BaslangicTarihi"].Width = 120;
            dgvActiveRents.Columns["BitisTarihi"].Width = 120;
            dgvActiveRents.Columns["ToplamTutar"].Width = 100;
            dgvActiveRents.Columns["Aciklama"].Width = 250;
            dgvActiveRents.Columns["Durum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActiveRents.Columns["AracId"].Visible = false;
            dgvActiveRents.Columns["KullaniciId"].Visible = false;

            dgvActiveRents.ColumnHeadersHeight = 35;
        }

        private void dgvActiveRents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActiveRents.CurrentRow.Index < 0) return;
            int selectedKullaniciId = Convert.ToInt32(dgvActiveRents.CurrentRow.Cells["KullaniciId"].Value);
            int selectedAracId = Convert.ToInt32(dgvActiveRents.CurrentRow.Cells["AracId"].Value);

            lblAdSoyad.Text = Constants.Kullanicilar.Where(x => x.KullaniciId == selectedKullaniciId).Select(x => x.AdSoyad).FirstOrDefault();
            lblMail.Text = Constants.Kullanicilar.Where(x => x.KullaniciId == selectedKullaniciId).Select(x => x.Mail).FirstOrDefault();
            lblTelefon.Text = Constants.Kullanicilar.Where(x => x.KullaniciId == selectedKullaniciId).Select(x => x.Telefon).FirstOrDefault();

            lblPlaka.Text = Constants.Araclar.Where(x => x.AracId == selectedAracId).Select(x => x.Plaka).FirstOrDefault();
            lblMarka.Text = Constants.Araclar.Where(x => x.AracId == selectedAracId).Select(x => x.Marka).FirstOrDefault();
            lblModel.Text = Constants.Araclar.Where(x => x.AracId == selectedAracId).Select(x => x.Model).FirstOrDefault();
            lblYil.Text = Constants.Araclar.Where(x => x.AracId == selectedAracId).Select(x => x.Yil).FirstOrDefault().ToString();
            lblRenk.Text = Constants.Araclar.Where(x => x.AracId == selectedAracId).Select(x => x.Renk).FirstOrDefault();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvActiveRents.CurrentRow.Index < 0) return;
            if (dgvActiveRents.CurrentRow.Cells["Durum"].Value.ToString() == "Tamamlandı")
            {
                MessageBox.Show("Bu kiralama işlemi tamamlanmış. İptal edilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bu kiralamayı iptal etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int selectedKiralamaId = Convert.ToInt32(dgvActiveRents.CurrentRow.Cells["KiralamaId"].Value);
                SQL.Delete("Kiralama", "KiralamaId", selectedKiralamaId);
            }
           
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dgvActiveRents.CurrentRow.Index < 0) return;
            if (dgvActiveRents.CurrentRow.Cells["Durum"].Value.ToString() == "Tamamlandı")
            {
                MessageBox.Show("Bu kiralama işlemi tamamlanmış. Teslim Alınamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedKiralamaId = Convert.ToInt32(dgvActiveRents.CurrentRow.Cells["KiralamaId"].Value);
            DialogResult result = new RentCarsReturn(selectedKiralamaId).ShowDialog();

            if (result == DialogResult.OK)
            {
                ReadActiveRentals();
            }

        }


      
    }
}
