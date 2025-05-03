using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public static int Delete(string tableName,string whereColumn,int ID)
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

    }

}
