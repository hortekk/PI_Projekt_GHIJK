using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class PregledOtpremnicaStavke
    {

        private int p_idDokumenta;
        private int p_idOvlasteneOsobe;
        private int p_idartik;
        private string p_DatumIzdavanja;
        private string p_TipDokumenta;
        private string p_ime;
        private string p_prezime;
        private string p_imenaziv;
        private string p_prezimevrsta;
        private string p_imeartikla;
        private int p_idartikla;
        private int p_kol;
        private int p_iddokumenta;



        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PregledOtpremnicaStavke()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public PregledOtpremnicaStavke(DbDataReader dr)
        {
            if (dr != null)
            {

               
                p_idDokumenta= int.Parse(dr["idDokumenta"].ToString());
                p_imeartikla = dr["Naziv"].ToString();
                p_idartikla = int.Parse(dr["idArtikla"].ToString());
                p_kol = int.Parse(dr["Kolicina"].ToString());
                p_iddokumenta = int.Parse(dr["idDok"].ToString());
                p_idartik = int.Parse(dr["idArti"].ToString());

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

       
        public string NazivArtikla
        {
            get
            {
                return p_imeartikla;
            }
            set
            {
                if (p_imeartikla != value) p_imeartikla = value;
            }
        }

        public int idArtikla
        {
            get
            {
                return p_idartikla;
            }
            set
            {
                if (p_idartikla != value) p_idartikla = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return p_kol;
            }
            set
            {
                if (p_kol != value) p_kol = value;
            }
        }

        public int idArtik
        {
            get
            {
                return p_idartik;
            }
            set
            {
                if (p_idartik != value) p_idartik = value;
            }
        }
        public int iddokumenta
        {
            get
            {
                return p_iddokumenta;
            }
            set
            {
                if (p_iddokumenta != value) p_iddokumenta = value;
            }
        }
       




        



        public static List<PregledOtpremnicaStavke> DohvatiStavkeDokumenta(int idDokumenta)
        {
            List<PregledOtpremnicaStavke> lista2 = new List<PregledOtpremnicaStavke>();

            string sqlUpit = "SELECT Dokument.idDokumenta, Artikl.idArtikla, StavkeDokumenta.idDok,StavkeDokumenta.idArti, Artikl.Naziv,  StavkeDokumenta.Kolicina FROM Dokument, Artikl,StavkeDokumenta WHERE Artikl.idArtikla=StavkeDokumenta.idArti AND StavkeDokumenta.idDok = Dokument.idDokumenta AND StavkeDokumenta.idDok =" + idDokumenta.ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PregledOtpremnicaStavke dokument = new PregledOtpremnicaStavke(dr);
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
