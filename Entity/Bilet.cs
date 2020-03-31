using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bilet
    {
        private int _İslemYapanPersonel;
        private int _YolcuID;
        private int _SeferID;
        private DateTime _İslemZamani;
        private bool _SatisMiRezervasyonMu;
        private byte _KoltukNo;
        private bool _Cinsiyet;
        private string _YolcuAdi;
        private string _YolcuSoyadi;
        private bool _SatisTipi;
        private decimal _Ucret;

        public int İslemYapanPersonel { get => _İslemYapanPersonel; set => _İslemYapanPersonel = value; }
        public int YolcuID { get => _YolcuID; set => _YolcuID = value; }
        public int SeferID { get => _SeferID; set => _SeferID = value; }
        public DateTime İslemZamani { get => _İslemZamani; set => _İslemZamani = value; }
        public bool SatisMiRezervasyonMu { get => _SatisMiRezervasyonMu; set => _SatisMiRezervasyonMu = value; }
        public byte KoltukNo { get => _KoltukNo; set => _KoltukNo = value; }
        public bool Cinsiyet { get => _Cinsiyet; set => _Cinsiyet = value; }
        public string YolcuAdi { get => _YolcuAdi; set => _YolcuAdi = value; }
        public string YolcuSoyadi { get => _YolcuSoyadi; set => _YolcuSoyadi = value; }
        public bool SatisTipi { get => _SatisTipi; set => _SatisTipi = value; }
        public decimal Ucret { get => _Ucret; set => _Ucret = value; }

        public Bilet()
        {
               
        }
        public Bilet(int islemYapanPersonel, int yolcuID, int seferId, DateTime islemZamani, bool satisMiRezarvasyonMu, byte koltukNo, bool cinsiyet, string yolcuAdi, string yolcuSoyad, bool satisTipi, decimal ucret)
        {
            this._İslemYapanPersonel = islemYapanPersonel;
            this._YolcuID = yolcuID;
            this._SeferID = seferId;
            this._İslemZamani = islemZamani;
            this._SatisMiRezervasyonMu = satisMiRezarvasyonMu;
            this._KoltukNo = koltukNo;
            this._Cinsiyet = cinsiyet;
            this._YolcuAdi = yolcuAdi;
            this._YolcuSoyadi = yolcuSoyad;
            this._SatisTipi = satisTipi;
            this._Ucret = ucret;
        }

    }
}
