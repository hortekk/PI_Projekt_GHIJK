using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class Otpremnica
    {

        private int p_idDokumenta;
        private int p_idOvlasteneOsobe;
        private int p_idPP;
        private string p_DatumIzdavanja;
        private string p_TipDokumenta;
      


        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public Otpremnica()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public Otpremnica(DbDataReader dr)
        {
            if (dr != null)
            {

              
                p_idDokumenta = int.Parse(dr["idDokumenta"].ToString());
                p_idOvlasteneOsobe = int.Parse(dr["idOvlasteneOsobe"].ToString());
                p_idPP = int.Parse(dr["idPP"].ToString()); 
                p_DatumIzdavanja = dr["DatumIzdavanja"].ToString();
                p_TipDokumenta = dr["TipDokumenta"].ToString();

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
        public int idOvlasteneOsobe
        {
            get
            {
                return p_idOvlasteneOsobe;
            }
            set
            {
                if (p_idOvlasteneOsobe != value) p_idOvlasteneOsobe = value;
            }
        }

        /// <summary>
        /// id PP
        /// </summary>
        public int idPP
        {
            get
            {
                return p_idPP;
            }
            set
            {
                if (p_idPP != value) p_idPP = value;
            }
        }

        /// <summary>
        /// datum
        /// </summary>
        public string DatumIzdavanja
        {
            get
            {
                return p_DatumIzdavanja;
            }
            set
            {
                if (p_DatumIzdavanja != value) p_DatumIzdavanja = value;
            }
        }

        /// <summary>
        /// tip dokumenta
        /// </summary>
        public string TipDokumenta
        {
            get
            {
                return p_TipDokumenta;
            }
            set
            {
                if (p_TipDokumenta != value) p_TipDokumenta = value;
            }
        }

      


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            sqlUpit = "INSERT INTO Dokument (idOvlasteneOsobe, idPP, DatumIzdavanja, TipDokumenta) VALUES ('" + idOvlasteneOsobe + "','" + idPP + "','" + DatumIzdavanja + "', 2 )";


            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Dokument WHERE idDokumenta = " + idDokumenta;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Otpremnica> DohvatiDokumente()
        {
            List<Otpremnica> lista = new List<Otpremnica>();
            string sqlUpit = "SELECT * FROM Dokument";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Otpremnica dokument = new Otpremnica(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }


       



        public int CurrentID()
        {
            string sqlUpit = "SELECT MAX(idDokumenta) FROM Dokument";
            return int.Parse(Baza.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }


    }

}
