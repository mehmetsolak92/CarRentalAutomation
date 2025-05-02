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
    public partial class SplashScreen : BaseForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            await ReadDB();
            this.DialogResult = DialogResult.OK;
        }

        private async Task ReadDB()
        {
            
            string query = "SELECT * FROM Markalar ORDER BY MarkaAdi";
            Constants.Markalar.Add(new Constants.Marka { ID = -1, Name = "Seçiniz.." });
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Markalar.Add(new Constants.Marka
                        {
                            ID = Convert.ToInt32(reader["MarkaId"]),
                            Name = Convert.ToString(reader["MarkaAdi"]),
                        });
                    }
                }
            }


            query = "SELECT * FROM Modeller";
            Constants.Modeller.Add(new Constants.Model { ID = -1, Name = "Seçiniz..", MarkaID = -1 });
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Modeller.Add(new Constants.Model
                        {
                            ID = Convert.ToInt32(reader["ModelId"]),
                            Name = Convert.ToString(reader["ModelAdi"]),
                            MarkaID = Convert.ToInt32(reader["MarkaId"])
                        });
                    }
                }
            }

            query = "SELECT * FROM Renkler";
            Constants.Renkler.Add("Seçiniz..");
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Renkler.Add(Convert.ToString(reader["RenkAdi"]));
                    }
                }
            }

        }
    }
}
