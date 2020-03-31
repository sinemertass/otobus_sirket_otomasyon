using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sehir
    {
        #region Field
        private int _SehirID;
        private string _SehirAdi;

        #endregion

        #region Properties
        public string SehirAdi { get => _SehirAdi; set => _SehirAdi = value; }
        public int SehirID { get => _SehirID; set => _SehirID = value; }

        #endregion

        #region Constructer
        public Sehir()
        {

        }
        public Sehir(int sehirID, string sehirAdi)
        {
            this._SehirAdi = sehirAdi;
            this._SehirID = sehirID;
        }
        #endregion
        public override string ToString()
        {
            return SehirAdi;
        }
    }
}
