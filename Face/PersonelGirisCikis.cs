using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class PersonelGirisCikis
    {
        public static int PersonelGirisCikisEkle(Entity.PersonelGirisCikis pgc)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisEkle", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", pgc.PersonelID);
            cmd.Parameters.AddWithValue("@IslemTipi", pgc.IslemTipi);
            
            return Util.Yurut(cmd);
        }

        public static int PersonelGirisCikisGuncelle(Entity.PersonelGirisCikis pgc)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelIslemID", pgc.PersonelIslemID);
            cmd.Parameters.AddWithValue("@PersonelID", pgc.PersonelID);
            cmd.Parameters.AddWithValue("@IslemZamani", pgc.IslemZamani);
            cmd.Parameters.AddWithValue("@IslemTipi", pgc.IslemTipi);

            return Util.Yurut(cmd);
        }

        public static int PersonelGirisCikisSil(Entity.PersonelGirisCikis pgc)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisSil", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelIslemID", pgc.PersonelIslemID);

            return Util.Yurut(cmd);
        }

        public static ArrayList PersonelGirisCikisListesi(Entity.PersonelGirisCikis pgc)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisListesi", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            ArrayList personelgiriscikislistesi = new ArrayList();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Close();
                }
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    
                    Entity.PersonelGirisCikis pgc2 = new Entity.PersonelGirisCikis();
                    pgc2.PersonelIslemID = Convert.ToInt32(rdr["PersonelIslemID"]);
                    pgc2.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    pgc2.IslemZamani = Convert.ToDateTime(rdr["IslemZamani"]);
                    pgc2.IslemTipi = Convert.ToBoolean(rdr["IslemTipi"]);
                    personelgiriscikislistesi.Add(pgc2);
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

            return personelgiriscikislistesi;

        }

        public static Entity.PersonelGirisCikis PersonelAra(int personelID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelAra", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", personelID);
            Entity.PersonelGirisCikis per = null;

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                }
                per = new Entity.PersonelGirisCikis();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    per.PersonelIslemID = Convert.ToInt32(rdr["PersonelIslemID"]);
                    per.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    per.IslemZamani = Convert.ToDateTime(rdr["IslemZamani"]);
                    per.IslemTipi = Convert.ToBoolean(rdr["IslemTipi"]);
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
            return per;
        }
    }
}
