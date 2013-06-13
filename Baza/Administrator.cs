using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Baza
{
    public class Administrator
    {

        private int p_idAdmin;
        private int p_idZaposlenika;
        private string p_KorisnickoIme;
        private string p_Lozinka;
        private bool p_Admin;


        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public Administrator()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima o administratorima
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o administratorima</param>
        public Administrator(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idAdmin = int.Parse(dr["idAdmin"].ToString());
                p_idZaposlenika = int.Parse(dr["idZaposlenika"].ToString());
                p_KorisnickoIme = dr["KorisnickoIme"].ToString();
                p_Lozinka = dr["Lozinka"].ToString();
                p_Admin = bool.Parse(dr["Admin"].ToString());
            }

        }

        /// <summary>
        /// Jedinstveni identifikator administratora
        /// </summary>
        public int idAdmin
        {
            get
            {
                return p_idAdmin;
            }
            private set
            {
                if (p_idAdmin != value) p_idAdmin = value;
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
        /// Korisnicko ime zaposlenika
        /// </summary>
        public string KorisnickoIme
        {
            get
            {
                return p_KorisnickoIme;
            }
            set
            {
                if (p_KorisnickoIme != value) p_KorisnickoIme = value;
            }
        }

        /// <summary>
        /// Lozinka zaposlenika
        /// </summary>
        public string Lozinka
        {
            get
            {
                return p_Lozinka;
            }
            set
            {
                if (p_Lozinka != value) p_Lozinka = value;
            }
        }

        /// <summary>
        /// Korisnik posjeduje administatorska prava
        /// </summary>
        public bool Admin
        {
            get
            {
                return p_Admin;
            }
            set
            {
                if (p_Admin != value) p_Admin = value;
            }
        }



        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idAdmin == 0)        //Insert
            {
                sqlUpit = "INSERT INTO Administrator (idZaposlenika, KorisnickoIme, Lozinka, Admin) VALUES ('" + idZaposlenika + "','" + KorisnickoIme + "','" + Lozinka + "','" + Admin + "')";
            }
            else   //Update
            {
                sqlUpit = "UPDATE Administrator SET idZaposlenika = '" + idZaposlenika
                + "', KorisnickoIme = '" + KorisnickoIme
                + "', Lozinka = '" + Lozinka
                + "', Admin = '" + Admin
               + "' WHERE idAdmin = " + idAdmin;
            }

            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Administrator WHERE idAdmin = " + idAdmin;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve administratore iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista administratora</returns>
        public static List<Administrator> DohvatiAdministratore()
        {
            List<Administrator> lista = new List<Administrator>();
            string sqlUpit = "SELECT * FROM Administrator";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Administrator admin = new Administrator(dr);
                lista.Add(admin);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Korisnicko ime korisnika</returns>
        public override string ToString()
        {
            return KorisnickoIme;
        }


    }
}
