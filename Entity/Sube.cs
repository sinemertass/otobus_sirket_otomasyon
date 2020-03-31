using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sube
    {
        #region Fields
        private int _SubeID;
        private int _SehirID;
        private string _SubeAdi;
        #endregion

        #region Properties
        public int SehirID { get => _SehirID; set => _SehirID = value; }
        public int SubeID { get => _SubeID; set => _SubeID = value; }
        public string SubeAdi { get => _SubeAdi; set => _SubeAdi = value; }


        #endregion

        #region Constructer
        public Sube()
        {

        }

        public Sube(int subeID, int sehirID, string subeAdi)
        {
            this._SubeID = subeID;
            this._SehirID = sehirID;
            this._SubeAdi = subeAdi;
        }


        #endregion

        public override string ToString()
        {
            return SubeAdi;
        }

    }
}
