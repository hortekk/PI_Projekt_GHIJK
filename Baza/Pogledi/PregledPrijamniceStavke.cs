using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class PregledPrijamniceStavke
    {

        private int p_idDokumenta;
        private string p_imeartikla;
        private int p_idartikla;
        private int p_kol;


        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PregledPrijamniceStavke()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public PregledPrijamniceStavke(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idDokumenta = int.Parse(dr["idDokumenta"].ToString());
                p_imeartikla = dr["Naziv"].ToString();
                p_idartikla = int.Parse(dr["idArtikla"].ToString());
                p_kol = int.Parse(dr["Kolicina"].ToString());
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
        }


        public string NazivArtikla
        {
            get
            {
                return p_imeartikla;
            }
        }

        public int idArtikla
        {
            get
            {
                return p_idartikla;
            }
        }

        public int Kolicina
        {
            get
            {
                return p_kol;
            }
        }





        public static List<PregledPrijamniceStavke> DohvatiStavkeDokumenta(int idDokumenta)
        {
            List<PregledPrijamniceStavke> lista2 = new List<PregledPrijamniceStavke>();

            string sqlUpit = "SELECT Dokument.idDokumenta, Artikl.idArtikla, StavkeDokumenta.idDok,StavkeDokumenta.idArti, Artikl.Naziv,  StavkeDokumenta.Kolicina FROM Dokument, Artikl,StavkeDokumenta WHERE Artikl.idArtikla=StavkeDokumenta.idArti AND StavkeDokumenta.idDok = Dokument.idDokumenta AND StavkeDokumenta.idDok =" + idDokumenta.ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PregledPrijamniceStavke dokument = new PregledPrijamniceStavke(dr);
                lista2.Add(dokument);
            }
            dr.Close();
            return lista2;
        }


        public int CurrentID()
        {
            string sqlUpit = "SELECT MAX(idDokumenta) FROM Dokument";
            return int.Parse(Baza.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }


    }

}