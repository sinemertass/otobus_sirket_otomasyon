using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Sefer
    {
        public static int SeferEkle(Entity.Sefer sf)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferEkle", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KalkisSehirID",sf.KalkisSehirID);
            cmd.Parameters.AddWithValue("@VarisSehirID", sf.VarisSehirID);
            cmd.Parameters.AddWithValue("@OtobusID", sf.OtobusID);
            cmd.Parameters.AddWithValue("@SoforID", sf.SoforID);
            cmd.Parameters.AddWithValue("@MuavinID", sf.MuavinID);
            cmd.Parameters.AddWithValue("@KalkisZamani", sf.KalkisZamani);
            cmd.Parameters.AddWithValue("@VarisZamani", sf.VarisZamani);
            cmd.Parameters.AddWithValue("@TahminiSüre", sf.TahminiSrüre);
            cmd.Parameters.AddWithValue("@BiletTutari", sf.BiletTutari);

            return Util.Yurut(cmd);
        }
        public static int SeferGuncelle(Entity.Sefer sf)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferGüncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", sf.SeferID);
            cmd.Parameters.AddWithValue("@KalkisSehirID", sf.KalkisSehirID);
            cmd.Parameters.AddWithValue("@VarisSehirID", sf.VarisSehirID);
            cmd.Parameters.AddWithValue("@OtobusID", sf.OtobusID);
            cmd.Parameters.AddWithValue("@SoforID", sf.SoforID);
            cmd.Parameters.AddWithValue("@MuavinID", sf.MuavinID);
            cmd.Parameters.AddWithValue("@KalkisZamani", sf.KalkisZamani);
            cmd.Parameters.AddWithValue("@VarisZamani", sf.VarisZamani);
            cmd.Parameters.AddWithValue("@TahminiSüre", sf.TahminiSrüre);
            cmd.Parameters.AddWithValue("@BiletTutari", sf.BiletTutari);

            return Util.Yurut(cmd);
        }
        public static int SeferSil(Entity.Sefer sf)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferSil", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", sf.SeferID);

            return Util.Yurut(cmd);
        }
        public static Entity.Sefer SeferDetayGoruntule(int seferID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferDetay", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", seferID);

            Entity.Sefer sf = null;
            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                sf = new Entity.Sefer();
                if (rdr.Read())
                {
                    sf.KalkisSehirID = Convert.ToInt32(rdr["KalkisSehirID"]);
                    sf.VarisSehirID = Convert.ToInt32(rdr["VarisSehirID"]);
                    sf.OtobusID = Convert.ToInt32(rdr["OtobusID"]);
                    sf.SoforID = Convert.ToInt32(rdr["SoforID"]);
                    sf.MuavinID = Convert.ToInt32(rdr["MuavinID"]);
                    sf.KalkisZamani = Convert.ToDateTime(rdr["KalkisZamani"]);
                    sf.VarisZamani = Convert.ToDateTime(rdr["VarisZamani"]);
                    sf.TahminiSrüre = Convert.ToByte(rdr["TahminiSüre"]); //tinyint
                    sf.BiletTutari = Convert.ToInt32(rdr["BiletTutari"]);

                }
            }
            catch (SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);
            }
            finally
            {
                cnn.Close();
            }

            return sf;
        }

    }
}
