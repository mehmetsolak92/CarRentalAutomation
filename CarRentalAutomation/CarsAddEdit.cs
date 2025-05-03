using CarRentalAutomation.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class CarsAddEdit : BaseForm
    {
        int aracId = 0;

        public CarsAddEdit(int _aracId)
        {
            InitializeComponent();
            aracId = _aracId;
        }

        private void CarsAddEdit_Load(object sender, EventArgs e)
        {
            cmbMarka.DataSource = Constants.Markalar;
            cmbMarka.DisplayMember = "Name";
            cmbMarka.ValueMember = "ID";
            cmbMarka.SelectedIndex = 0;

            cmbModel.Enabled = false;
            cmbModel.DataSource = Constants.Modeller;
            cmbModel.DisplayMember = "Name";
            cmbModel.ValueMember = "ID";
            cmbModel.SelectedIndex = 0;

            cmbYil.Items.Add("Seçiniz..");
            for (int i = 1900; i <= 2100; i++)
            {
                cmbYil.Items.Add(i.ToString());
            }

            cmbVites.DataSource = Constants.VitesTipi;
            cmbYakit.DataSource = Constants.YakitTipi;
            cmbRenk.DataSource = Constants.Renkler;

            if (aracId == 0)
            {
                cmbYil.SelectedItem = DateTime.Now.Year.ToString();
            }
            else
            {
                ReadCarData(aracId);
                this.Text = "ARAÇ GÜNCELLE";
            }

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex > 0)
            {
                Marka selectedMarka = (Marka)cmbMarka.SelectedItem;

                var filteredModeller = Constants.Modeller
                    .Where(d => d.MarkaID == selectedMarka.ID)
                    .ToList();
                cmbModel.DataSource = filteredModeller;
                cmbModel.DisplayMember = "Name";
                cmbModel.ValueMember = "ID";
                cmbModel.SelectedIndex = 0;
                cmbModel.Enabled = true;
            }
            else
            {
                cmbModel.Enabled = false;
                cmbModel.DataSource = new List<Model> { new Model { Name = "Seçiniz..", ID = -1 } };
                cmbModel.SelectedIndex = 0;
            }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtPlaka.Text))
            {
                errorProvider1.SetError(txtPlaka, "Plaka boş bırakılamaz!");
                isValid = false;
            }
            if (cmbMarka.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbMarka, "Marka seçiniz!");
                isValid = false;
            }
            if (cmbModel.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbModel, "Model seçiniz!");
                isValid = false;
            }

            if (cmbYil.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbYil, "Yıl seçiniz!");
                isValid = false;
            }

            if (cmbVites.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbVites, "Vites tipi seçiniz!");
                isValid = false;
            }

            if (cmbYakit.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbYakit, "Yakıt tipi seçiniz!");
                isValid = false;
            }

            if (cmbRenk.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbRenk, "Renk seçiniz!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtKilometre.Text))
            {
                errorProvider1.SetError(txtKilometre, "Kilometre boş bırakılamaz!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtUcret.Text))
            {
                errorProvider1.SetError(txtUcret, "Ücret boş bırakılamaz!");
                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string msgStr = string.Empty;
                if (aracId == 0) msgStr = "Yeni araç eklenecek. Emin misiniz?"; else msgStr = "Araç güncellenecek. Emin misiniz?";
                DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (aracId == 0) InsertCarToDB(); else UpdateCarData();

                    if (this.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void InsertCarToDB()
        {
            try
            {
                string query = $"INSERT INTO Araclar (Plaka, Marka, Model, Yil, VitesTipi, YakitTipi, Renk, Kilometre, GunlukKiraUcreti,Durum, SigortaBitisTarihi) " +
                    $"VALUES ('{txtPlaka.Text}', '{cmbMarka.Text}', '{cmbModel.Text}', {cmbYil.Text}, '{cmbVites.Text}', '{cmbYakit.Text}', '{cmbRenk.Text}', {txtKilometre.Text}, {txtUcret.Text.Replace(',', '.')}, 'Müsait','{dtpSigorta.Value.Date.ToString("yyyy-MM-dd")}')";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Data.GetCarsData();
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

        private void UpdateCarData()
        {

            try
            {
                string query = $"UPDATE Araclar SET Plaka = '{txtPlaka.Text}', Marka = '{cmbMarka.Text}', Model = '{cmbModel.Text}'" +
                $", Yil = {cmbYil.Text}, VitesTipi = '{cmbVites.Text}', YakitTipi = '{cmbYakit.Text}'" +
                $", Renk = '{cmbRenk.Text}', Kilometre = {txtKilometre.Text}, GunlukKiraUcreti = '{txtUcret.Text.Replace(',', '.')}'" +
                $", SigortaBitisTarihi = '{dtpSigorta.Value.Date.ToString("yyyy-MM-dd")}'" +
                $"  WHERE AracId = {aracId}";

                using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Data.GetCarsData();
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

        void ReadCarData(int ID)
        {
            try
            {
                string query = $"SELECT * FROM Araclar WHERE AracId = {ID}";

                using SqlConnection con = new SqlConnection(Constants.SQLPath);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtPlaka.Text = Convert.ToString(reader["Plaka"]);
                            cmbMarka.Text = Convert.ToString(reader["Marka"]);
                            cmbModel.Text = Convert.ToString(reader["Model"]);
                            cmbYil.Text = Convert.ToString(reader["Yil"]);
                            cmbVites.Text = Convert.ToString(reader["VitesTipi"]);
                            cmbYakit.Text = Convert.ToString(reader["YakitTipi"]);
                            cmbRenk.Text = Convert.ToString(reader["Renk"]);
                            txtKilometre.Text = Convert.ToString(reader["Kilometre"]);
                            txtUcret.Text = Convert.ToString(reader["GunlukKiraUcreti"]);
                            dtpSigorta.Value = Convert.ToDateTime(reader["SigortaBitisTarihi"]);
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
