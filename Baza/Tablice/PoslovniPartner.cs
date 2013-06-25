using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Baza
{
    public enum TipoviPP { Dobavljac = 0, Kupac = 1 }
    public class PoslovniPartner
    {

        private int p_idPP;
        private string p_ImeNaziv;
        private string p_PrezimeVrsta;
        private string p_Kontakt;
        private string p_Adresa;
        private int p_TipPP;
        private string p_email;


        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PoslovniPartner()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima o poslovnim partnerima
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o poslovnim partnerima</param>
        public PoslovniPartner(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idPP = int.Parse(dr["idPP"].ToString());
                p_ImeNaziv = dr["ImeNaziv"].ToString();
                p_PrezimeVrsta = dr["PrezimeVrsta"].ToString();
                p_Kontakt = dr["Kontakt"].ToString();
                p_Adresa = dr["Adresa"].ToString();
                p_TipPP = int.Parse(dr["TipPP"].ToString());
                p_email = dr["Email"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator poslovnog partnera
        /// </summary>
        public int idPP
        {
            get
            {
                return p_idPP;
            }
            private set
            {
                if (p_idPP != value) p_idPP = value;
            }
        }

        /// <summary>
        /// Ime/Naziv poslovnog partnera
        /// </summary>
        public string ImeNaziv
        {
            get
            {
                return p_ImeNaziv;
            }
            set
            {
                if (p_ImeNaziv != value) p_ImeNaziv = value;
            }
        }

        public string Email
        {
            get
            {
                return p_email;
            }
            set
            {
                if (p_email != value) p_email = value;
            }
        }
        /// <summary>
        /// Prezime/Vrsta poslovnog partnera
        /// </summary>
        public string PrezimeVrsta
        {
            get
            {
                return p_PrezimeVrsta;
            }
            set
            {
                if (p_PrezimeVrsta != value) p_PrezimeVrsta = value;
            }
        }

        /// <summary>
        /// Kontaktni podaci poslovnog partnera
        /// </summary>
        public string Kontakt
        {
            get
            {
                return p_Kontakt;
            }
            set
            {
                if (p_Kontakt != value) p_Kontakt = value;
            }
        }

        /// <summary>
        /// Adresa poslovnog partnera
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
        /// Vrsta poslovnog partnera
        /// </summary>
        public int TipPP
        {
            get
            {
                return p_TipPP;
            }
            set
            {
                if (p_TipPP != value) p_TipPP = value;
            }
        }


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idPP == 0)        //Insert
            {
                sqlUpit = "INSERT INTO PoslovniPartner (ImeNaziv, PrezimeVrsta, Kontakt, Adresa, TipPP, Email) VALUES ('" + ImeNaziv + "','" + PrezimeVrsta + "','" + Kontakt + "','" + Adresa + "','" + TipPP + "','" + Email + "')";
            }
            else   //Update
            {
                sqlUpit = "UPDATE PoslovniPartner SET ImeNaziv = '" + ImeNaziv
                + "', PrezimeVrsta = '" + PrezimeVrsta
                + "', Kontakt = '" + Kontakt
                + "', Adresa = '" + Adresa
                + "', TipPP = '" + TipPP
                + "', Email = '" + Email
               + "' WHERE idPP = " + idPP;
            }

            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM PoslovniPartner WHERE idPP = " + idPP;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve poslovne partnere iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Kompletna lista poslovni partnera</returns>
        public static List<PoslovniPartner> DohvatiSvePoslovnePartnere()
        {
            List<PoslovniPartner> lista = new List<PoslovniPartner>();
            string sqlUpit = "SELECT * FROM PoslovniPartner";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PoslovniPartner pp = new PoslovniPartner(dr);
                lista.Add(pp);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća pojedine poslovne partnere iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <param name="IdTip">ID poslovnog partnera (0 - Dobavljaci; 1 - Kupci)</param>
        /// <returns>Lista odabranih poslovnih partnera</returns>
        public static List<PoslovniPartner> DohvatiPoslovnePartnere(TipoviPP IdTip)
        {
            List<PoslovniPartner> lista = new List<PoslovniPartner>();
            string sqlUpit = "SELECT * FROM PoslovniPartner WHERE TipPP = " + ((int)IdTip).ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PoslovniPartner pp = new PoslovniPartner(dr);
                lista.Add(pp);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća poslovnog partnera iz baze prema ID
        /// </summary>
        /// <returns>Poslovni partner</returns>
        public static PoslovniPartner DohvatiPoslovnogPartneraPremaID(string ID, TipoviPP IdTip)
        {
            string sqlUpit = "SELECT * FROM PoslovniPartner WHERE TipPP = " + ((int)IdTip).ToString() + " AND idPP = " + ID;
            PoslovniPartner pp = new PoslovniPartner(Baza.Instance.DohvatiDataReader(sqlUpit));
            return pp;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Ime/Naziv i Prezime/Vrsta poslovnog partnera</returns>
        public override string ToString()
        {
            return ImeNaziv + " " + PrezimeVrsta;
        }


    }
}
