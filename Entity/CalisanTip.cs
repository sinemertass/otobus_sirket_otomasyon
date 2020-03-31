using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CalisanTip
    {
        private int _CalisanTipID;
        private string _CalisanTipAdi;

        public int CalisanTipID { get => _CalisanTipID; set => _CalisanTipID = value; }
        public string CalisanTipAdi { get => _CalisanTipAdi; set => _CalisanTipAdi = value; }

        public CalisanTip()
        {

        }
        public CalisanTip(int calisanTipID, string calisanTipAdi)
        {
            this._CalisanTipID = calisanTipID;
            this._CalisanTipAdi = calisanTipAdi;
        }

        public override string ToString()
        {
            return CalisanTipAdi; 
        }

    }
}
