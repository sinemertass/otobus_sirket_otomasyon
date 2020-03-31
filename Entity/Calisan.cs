using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Calisan
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Email;
        private string _Telefon;
        private int _SubeID;
        private string _EvAdresi;
        private string _KullaniciAdi;
        private int _CalisanTipiID;
        private bool _YoneticiMi;
        private string _Sifre;

        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string PersonelAdi { get => _Adi; set => _Adi = value; }
        public string PersonelSoyadi { get => _Soyadi; set => _Soyadi = value; }
        public string PersonelEmail { get => _Email; set => _Email = value; }
        public string PersonelTelefon { get => _Telefon; set => _Telefon = value; }
        public int SubeID { get => _SubeID; set => _SubeID = value; }
        public string EvAdresi { get => _EvAdresi; set => _EvAdresi = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public int CalisanTipiID { get => _CalisanTipiID; set => _CalisanTipiID = value; }
        public bool YoneticiMi { get => _YoneticiMi; set => _YoneticiMi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }


        public Calisan()
        {

        }
        public Calisan(int personelID, string personelAdi, string personelSoyadi, string personelEmail, string personelTelefon, int subeID, string evAdresi, string kullaniciAdi, int calisanTipiID, bool yoneticiMi, string sifre)
        {
            this._PersonelID = personelID;
            this._Adi = personelAdi;
            this._Soyadi = personelSoyadi;
            this._Email = personelEmail;
            this._Telefon = personelTelefon;
            this._SubeID = subeID;
            this._EvAdresi = evAdresi;
            this._KullaniciAdi = kullaniciAdi;
            this._CalisanTipiID = calisanTipiID;
            this._YoneticiMi = yoneticiMi;
            this._Sifre = sifre;
        }

    }
}
