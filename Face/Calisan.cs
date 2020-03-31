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
    public class Calisan
    {
        public static int CalisanEkle(Entity.Calisan cl)
        {
           
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanEkle", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Adi", cl.PersonelAdi);
            cmd.Parameters.AddWithValue("@Soyadi",cl.PersonelSoyadi);
            cmd.Parameters.AddWithValue("@Email", cl.PersonelEmail);
            cmd.Parameters.AddWithValue("@Telefon", cl.PersonelTelefon);
            cmd.Parameters.AddWithValue("@SubeID", cl.SubeID);
            cmd.Parameters.AddWithValue("@EvAdresi", cl.EvAdresi);
            cmd.Parameters.AddWithValue("@KullaniciAdi", cl.KullaniciAdi);
            cmd.Parameters.AddWithValue("@CalisanTipiID", cl.CalisanTipiID);
            cmd.Parameters.AddWithValue("@YöneticiMi", cl.YoneticiMi);
            cmd.Parameters.AddWithValue("@Sifre", cl.Sifre);

            return Util.Yurut(cmd);
            
        }

        public static int CalisanGuncelle(Entity.Calisan cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", cl.PersonelID);
            cmd.Parameters.AddWithValue("@Adi", cl.PersonelAdi);
            cmd.Parameters.AddWithValue("@Soyadi", cl.PersonelSoyadi);
            cmd.Parameters.AddWithValue("@Email", cl.PersonelEmail);
            cmd.Parameters.AddWithValue("@Telefon", cl.PersonelTelefon);
            cmd.Parameters.AddWithValue("@SubeID", cl.SubeID);
            cmd.Parameters.AddWithValue("@EvAdresi", cl.EvAdresi);
            cmd.Parameters.AddWithValue("@KullaniciID", cl.KullaniciAdi);
            cmd.Parameters.AddWithValue("@CalisanTipiID", cl.CalisanTipiID);
            cmd.Parameters.AddWithValue("@YöneticiMi", cl.YoneticiMi);
            cmd.Parameters.AddWithValue("@Sifre", cl.Sifre);


            return Util.Yurut(cmd);
        }

        public static int CalisanSil(Entity.Calisan cl)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanSil", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", cl.PersonelID);

            return Util.Yurut(cmd);
        }

        public static Entity.Calisan CalisanDetayGor(int personelID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanDetay", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", personelID);

            Entity.Calisan cl = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                cl = new Entity.Calisan();
                if (rdr.Read())
                {
                    cl.PersonelAdi = Convert.ToString(rdr["Adi"]);
                    cl.PersonelSoyadi = Convert.ToString(rdr["Soyadi"]);
                    cl.PersonelEmail = Convert.ToString(rdr["Email"]);
                    cl.PersonelTelefon = Convert.ToString(rdr["Telefon"]);
                    cl.SubeID = Convert.ToInt32(rdr["SubeID"]);
                    cl.EvAdresi = Convert.ToString(rdr["EvAdresi"]);
                    cl.KullaniciAdi = Convert.ToString(rdr["KullaniciAdi"]);
                    cl.CalisanTipiID = Convert.ToInt32(rdr["CalisanTipiID"]); //tinyint
                    cl.YoneticiMi = Convert.ToBoolean(rdr["YöneticiMi"]);
                    cl.Sifre = Convert.ToString(rdr["Sifre"]);

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

        public static bool CalisanVarMi(string calisanAdi, string calisanSoyadi)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Calisanlar WHERE Adi=@Ad and Soyadi=@Soyad", cnn); //Adi Soyadi veritabanındaki kısım.
            cmd.Parameters.AddWithValue("@Ad", calisanAdi); // @Ad parametresinin içi fonksiyona gelen calisanAdi ile dolduruldu.
            cmd.Parameters.AddWithValue("@Soyad", calisanSoyadi); // @Soyad parametresinin içi fonksiyona gelen calisanSoyadi ile dolduruldu.

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();

                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //eğer böyle bir sonuç varsa çalışan kaydı var demek, sonuc true
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

        public static Entity.Calisan Login(Entity.Calisan calisan)
        {
            System.Data.SqlClient.SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanGiris", cnn);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KullaniciAdi", calisan.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", calisan.Sifre);

            Entity.Calisan donecekcalisan = null;

            try
            {
                cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    donecekcalisan = new Entity.Calisan();
                    donecekcalisan.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    donecekcalisan.YoneticiMi = Convert.ToBoolean(rdr["YöneticiMi"]);
                    donecekcalisan.SubeID = Convert.ToInt32(rdr["SubeID"]);
                    donecekcalisan.CalisanTipiID = Convert.ToInt32(rdr["CalisanTipiID"]);
                }
            }
            catch (SqlException ex)
            {

                Hataci.YeniHataKaydi(ex);
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return donecekcalisan;
        }

        public static void CalisanListesi(ListView Calisanlar)
        {
            Calisanlar.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Calisanlar.*, dbo.CalisanTipleri.CalisanTipAdi, dbo.Subeler.SubeAdi FROM dbo.Calisanlar INNER JOIN dbo.CalisanTipleri ON dbo.Calisanlar.CalisanTipiID = dbo.CalisanTipleri.CalisanTipID INNER JOIN dbo.Subeler ON dbo.Calisanlar.SubeID = dbo.Subeler.SubeID", cnn);

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();

                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    Calisanlar.Items.Add(Convert.ToInt32(rdr["PersonelID"]).ToString());
                    //subitems PersonelID ile belirtilen olan özel olan ad,soyad, ünvan gibi seyler
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Adi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Soyadi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Email"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToInt32(rdr["SubeID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["EvAdresi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["KullaniciAdi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToInt32(rdr["CalisanTipiID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));

                    if (rdr["YöneticiMi"].ToString()=="False")
                    {
                        Calisanlar.Items[i].SubItems.Add("Hayır");
                    }
                    else
                    {
                        Calisanlar.Items[i].SubItems.Add("Evet");

                    }

                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Sifre"]));
                    i++;
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

        public static int CalisanSayisi()
        {
            int sayi = 0;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT Count(PersonelID) as CalisanSayisi FROM Calisanlar ", cnn);

            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sayi = Convert.ToInt32(rdr["CalisanSayisi"]);
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

            return sayi;
        }

        public static void AdaGoreCalisanGetir(ListView lstCalisan, string arancakcalisan)
        {
            lstCalisan.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Calisanlar.*, dbo.CalisanTipleri.CalisanTipAdi, dbo.Subeler.SubeAdi FROM dbo.Calisanlar INNER JOIN dbo.CalisanTipleri ON dbo.Calisanlar.CalisanTipiID = dbo.CalisanTipleri.CalisanTipID INNER JOIN dbo.Subeler ON dbo.Calisanlar.SubeID = dbo.Subeler.SubeID where Calisanlar.Adi like @CalisanAd+'%'", cnn);
            cmd.Parameters.AddWithValue("@CalisanAd", arancakcalisan);
            try
            {
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();

                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lstCalisan.Items.Add(Convert.ToInt32(rdr["PersonelID"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Adi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Soyadi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Email"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToInt32(rdr["SubeID"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["EvAdresi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["KullaniciAdi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToInt32(rdr["CalisanTipiID"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToBoolean(rdr["YöneticiMi"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Sifre"]));
                    i++;
                }
            }
            catch (SqlException ex)
            {

                string hata=ex.Message;
            }
            finally
            {
                cnn.Close();
            }


        }

        public static void SubeAdinaGoreCalisanGetir(ListView lstCalisan, string SubeAdi)
        {
            lstCalisan.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Calisanlar.*, dbo.CalisanTipleri.CalisanTipAdi, dbo.Subeler.SubeAdi FROM dbo.Calisanlar INNER JOIN dbo.CalisanTipleri ON dbo.Calisanlar.CalisanTipiID = dbo.CalisanTipleri.CalisanTipID INNER JOIN dbo.Subeler ON dbo.Calisanlar.SubeID = dbo.Subeler.SubeID where Subeler.SubeAdi like @SubeAdi+'%'", cnn);
            cmd.Parameters.AddWithValue("@SubeAdi", SubeAdi);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();

                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lstCalisan.Items.Add(Convert.ToInt32(rdr["PersonelID"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Adi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Soyadi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Email"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToInt32(rdr["SubeID"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["EvAdresi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["KullaniciAdi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToInt32(rdr["CalisanTipiID"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
                    lstCalisan.Items[i].SubItems.Add(Convert.ToBoolean(rdr["YöneticiMi"]).ToString());
                    lstCalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Sifre"]));
                    i++;
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
    }
}
