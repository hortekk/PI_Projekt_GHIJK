using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Baza
{
    public class TipPP
    {

        private int p_idTipPP;
        private string p_NazivPP;

        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public TipPP()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima o poslovnim partnerima
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o tipovima poslovni partnera</param>
        public TipPP(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idTipPP = int.Parse(dr["idTipPP"].ToString());
                p_NazivPP = dr["NazivPP"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator poslovnog partnera
        /// </summary>
        public int idTipPP
        {
            get
            {
                return p_idTipPP;
            }
            private set
            {
                if (p_idTipPP != value) p_idTipPP = value;
            }
        }

        /// <summary>
        /// Naziv tipa poslovnog partnera
        /// </summary>
        public string NazivPP
        {
            get
            {
                return p_NazivPP;
            }
            set
            {
                if (p_NazivPP != value) p_NazivPP = value;
            }
        }


        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idTipPP == 0)        //Insert
            {
                sqlUpit = "INSERT INTO TipPP (NazivPP) VALUES ('" + NazivPP + "')";
            }
            else   //Update
            {
                sqlUpit = "UPDATE TipPP SET NazivPP = '" + NazivPP
               + "' WHERE idTipPP = " + idTipPP;
            }

            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM TipPP WHERE idTipPP = " + idTipPP;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve podatke iz dotične tablice i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista tipova poslovni partnera</returns>
        public static List<TipPP> DohvatiTipovePoslovniPartnera()
        {
            List<TipPP> lista = new List<TipPP>();
            string sqlUpit = "SELECT * FROM TipPP";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                TipPP tPP = new TipPP(dr);
                lista.Add(tPP);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Naziv tipa poslovnog partnera</returns>
        public override string ToString()
        {
            return NazivPP;
        }


    }
}
