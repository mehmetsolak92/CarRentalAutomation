using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalAutomation.Class
{
    public static class Constants
    {
        public static string SQLPath = "Data Source=(local);Initial Catalog=CarRental;User ID=mehmet;Password=57781123;TrustServerCertificate=True;";
        public static string LogPath = @"D:\Kurs Projeleri\CarRentalAutomation\CarRentalData\log.txt";
        public static List<Marka> Markalar = new List<Marka>();
        public static List<Model> Modeller = new List<Model>();
        public static List<string> Renkler = new List<string>();

        public static List<string> VitesTipi = new List<string>
        {
            "Seçiniz..",
            "Otomatik",
            "Manuel"
        };

        public static List<string> YakitTipi = new List<string>
        {
            "Seçiniz..",
            "Dizel",
            "Benzin",
            "Benzin+LPG",
            "LPG"
        };

        public static List<string> EhliyetSinifi = new List<string>
        {
            "Seçiniz..",
            "A",
            "A1",
            "A2",
            "B",
            "B1",
            "D",
            "E"
        };



        public class Marka
        {
            public int ID { get; set; }
            public string Name { get; set; }
         
            public override string ToString()
            {
                return Name;
            }
        }

        public class Model
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int MarkaID { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        
    }
}
