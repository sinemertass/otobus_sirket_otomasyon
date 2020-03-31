using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Musteri
    {
        private int _MusteriID;
        private string _MusteriAd;
        private string _MusteriSoyad;
        private string _MusteriEmail;
        private string _MusteriTelefon;
        private bool _Cinsiyet;
        private DateTime _DogumTarihi;
        private int _SehirID;
        private string _Adres;
        private string _KartNumarasi;
        private bool _KartTeslimDurumu;
        private decimal _Money;

        public int MusteriID { get => _MusteriID; set => _MusteriID = value; }
        public string MusteriSoyad { get => _MusteriSoyad; set => _MusteriSoyad = value; }
        public string MusteriAd { get => _MusteriAd; set => _MusteriAd = value; }
        public string Email { get => _MusteriEmail; set => _MusteriEmail = value; }
        public string Telefon { get => _MusteriTelefon; set => _MusteriTelefon = value; }
        public bool Cinsiyet { get => _Cinsiyet; set => _Cinsiyet = value; }
        public DateTime DogumTarihi { get => _DogumTarihi; set => _DogumTarihi = value; }
        public int SehirID { get => _SehirID; set => _SehirID = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string KartNumarasi { get => _KartNumarasi; set => _KartNumarasi = value; }
        public bool KartTeslimDurumu { get => _KartTeslimDurumu; set => _KartTeslimDurumu = value; }
        public decimal Money { get => _Money; set => _Money = value; }

        public Musteri()
        {

        }

        public Musteri(int musteriID, string musteriAd, string musteriSoyad, string email, string telefon, bool cinsiyet, DateTime dogumTarihi, int sehirID, string adres, string kartNumarasi, bool kartTeslimDurumu, decimal money)
        {
            this._MusteriID = musteriID;
            this._MusteriAd = musteriAd;
            this._MusteriSoyad = musteriSoyad;
            this._MusteriEmail = email;
            this._MusteriTelefon = telefon;
            this._Cinsiyet = cinsiyet;
            this._DogumTarihi = dogumTarihi;
            this._SehirID = sehirID;
            this._Adres = adres;
            this._KartNumarasi = kartNumarasi;
            this._KartTeslimDurumu = kartTeslimDurumu;
            this._Money = money;
        }

    }
}
