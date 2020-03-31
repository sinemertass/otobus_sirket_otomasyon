using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MasrafTip
    {
        private int _MasrafTipID;
        private int _MasrafTipAdi;

        public int MasrafTipID { get => _MasrafTipID; set => _MasrafTipID = value; }
        public int MasrafTipAdi { get => _MasrafTipAdi; set => _MasrafTipAdi = value; }

        public MasrafTip()
        {

        }
        public MasrafTip(int masrafTipID, int masrafTipAdi)
        {
            this._MasrafTipID = masrafTipID;
            this._MasrafTipAdi = masrafTipAdi;
        }

    }
}
