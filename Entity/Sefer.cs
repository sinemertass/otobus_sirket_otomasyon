using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sefer
    {
        #region Field
        private int _SeferID;
        private int _KalkisSehirID;
        private int _VarisSehirID;
        private int _OtobusID;
        private int _SoforID;
        private int _MuavinID;
        private DateTime _KalkisZamani;
        private DateTime _VarisZamani;
        private byte _TahminiSrüre;
        private decimal _BiletTutari;

        #endregion

        #region Properties
        public int SeferID { get => _SeferID; set => _SeferID = value; }
        public int KalkisSehirID { get => _KalkisSehirID; set => _KalkisSehirID = value; }
        public int VarisSehirID { get => _VarisSehirID; set => _VarisSehirID = value; }
        public int OtobusID { get => _OtobusID; set => _OtobusID = value; }
        public int SoforID { get => _SoforID; set => _SoforID = value; }
        public int MuavinID { get => _MuavinID; set => _MuavinID = value; }
        public DateTime KalkisZamani { get => _KalkisZamani; set => _KalkisZamani = value; }
        public DateTime VarisZamani { get => _VarisZamani; set => _VarisZamani = value; }
        public byte TahminiSrüre { get => _TahminiSrüre; set => _TahminiSrüre = value; }
        public decimal BiletTutari { get => _BiletTutari; set => _BiletTutari = value; }

        #endregion

        #region Constructer
        public Sefer(int seferID, int kalkisSehirID, int varisSehirID, int otobusID, int soforID, int muavinID, DateTime kalkisZamani, DateTime varisZamani, byte tahminiSüre, decimal biletTutari)
        {
            this._SeferID = seferID;
            this._KalkisSehirID = kalkisSehirID;
            this._VarisSehirID = varisSehirID;
            this._OtobusID = otobusID;
            this._SoforID = soforID;
            this._MuavinID = muavinID;
            this._KalkisZamani = kalkisZamani;
            this._VarisZamani = varisZamani;
            this._TahminiSrüre = tahminiSüre;
            this._BiletTutari = biletTutari;

        }

        public Sefer()
        {

        } 
        #endregion

    }
}
