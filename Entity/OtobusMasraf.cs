using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OtobusMasraf
    {
        private int _OtobusMasrafID;
        private int _OtobusID;
        private int _MasrafTipID;
        private decimal _Tutar;
        private int _MasrafYapanPersonelID;
        private int _SeferID;

        public int OtobusMasrafID { get => _OtobusMasrafID; set => _OtobusMasrafID = value; }
        public int OtobusID { get => _OtobusID; set => _OtobusID = value; }
        public int MasrafTipID { get => _MasrafTipID; set => _MasrafTipID = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public int MasrafYapanPersonelID { get => _MasrafYapanPersonelID; set => _MasrafYapanPersonelID = value; }
        public int SeferID { get => _SeferID; set => _SeferID = value; }

        public OtobusMasraf()
        {

        }

        public OtobusMasraf(int otobusMasrafID, int otobusID, int masrafTipID, decimal tutar, int masrafYapanPersonelID, int seferID)
        {
            this._OtobusMasrafID = otobusMasrafID;
            this._OtobusID = otobusID;
            this._MasrafTipID = masrafTipID;
            this._Tutar = tutar;
            this._MasrafYapanPersonelID = masrafYapanPersonelID;
            this._SeferID = seferID;
        }

    }
}
