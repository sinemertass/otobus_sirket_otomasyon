using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Marka
    {
        private int _MarkaID;
        private string _MarkaAdi;

        public int MarkaID { get => _MarkaID; set => _MarkaID = value; }
        public string MarkaAdi { get => _MarkaAdi; set => _MarkaAdi = value; }

        public Marka()
        {

        }
        public Marka(int markaID, string markaAdi)
        {
            this._MarkaID = markaID;
            this._MarkaAdi = markaAdi;
        }
    }
}
