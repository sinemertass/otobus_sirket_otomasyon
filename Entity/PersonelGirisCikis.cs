using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonelGirisCikis
    {
        #region field
        private int _PersonelIslemID;
        private int _PersonelID;
        private DateTime _IslemZamani;
        private bool _IslemTipi;
        #endregion

        #region Properties
        public int PersonelIslemID { get => _PersonelIslemID; set => _PersonelIslemID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public DateTime IslemZamani { get => _IslemZamani; set => _IslemZamani = value; }
        public bool IslemTipi { get => _IslemTipi; set => _IslemTipi = value; }

        #endregion

        #region Constructer
        public PersonelGirisCikis()
        {

        }
        public PersonelGirisCikis(int personelIslemID, int personelID, DateTime islemZamani, bool islemTipi)
        {
            this._PersonelIslemID = personelIslemID;
            this._PersonelID = personelID;
            this._IslemZamani = islemZamani;
        } 
        #endregion



    }
}
