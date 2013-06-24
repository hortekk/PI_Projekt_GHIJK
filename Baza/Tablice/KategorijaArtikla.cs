using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class KategorijaArtikla
    {

       
        private int p_idKategorijeArtikla;
        private string p_NazivKategorije;
        private string p_Opis;


        public KategorijaArtikla()
        {

        }
        public KategorijaArtikla(DbDataReader dr)
        {
            if (dr != null)
            {
                
                p_idKategorijeArtikla = int.Parse(dr["idKategorijeArtikla"].ToString());
                p_NazivKategorije = dr["NazivKategorije"].ToString();
                p_Opis = dr["Opis"].ToString();
                


            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
       

        /// <summary>
        /// Id ovl osobe
        /// </summary>
        public int idKategorijeArtikla
        {
            get
            {
                return p_idKategorijeArtikla;
            }
            set
            {
                if (p_idKategorijeArtikla != value) p_idKategorijeArtikla = value;
            }
        }

        /// <summary>
        /// id PP
        /// </summary>
        public string NazivKategorije
        {
            get
            {
                return p_NazivKategorije;
            }
            set
            {
                if (p_NazivKategorije != value) p_NazivKategorije = value;
            }
        }

        public string Opis
        {
            get
            {
                return p_Opis;
            }
            set
            {
                if (p_Opis != value) p_Opis = value;
            }
        }

       
       
        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
      
        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<KategorijaArtikla> DohvatiKategorijuArtikla()
        {
            List<KategorijaArtikla> lista = new List<KategorijaArtikla>();
            string sqlUpit = "SELECT idKategorijeArtikla,NazivKategorije,Opis FROM KategorijeArtikla; ";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KategorijaArtikla dokument = new KategorijaArtikla(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }


    }

}