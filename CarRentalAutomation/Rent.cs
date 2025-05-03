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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CarRentalAutomation
{
    public partial class Rent : BaseForm
    {
        public Rent()
        {
            InitializeComponent();
        }

        bool isNotFirstRun = false;
        decimal toplamTutar = 0;
        private void Rent_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);

            cmbVites.DataSource = Constants.VitesTipi;
            cmbYakit.DataSource = Constants.YakitTipi;

            cmbKullanici.DataSource = Constants.Kullanicilar;
            cmbKullanici.DisplayMember = "AdSoyad";
            cmbKullanici.ValueMember = "KullaniciId";
            cmbKullanici.SelectedIndex = 0;

            dtpRentStart.Value = DateTime.Now.Date;
            dtpRentEnd.Value = DateTime.Now.Date.AddDays(1);

            CalculateRentTime();

        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {

            SearchAvailableCar();
            isNotFirstRun = true;
        }

        private int CalculateRentTime()
        {
            int kiralamaSuresi = Convert.ToInt32(dtpRentEnd.Value.Date.Subtract(dtpRentStart.Value.Date).TotalDays);
            lblKiralamaSüresi.Text = kiralamaSuresi.ToString() + " Gün";
            return kiralamaSuresi;

        }

        private void SearchAvailableCar()
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT Araclar.AracId, Araclar.Plaka, Araclar.Marka, Araclar.Model, Araclar.Yil, Araclar.VitesTipi, Araclar.YakitTipi, Araclar.Renk," +
                $"Araclar.Kilometre, Araclar.GunlukKiraUcreti " +
                $"FROM Araclar WHERE Araclar.AracId NOT IN" +
                $" (SELECT Kiralama.AracId FROM Kiralama  " +
                $"WHERE ('{dtpRentEnd.Value.Date.ToString("yyyy-MM-dd")}' <= Kiralama.BitisTarihi AND" +
                $" '{dtpRentStart.Value.Date.ToString("yyyy-MM-dd")}' >= Kiralama.BaslangicTarihi))";


            if (cmbVites.SelectedIndex > 0)
            {
                query += $" AND Araclar.VitesTipi = '{cmbVites.SelectedItem.ToString()}'";
            }

            if (cmbYakit.SelectedIndex > 0)
            {
                query += $" AND Araclar.YakitTipi = '{cmbYakit.SelectedItem.ToString()}'";
            }

            using (SqlConnection connectiom = new SqlConnection(Constants.SQLPath))
            {
                try
                {
                    connectiom.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectiom))
                    {
                        adapter.Fill(dataTable);
                    }
                    dgvCars.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                    Methods.WriteLog(trace, ex);

                }
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


            dgvCars.Columns["AracId"].Width = 50;
            dgvCars.Columns["Plaka"].Width = 100;
            dgvCars.Columns["Marka"].Width = 100;
            dgvCars.Columns["Model"].Width = 100;
            dgvCars.Columns["Yil"].Width = 50;
            dgvCars.Columns["VitesTipi"].Width = 100;
            dgvCars.Columns["YakitTipi"].Width = 100;
            dgvCars.Columns["Renk"].Width = 100;
            dgvCars.Columns["Kilometre"].Width = 100;
            dgvCars.Columns["GunlukKiraUcreti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCars.ColumnHeadersHeight = 35;
        }

        private void dtpRentStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRentStart.Value.Date > dtpRentEnd.Value.Date)
            {
                dtpRentEnd.Value = dtpRentStart.Value.AddDays(1);
            }

            CalculateRentTime();

            if (isNotFirstRun)
            {
                CalculateTotalPrice();
            }
        }

        private void dtpRentEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRentStart.Value.Date > dtpRentEnd.Value.Date)
            {
                dtpRentEnd.Value = dtpRentStart.Value.AddDays(1);
            }

            CalculateRentTime();

            if (isNotFirstRun)
            {
                CalculateTotalPrice();
            }
        }

        private void cmbVites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYakit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedIndex > 0)
            {
                lblMail.Text = ((Kullanici)cmbKullanici.SelectedItem).Mail.ToString();
                lblTelefon.Text = ((Kullanici)cmbKullanici.SelectedItem).Telefon.ToString();
                lblTc.Text = ((Kullanici)cmbKullanici.SelectedItem).TcNo.ToString();
                lblEhliyetNo.Text = ((Kullanici)cmbKullanici.SelectedItem).EhliyetNo.ToString();
                lblEhliyetTarih.Text = ((Kullanici)cmbKullanici.SelectedItem).EhliyetTarihi.ToString("dd.MM.yyyy");
                lblEhliyetSinif.Text = ((Kullanici)cmbKullanici.SelectedItem).EhliyetSinifi.ToString();
            }

        }

        private void dgvCars_SelectionChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            if (dgvCars.CurrentRow.Index < 0) return;
            int kiralamaSuresi = CalculateRentTime();
            toplamTutar = Convert.ToDecimal(dgvCars.CurrentRow.Cells["GunlukKiraUcreti"].Value) * kiralamaSuresi;
            lblTotalPrice.Text = toplamTutar.ToString() + " TL";
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string msgStr = string.Empty;
                msgStr = "Kiralama oluşturulacak. Emin misiniz?";
                DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    InsertRentToDB();
                }
            }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;
            if (cmbKullanici.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbKullanici, "Lütfen bir kullanıcı seçiniz.");

                isValid = false;
            }
            if (dgvCars.CurrentRow.Index < 0)
            {
                errorProvider1.SetError(cmbKullanici, "Lütfen bir araç seçiniz.");
                isValid = false;
            }
            if (dtpRentStart.Value.Date > dtpRentEnd.Value.Date)
            {
                errorProvider1.SetError(dtpRentStart, "Başlangıç tarihi bitiş tarihinden büyük olamaz.");
                isValid = false;
            }
            if (dtpRentStart.Value.Date < DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpRentStart, "Başlangıç tarihi bugünden önce olamaz.");
                isValid = false;
            }
            if (dtpRentEnd.Value.Date < DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpRentStart, "Başlangıç tarihi bugünden önce olamaz.");
                MessageBox.Show("Bitiş tarihi bugünden önce olamaz.");
                isValid = false;
            }
            if (DateTime.Now.Date.AddDays(CalculateRentTime()) > dtpRentEnd.Value.Date)
            {
                errorProvider1.SetError(lblEhliyetTarih, "Ehliyet süresi yetersiz.");
                isValid = false;
            }

            return isValid;
        }

        private void InsertRentToDB()
        {
            try
            {
                string query = $"INSERT INTO Kiralama (KullaniciId, AracId, BaslangicTarihi, BitisTarihi, ToplamTutar, Aciklama) " +
                $"VALUES ({((Kullanici)cmbKullanici.SelectedItem).KullaniciId}, {dgvCars.CurrentRow.Cells["AracId"].Value}, " +
                $"'{dtpRentStart.Value.Date.ToString("yyyy-MM-dd")}', '{dtpRentEnd.Value.Date.ToString("yyyy-MM-dd")}', {toplamTutar}, '{txtAciklama.Text}')";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
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
    }
}
