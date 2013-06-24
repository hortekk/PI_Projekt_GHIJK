using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Funkcije
{
    public class Metoda
    {

        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public Metoda()
        {
            
        }

        /// <summary>
        /// Funkcija za slanje maila preko @gmail.com
        /// </summary>
        /// <param name="sMaila">Mail adresa s koje šaljemo</param>
        /// <param name="passNas">Šifra mail s kojeg se šalje</param>
        /// <param name="naMail">Na mail kojem šaljemo</param>
        /// <param name="naslov">Naslov mail-a (tema)</param>
        /// <param name="tekst">Tekst koji želimo poslati</param>
        /// <param name="lokacijaPrilog">Lokacija datoteke koju želimo priložiti</param>
        public void SaljiMail(string sMaila, string passNas, string naMail, string naslov, string tekst, string lokacijaPrilog)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(sMaila);
            mail.To.Add(naMail);
            mail.Subject = naslov;
            mail.Body = tekst;

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(lokacijaPrilog);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sMaila, passNas);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }


        public static string Kodiraj(string ulaz)
        {
            MD5 kod = MD5.Create();
            byte[] podatak = kod.ComputeHash(Encoding.UTF8.GetBytes(ulaz));
            StringBuilder polje = new StringBuilder();
            for (int i = 0; i < podatak.Length; i++)
                polje.Append(podatak[i].ToString("x2"));

            return polje.ToString();
        }




    }
}
