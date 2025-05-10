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
    public partial class FinanceOutgoing : BaseForm
    {
        public FinanceOutgoing()
        {
            InitializeComponent();
        }

        private void FinanceOutgoing_Load(object sender, EventArgs e)
        {
            dtpPaymentDate.Value = DateTime.Now;
        }

        private void btnGiderGir_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    string query = $"INSERT INTO OdemeDetaylari (KiralamaId, OdemeTarihi, OdemeTutari, OdemeSekli,Aciklama, OdemeTuru) VALUES (NULL,'{dtpPaymentDate.Value.Date.ToString("yyyy-MM-dd")}', {txtOdenenTutar.Text.Replace(",", ".")}, '{(rbNakit.Checked ? "Nakit" : "Kredi Kartı")}', '{txtAciklama.Text}', 'Gider')";
                    using (SqlConnection con = new SqlConnection(Constants.SQLPath))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                    Methods.WriteLog(trace, ex);
                }
            }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtOdenenTutar.Text) || Convert.ToInt32(txtOdenenTutar.Text) <= 0)
            {
                errorProvider1.SetError(txtOdenenTutar, "Ödeme Tutarı Giriniz!");
                isValid = false;
            }

            if (dtpPaymentDate.Value.Date > DateTime.Now)
            {
                errorProvider1.SetError(dtpPaymentDate, "İleri Tarihli Gider Girmezseniz!");
                isValid = false;
            }
            return isValid;
        }
    }
}
