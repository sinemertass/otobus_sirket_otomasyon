using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Mail
    {
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public int SmtpPort { get; set; }
        public string Host { get; set; }
        public string Kime { get; set; }
        public string Kimden { get; set; }
        public NetworkCredential Credential { get; set; }
        public string sifre = "Sifrenizi giriniz:"; 

        public Mail(string Mailkonusu, string MailMesaji, string KimeGonderilecek)
        {
            this.Konu = Mailkonusu;
            this.Mesaj = MailMesaji;
            this.Host = "smtp.gmail.com";
            this.SmtpPort = 587;
            this.Mesaj = MailMesaji;
            this.Credential = new NetworkCredential("gmail adresinizi giriniz", sifre);
            this.Kimden = "gmail adresinizi giriniz";
        }


        public static void Gonder(Mail m)
        {
            MailMessage e_posta = new MailMessage();
            e_posta.From = new MailAddress(m.Kimden);
            e_posta.To.Add(m.Kime);
            e_posta.IsBodyHtml = true;
            e_posta.Subject = m.Konu;
            e_posta.Body = m.Mesaj;
            SmtpClient smtp = new SmtpClient();
            smtp.EnableSsl = true;
            smtp.Credentials = m.Credential;
            smtp.Port = m.SmtpPort;
            smtp.Host = m.Host;
            smtp.Send(e_posta);
        } 
    }
}
