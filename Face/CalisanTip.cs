using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face
{
    public class CalisanTip
    {
        public static int CalisanTipEkle(Entity.CalisanTip cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipEkle", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipAdi", cl.CalisanTipAdi);

            return Util.Yurut(cmd);
        }


        public static int CalisanTipGuncelle(Entity.CalisanTip cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipID", cl.CalisanTipID);
            cmd.Parameters.AddWithValue("@CalisanTipAdi", cl.CalisanTipAdi);
            
            return Util.Yurut(cmd);
        }

        public static int CalisanTipSil(Entity.CalisanTip cl)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipSil", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipID", cl.CalisanTipID);

            return Util.Yurut(cmd);
        }

        public static Entity.CalisanTip CalisanTipDetayGor(int calisantipID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanDetay", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipID", calisantipID);

            Entity.CalisanTip cl = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                cl = new Entity.CalisanTip();
                if (rdr.Read())
                {
                    cl.CalisanTipAdi = Convert.ToString(rdr["CalisanTipAdi"]);
                    cl.CalisanTipID = Convert.ToInt32(rdr["CalisanTipID"]);

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

            return cl;
        }

        public static void CalisanTipGetir(ComboBox CalisanTip)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM CalisanTipleri",cnn);

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                Entity.CalisanTip clt = null;
                while (rdr.Read())
                {
                    clt = new Entity.CalisanTip();
                    clt.CalisanTipID = Convert.ToInt32(rdr["CalisanTipID"]);
                    clt.CalisanTipAdi = Convert.ToString(rdr["CalisanTipAdi"]);
                    CalisanTip.Items.Add(clt);
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
        }


    }
}
