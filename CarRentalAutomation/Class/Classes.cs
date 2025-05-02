using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalAutomation.Class
{
    public partial class Arac
    {
        public int AracId { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string VitesTipi { get; set; }
        public string YakitTipi { get; set; }
        public string Renk { get; set; }
        public int Kilometre { get; set; }
        public decimal GunlukKiraUcreti { get; set; }
        public string Durum { get; set; }
        public DateTime SigortaBitisTarihi { get; set; }

        public Arac(int aracId, string plaka, string marka, string model, int yil, string vitesTipi, string yakitTipi,
                    string renk, int kilometre, decimal gunlukKiraUcreti, string durum, DateTime sigortaBitisTarihi)
        {
            AracId = aracId;
            Plaka = plaka;
            Marka = marka;
            Model = model;
            Yil = yil;
            VitesTipi = vitesTipi;
            YakitTipi = yakitTipi;
            Renk = renk;
            Kilometre = kilometre;
            GunlukKiraUcreti = gunlukKiraUcreti;
            Durum = durum;
            SigortaBitisTarihi = sigortaBitisTarihi;
        }
    }
}
