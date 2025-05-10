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


    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string TcNo { get; set; }
        public string EhliyetNo { get; set; }
        public DateTime EhliyetTarihi { get; set; }
        public string EhliyetSinifi { get; set; }

        public Kullanici(int kullaniciId, string adSoyad, string telefon, string mail, string tcNo,
                         string ehliyetNo, DateTime ehliyetTarihi, string ehliyetSinifi)
        {
            KullaniciId = kullaniciId;
            AdSoyad = adSoyad;
            Telefon = telefon;
            Mail = mail;
            TcNo = tcNo;
            EhliyetNo = ehliyetNo;
            EhliyetTarihi = ehliyetTarihi;
            EhliyetSinifi = ehliyetSinifi;
        }
    }

    public class Personel
    {
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; } // SHA-256 hash (64 karakter)
        public string Gorev { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string TcNo { get; set; }

        public Personel(int personelId, string adSoyad, string sifre, string gorev,
                        string telefon, string email, string tcNo)
        {
            PersonelId = personelId;
            AdSoyad = adSoyad;
            Sifre = sifre;
            Gorev = gorev;
            Telefon = telefon;
            Email = email;
            TcNo = tcNo;
        }
    }


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
