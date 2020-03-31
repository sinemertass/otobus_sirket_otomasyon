using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Util
    {
        /* işlem başarılı ise method 1 döndürücek,
           işlem herhangibir değeri etkilemezse 0 değer döndürücek,
           eğerki işlemde hata meydana gelirse -1 olarak değeri verecek */ 
       // public static string cnnstring = "Server=.;Database=OtobusOtomasyon;uid=sse;pwd=12345;";
        public static string cnnstring = "Server=DESKTOP-SNUMBLA\\SQLEXPRESS;Database=OtobusOtomasyon;Integrated Security=true;";

        

        public static int Yurut(SqlCommand cmd)
        {
            int etkilenensatirsayisi = -1;
            try
            {
                cmd.Connection.Open();
                etkilenensatirsayisi= cmd.ExecuteNonQuery();

            }
            catch(SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);
                
            }
            finally
            {
                cmd.Connection.Close();
            }
            return etkilenensatirsayisi;
        }
    }
}
