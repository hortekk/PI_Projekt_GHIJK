using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class PregledPrijamnice
    {

        private int p_idDokumenta;
        private string p_DatumIzdavanja;
        private string p_ime;
        private string p_prezime;
        private string p_imenaziv;
        private string p_prezimevrsta;



        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PregledPrijamnice()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public PregledPrijamnice(DbDataReader dr)
        {
            if (dr != null)
            {
                p_ime = dr["Ime"].ToString();
                p_prezime = dr["Prezime"].ToString();
                p_imenaziv = dr["ImeNaziv"].ToString();
                p_prezimevrsta = dr["PrezimeVrsta"].ToString();
                p_idDokumenta = int.Parse(dr["idDokumenta"].ToString());
                p_DatumIzdavanja = dr["DatumIzdavanja"].ToString();
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

        /// <summary>
        /// datum
        /// </summary>
        public string DatumIzdavanja
        {
            get
            {
                return p_DatumIzdavanja;
            }
        }

        public string Ime
        {
            get
            {
                return p_ime;
            }
        }

        public string Prezime
        {
            get
            {
                return p_prezime;
            }
        }
        public string ImeNaziv
        {
            get
            {
                return p_imenaziv;
            }
        }
        public string PrezimeVrsta
        {
            get
            {
                return p_prezimevrsta;
            }
        }


        
        
        public static List<PregledPrijamnice> DohvatiOtpremnicu()
        {

            List<PregledPrijamnice> lista = new List<PregledPrijamnice>();
            string sqlUpit = "SELECT Dokument.idDokumenta, Dokument.idOvlasteneOsobe,Dokument.idPP, Dokument.TipDokumenta,Zaposlenik.Ime , Zaposlenik.Prezime, PoslovniPartner.ImeNaziv, PoslovniPartner.PrezimeVrsta,Dokument.DatumIzdavanja FROM Dokument,PoslovniPartner,Zaposlenik WHERE Dokument.idOvlasteneOsobe=Zaposlenik.idZaposlenika AND Dokument.idPP=PoslovniPartner.idPP AND Dokument.TipDokumenta=1";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {

                PregledPrijamnice dokument = new PregledPrijamnice(dr);

                lista.Add(dokument);

            }
            dr.Close();
            return lista;
        }


        /// <summary>
        /// Dohvaća pregled prijemnice prema idDokumenta
        /// </summary>
        /// <returns>Prijamnica</returns>
        public static List<PregledPrijamnice> DohvatiPrijamnicuPremaID(int idDokumenta)
        {
            List<PregledPrijamnice> lista = new List<PregledPrijamnice>();
            string sqlUpit = "SELECT Dokument.idDokumenta, Dokument.idOvlasteneOsobe,Dokument.idPP, Dokument.TipDokumenta,Zaposlenik.Ime , Zaposlenik.Prezime, PoslovniPartner.ImeNaziv, PoslovniPartner.PrezimeVrsta,Dokument.DatumIzdavanja FROM Dokument,PoslovniPartner,Zaposlenik WHERE Dokument.idOvlasteneOsobe=Zaposlenik.idZaposlenika AND Dokument.idPP=PoslovniPartner.idPP AND Dokument.TipDokumenta=1 AND Dokument.idDokumenta=" + idDokumenta.ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {

                PregledPrijamnice dokument = new PregledPrijamnice(dr);

                lista.Add(dokument);

            }
            dr.Close();
            return lista;
        }



    }

}

