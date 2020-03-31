using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ayar
    {
        private int _AyarID;
        private string _Anahtar;
        private string _Deger;

        public int AyarID { get => _AyarID; set => _AyarID = value; }
        public string Anahtar { get => _Anahtar; set => _Anahtar = value; }
        public string Deger { get => _Deger; set => _Deger = value; }

        public Ayar()
        {

        }
        public Ayar(int ayarID, string anahtar, string deger)
        {
            this._AyarID = ayarID;
            this._Anahtar = anahtar;
            this._Deger = deger;

        }

    }
}
