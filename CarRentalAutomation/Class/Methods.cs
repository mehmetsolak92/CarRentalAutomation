using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using OfficeOpenXml;

namespace CarRentalAutomation.Class
{
    public static class FormStyle
    {
        public static void changeFormStyle(Form form)
        {
            form.BackColor = Color.FromArgb(229, 231, 230);
        }

    }



    public static class SQL
    {
        public static DataTable Select(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connectiom = new SqlConnection(Constants.SQLPath))
            {
                try
                {
                    connectiom.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectiom))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                    Methods.WriteLog(trace, ex);

                }
            }
            return dataTable;
        }

        public static object SelectScalar(string query)
        {
            object result = null;
            using (SqlConnection connection = new SqlConnection(Constants.SQLPath))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        result = command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                    Methods.WriteLog(trace, ex);

                }
            }
            if (result == DBNull.Value || result == null) return 0; else return result;
            
        }

        public static int Delete(string tableName, string whereColumn, int ID)
        {
            string query = $"DELETE FROM {tableName} WHERE {whereColumn} = {ID}";
            using (SqlConnection connection = new SqlConnection(Constants.SQLPath))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                    Methods.WriteLog(trace, ex);
                    return 0;
                }
            }

        }
    }

    public static class Data
    {
        public static void GetCustomersData()
        {
            Constants.Kullanicilar.Clear();
            Constants.Kullanicilar.Add(new Kullanici(
                -1,
                "Seçiniz..",
                "", "", "", "", DateTime.Now.Date, ""
            ));

            string query = "SELECT * FROM Kullanicilar";
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Kullanicilar.Add(new Kullanici(
                            Convert.ToInt32(reader["KullaniciId"]),
                            Convert.ToString(reader["AdSoyad"]),
                            Convert.ToString(reader["Telefon"]),
                            Convert.ToString(reader["Email"]),
                            Convert.ToString(reader["TcNo"]),
                            Convert.ToString(reader["EhliyetNo"]),
                            Convert.ToDateTime(reader["EhliyetTarihi"]),
                            Convert.ToString(reader["EhliyetSinifi"])
                        ));
                    }
                }
            }
        }

        public static void GetCarsData()
        {
            Constants.Araclar.Clear();
            Constants.Araclar.Add(new Arac(
                -1,
                "Seçiniz..",
                "",
                "",
                0,
                "",
                "",
                "",
                0,
                0,
                "",
                DateTime.Now.Date
            ));

            string query = "SELECT * FROM Araclar";
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Araclar.Add(new Arac(
                            Convert.ToInt32(reader["AracId"]),
                            Convert.ToString(reader["Plaka"]),
                            Convert.ToString(reader["Marka"]),
                            Convert.ToString(reader["Model"]),
                            Convert.ToInt32(reader["Yil"]),
                            Convert.ToString(reader["VitesTipi"]),
                            Convert.ToString(reader["YakitTipi"]),
                            Convert.ToString(reader["Renk"]),
                            Convert.ToInt32(reader["Kilometre"]),
                            Convert.ToDecimal(reader["GunlukKiraUcreti"]),
                            Convert.ToString(reader["Durum"]),
                            Convert.ToDateTime(reader["SigortaBitisTarihi"])
                        ));
                    }
                }
            }
        }

        public static void GetStaffsData()
        {
            Constants.Personeller.Clear();

            string query = "SELECT * FROM Personeller";
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Personeller.Add(new Personel(
                            Convert.ToInt32(reader["PersonelId"]),
                            Convert.ToString(reader["AdSoyad"]),
                            Convert.ToString(reader["Sifre"]),
                            Convert.ToString(reader["Gorev"]),
                            Convert.ToString(reader["Telefon"]),
                            Convert.ToString(reader["Email"]),
                            Convert.ToString(reader["TcNo"])
                        ));
                    }
                }
            }
        }

        

        public static void GetColorData()
        {
            string query = "SELECT * FROM Renkler";
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

        public static void GetModelData()
        {
            string query = "SELECT * FROM Modeller";
            Constants.Modeller.Add(new Model { ID = -1, Name = "Seçiniz..", MarkaID = -1 });
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Modeller.Add(new Model
                        {
                            ID = Convert.ToInt32(reader["ModelId"]),
                            Name = Convert.ToString(reader["ModelAdi"]),
                            MarkaID = Convert.ToInt32(reader["MarkaId"])
                        });
                    }
                }
            }
        }

        public static void GetBrandData()
        {
            string query = "SELECT * FROM Markalar ORDER BY MarkaAdi";
            Constants.Markalar.Add(new Marka { ID = -1, Name = "Seçiniz.." });
            using (SqlConnection con = new SqlConnection(Constants.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Constants.Markalar.Add(new Marka
                        {
                            ID = Convert.ToInt32(reader["MarkaId"]),
                            Name = Convert.ToString(reader["MarkaAdi"]),
                        });
                    }
                }
            }
        }

        public static void ExportToExcel(DataGridView dataGridView1, string Name)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Excel dosyasını kaydetmek için bir klasör seçin";

            if (folderDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string fileName = Name + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            string fullPath = Path.Combine(folderDialog.SelectedPath, fileName);

            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(Name);

                    
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                    
                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }

                   
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }

                    
                    worksheet.Cells.AutoFitColumns();

                    
                    FileInfo file = new FileInfo(fullPath);
                    package.SaveAs(file);

                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                Methods.WriteLog(trace, ex);
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }

    public static class Methods
    {
        public static object getdatavalue(object o)
        {
            if (o == null || string.Empty.Equals(o))
                return DBNull.Value;
            else
                return o;
        }

        public static object getboolvalue(object o)
        {
            if (o == null || o == DBNull.Value || string.Empty.Equals(o))
                return false;
            else
                return o;
        }
        public static object getintvalue(object o)
        {
            if (o == null || o == DBNull.Value || string.Empty.Equals(o))
                return 0;
            else
                return o;
        }

        public static bool integerornot(string girdi)
        {
            try
            {
                Convert.ToInt32(getintvalue(girdi));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void WriteLog(System.Diagnostics.StackTrace trace, Exception ex)
        {
            string LogText = DateTime.Now + " - " + ex.Message + " - " + trace.GetFrame(trace.FrameCount - 1).GetMethod().ReflectedType.FullName + " - " + "Line: " + trace.GetFrame(trace.FrameCount - 1).GetFileLineNumber() + " - " + "Column: " + trace.GetFrame(trace.FrameCount - 1).GetFileColumnNumber();
            if (!IsFileLocked(new FileInfo(Constants.LogPath)))
            {
                using (StreamWriter Stm_LogText = new StreamWriter(Constants.LogPath, append: true))
                {
                    try
                    {
                        Stm_LogText.WriteLine(LogText);
                    }
                    catch (Exception e)
                    {

                    }
                    finally
                    {
                        Stm_LogText.Flush();
                        Stm_LogText.Close();
                        Stm_LogText.Dispose();
                    }
                }
            }
        }

        private static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                if (file.Exists)
                {
                    stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Write);
                }
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public static void showFormInPanel(Panel pnlScreens, Form form)
        {
            if (pnlScreens.Controls.OfType<Form>().Any(f => f.GetType() == form.GetType()))
                return;

            pnlScreens.Controls.Clear();
            form.TopLevel = false;
            form.TopMost = true;
            pnlScreens.Controls.Add(form);
            form.Show();

        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }


        public static bool TcDogrula(string tc)
        {
            if (tc.Length != 11 || !long.TryParse(tc, out _) || tc[0] == '0')
                return false;

            int[] digits = tc.Select(c => int.Parse(c.ToString())).ToArray();

            int oddSum = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
            int evenSum = digits[1] + digits[3] + digits[5] + digits[7];

            int digit10 = ((oddSum * 7) - evenSum) % 10;
            int digit11 = digits.Take(10).Sum() % 10;

            return (digit10 == digits[9]) && (digit11 == digits[10]);
        }

        public static bool EmailDogrula(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public static bool TelefonDogrula(string telefon)
        {
            if (telefon.Length != 11)
                return false;

            if (!long.TryParse(telefon, out _))
                return false;

            if (!telefon.StartsWith("05"))
                return false;

            return true;
        }


        public static bool IsPasswordStrong(string pwd)
        {
            return Regex.IsMatch(pwd, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d!@#\$%\^&\*]{4,}$");
        }

    }

}
