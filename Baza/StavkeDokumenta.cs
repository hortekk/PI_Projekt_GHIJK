using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class StavkeDokumenta
    {
     

        private int p_idDokumenta;
        private int p_idArtikla;
        private int p_Kolicina;
        



        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public StavkeDokumenta()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public StavkeDokumenta(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idDokumenta = int.Parse(dr["idDok"].ToString());
                p_idArtikla = int.Parse(dr["idArti"].ToString());
                p_Kolicina = int.Parse(dr["Kolicina"].ToString()); 
                

            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int idDokumenta
        {
            get
            {
                return p_idDokumenta;
            }
            set
            {
                if (p_idDokumenta != value) p_idDokumenta = value;
            }
        }

        /// <summary>
        /// Id ovl osobe
        /// </summary>
        public int idArtikla
        {
            get
            {
                return p_idArtikla;
            }
            set
            {
                if (p_idArtikla != value) p_idArtikla = value;
            }
        }

        /// <summary>
        /// id PP
        /// </summary>
        public int Kolicina
        {
            get
            {
                return p_Kolicina;
            }
            set
            {
                if (p_Kolicina != value) p_Kolicina = value;
            }
        }

       

        



        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            sqlUpit = "INSERT INTO StavkeDokumenta (idDok, idArti, Kolicina) VALUES ('" + idDokumenta + "','" + idArtikla + "','" + Kolicina + "')";


            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM StavkeDokumenta WHERE idDok = " + idDokumenta;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<StavkeDokumenta> DohvatiStavke()
        {
            List<StavkeDokumenta> lista = new List<StavkeDokumenta>();
            string sqlUpit = "SELECT * FROM StavkeDokumenta";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                StavkeDokumenta stavke = new StavkeDokumenta(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public static List<StavkeDokumenta> DohvatiStavke(int idDokumenta)
        {
            List<StavkeDokumenta> lista = new List<StavkeDokumenta>();
            string sqlUpit = "SELECT * FROM StavkeDokumenta WHERE idDok = " + idDokumenta.ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                StavkeDokumenta stavke = new StavkeDokumenta(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }





    }
}
