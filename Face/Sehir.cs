using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Face
{
    public class Sehir
    {
        public static int SehirEkle(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirEkle", cnn); //veritabanı Stored Procedure ismi

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirAdi", sh.SehirAdi);
            return Util.Yurut(cmd);

        }
        public static int SehirGuncelle(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirGuncelle", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SehirAdi", sh.SehirAdi);
            cmd.Parameters.AddWithValue("SehirID", sh.SehirID);

            return Util.Yurut(cmd);
        }

        public static void SehirListele(ComboBox sehler)
        {   
            sehler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sehirler", cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Sehir sh = new Entity.Sehir();
                    sh.SehirID = Convert.ToInt32(rdr["SehirID"]);
                    sh.SehirAdi = Convert.ToString(rdr["SehirAdi"]);
                    sehler.Items.Add(sh);

                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static int SehirSil(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirSil", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirID", sh.SehirID);

            return Util.Yurut(cmd);

        }
        public static ArrayList SehirListesi(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirListesi", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            ArrayList sehirListesi = new ArrayList();
            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Close();
                }
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    Entity.Sehir s = new Entity.Sehir();
                    s.SehirID = Convert.ToInt32(rdr["SehirID"]);
                    s.SehirAdi = Convert.ToString(rdr["SehirAdi"]);
                    sehirListesi.Add(s);
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

            return sehirListesi;

        }

        public static Entity.Sehir SehirDetayGoruntule(int sehirID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SehirID", sehirID);
            Entity.Sehir sh = null;

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                sh = new Entity.Sehir();
                if (rdr.Read())
                {
                    sh.SehirID = Convert.ToInt32(rdr["SehirID"]);
                    sh.SehirAdi = Convert.ToString(rdr["SehirAdi"]);
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
            return sh;

        }

        public static bool SehirVarMi(string sehirAdi)
        {
            bool sonuc = false;

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sehirler WHERE SehirAdi=@SehirAdi", cnn);
            cmd.Parameters.AddWithValue("@SehirAdi", sehirAdi);

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                cnn.Open();

                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sonuc = true;
                }
                rdr.Close();

            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }

            finally
            {
                cnn.Close();
            }

            return sonuc;
        }

    }
}
