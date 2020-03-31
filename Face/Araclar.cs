using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Araclar
    {
        public static string MD5yapUTF8(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider(); //md5 nesnesi üretildi
            byte[] bsifre = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text));
            //text denilen girilen şifre
            //UTF8'in GetBytes() methodu ile bir byte dizisine atadık

            StringBuilder sb = new StringBuilder();
            //string builder sınıfından bir nesne ürettim
            //byte dizisindeki değerleri Append methodu ile birstring ifadeye çevirdim

            foreach (var by in bsifre)
            {
                //x2 burda stringe çevirirken vermesini istediğim format
                //çıktısında göreceğimiz gibi sayılar ve harflerden oluşacak.
                sb.Append(by.ToString("x2").ToLower());
            }

            return sb.ToString();
            //oluşturulan şifrelenmiş metni string ifade olarak aldı return ile
            
        }
    }
}
