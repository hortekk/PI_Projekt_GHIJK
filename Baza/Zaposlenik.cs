using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Baza
{
    public class Zaposlenik
    {

        private int p_idZaposlenika;
        private string p_Ime;
        private string p_Prezime;
        private string p_Email;
        private string p_BrojTelefona;
        private string p_Adresa;


        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public Zaposlenik()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima o zaposleniku
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o zaposlenicima</param>
        public Zaposlenik(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idZaposlenika = int.Parse(dr["idZaposlenika"].ToString());
                p_Ime = dr["Ime"].ToString();
                p_Prezime = dr["Prezime"].ToString();
                p_Email = dr["Email"].ToString();
                p_BrojTelefona = dr["BrojTelefona"].ToString();
                p_Adresa = dr["Adresa"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator zaposlenika
        /// </summary>
        public int idZaposlenika
        {
            get
            {
                return p_idZaposlenika;
            }
            private set
            {
                if (p_idZaposlenika != value) p_idZaposlenika = value;
            }
        }

        /// <summary>
        /// Ime zaposlenika
        /// </summary>
        public string Ime
        {
            get
            {
                return p_Ime;
            }
            set
            {
                if (p_Ime != value) p_Ime = value;
            }
        }

        /// <summary>
        /// Prezime zaposlenika
        /// </summary>
        public string Prezime
        {
            get
            {
                return p_Prezime;
            }
            set
            {
                if (p_Prezime != value) p_Prezime = value;
            }
        }

        /// <summary>
        /// Email zaposlenika
        /// </summary>
        public string Email
        {
            get
            {
                return p_Email;
            }
            set
            {
                if (p_Email != value) p_Email = value;
            }
        }

        /// <summary>
        /// Broj telefona zaposlenika
        /// </summary>
        public string BrojTelefona
        {
            get
            {
                return p_BrojTelefona;
            }
            set
            {
                if (p_BrojTelefona != value) p_BrojTelefona = value;
            }
        }

        /// <summary>
        /// Adresa zaposlenika
        /// </summary>
        public string Adresa
        {
            get
            {
                return p_Adresa;
            }
            set
            {
                if (p_Adresa != value) p_Adresa = value;
            }
        }




        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idZaposlenika == 0)        //Insert
            {
                sqlUpit = "INSERT INTO Zaposlenik (Ime, Prezime, Email, BrojTelefona, Adresa) VALUES ('" + Ime + "','" + Prezime + "','" + Email + "','" + BrojTelefona + "','" + Adresa + "')";
            }
            else   //Update
            {
                sqlUpit = "UPDATE Zaposlenik SET Ime = '" + Ime
                + "', Prezime = '" + Prezime
                + "', Email = '" + Email
                + "', BrojTelefona = '" + BrojTelefona
                + "', Adresa = '" + Adresa
               + "' WHERE idZaposlenika = " + idZaposlenika;
            }

            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Zaposlenik WHERE idZaposlenika = " + idZaposlenika;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Zaposlenik> DohvatiZaposlenike()
        {
            List<Zaposlenik> lista = new List<Zaposlenik>();
            string sqlUpit = "SELECT * FROM Zaposlenik";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zaposlenik zaposlenik = new Zaposlenik(dr);
                lista.Add(zaposlenik);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Ime i prezime zaposlenika</returns>
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }


    }
}
