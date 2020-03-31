using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Otobus
    {
        private int _OtobusID;
        private string _Plaka;
        private byte _KoltukSayisi;
        private int _MarkaID;
        private bool _AktifMi;

        public int OtobusID { get => _OtobusID; set => _OtobusID = value; }
        public string Plaka { get => _Plaka; set => _Plaka = value; }
        public byte KoltukSayisi { get => _KoltukSayisi; set => _KoltukSayisi = value; }
        public int MarkaID { get => _MarkaID; set => _MarkaID = value; }
        public bool AktifMi1 { get => _AktifMi; set => _AktifMi = value; }

        public Otobus()
        {

        }
        public Otobus(int otobusID, string plaka, byte koltukSayisi, int markaID, bool aktifMi)
        {
            this._OtobusID = otobusID;
            this._Plaka = plaka;
            this._KoltukSayisi = koltukSayisi;
            this._MarkaID = markaID;
            this._AktifMi = aktifMi;
        }

    }
}
