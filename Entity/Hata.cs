using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hata
    {
        private int _HataID;
        private string _Numara;
        private string _Mesaj;
        private DateTime _Zamani;
        private string _Procedure;

        public int HataID { get => _HataID; set => _HataID = value; }
        public string Numara { get => _Numara; set => _Numara = value; }
        public string Mesaj { get => _Mesaj; set => _Mesaj = value; }
        public DateTime Zamani { get => _Zamani; set => _Zamani = value; }
        public string Procedure { get => _Procedure; set => _Procedure = value; }

        public Hata()
        {

        }

        public Hata(int hataID, string numara, string mesaj, DateTime zamani, string procedure)
        {
            this._HataID = hataID;
            this._Numara = numara;
            this._Mesaj = mesaj;
            this._Zamani = zamani;
            this._Procedure = procedure;
        }

    }
}
