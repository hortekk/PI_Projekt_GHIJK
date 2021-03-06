﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class Artikli {

        private int p_idArtikla;
        private int p_idKategorijeArtikla;
        private string p_Naziv;
        private int p_KolicinaNaSkladistu;
        private int p_AlarmnaKolicina;
        private int p_CijenaProdaje;


        public Artikli(){
                    
                        }
        public Artikli(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idArtikla = int.Parse(dr["idArtikla"].ToString());
                p_idKategorijeArtikla = int.Parse(dr["idKategorijaArtikla"].ToString());
                p_Naziv = dr["Naziv"].ToString();
                //p_KolicinaNaSkladistu = int.Parse(dr["KolicinaNaSkladistu"].ToString());
                try
                {
                    p_KolicinaNaSkladistu = int.Parse(DohvatiKolicinuPrijamnicaPremaID(p_idArtikla.ToString())) - int.Parse(DohvatiKolicinuOtpremnicaPremaID(p_idArtikla.ToString()));
                }
                catch (Exception)
                {
                    p_KolicinaNaSkladistu = 0;
                }
                p_AlarmnaKolicina = int.Parse(dr["AlarmnaKolicina"].ToString());
                p_CijenaProdaje = int.Parse(dr["CijenaProdaje"].ToString());


            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int idArtikla
        {
            get
            {
                return p_idArtikla;
            }
            private set
            {
                if (p_idArtikla != value) p_idArtikla = value;
            }
        }

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
        public string Naziv
        {
            get
            {
                return p_Naziv;
            }
            set
            {
                if (p_Naziv != value) p_Naziv = value;
            }
        }

        /// <summary>
        /// datum
        /// </summary>
        public int KolicinaNaSkladistu
        {
            get
            {
                return p_KolicinaNaSkladistu;
            }
        }

        /// <summary>
        /// tip dokumenta
        /// </summary>
        public int AlarmnaKolicina
        {
            get
            {
                return p_AlarmnaKolicina;
            }
            set
            {
                if (p_AlarmnaKolicina != value) p_AlarmnaKolicina = value;
            }
        }

        public int CijenaProdaje
        {
            get
            {
                return p_CijenaProdaje;
            }
            set
            {
                if (p_CijenaProdaje != value) p_CijenaProdaje = value;
            }
        }

        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (idArtikla == 0)        //Insert
            {
                sqlUpit = "INSERT INTO Artikl (idKategorijaArtikla, Naziv, AlarmnaKolicina,CijenaProdaje) VALUES ('" + idKategorijeArtikla + "','" + Naziv + "', '" + AlarmnaKolicina + "', '" + CijenaProdaje + "' )";
            }
            else   //Update
            {
                sqlUpit = "UPDATE Artikl SET idKategorijaArtikla = '" + idKategorijeArtikla
                + "', Naziv = '" + Naziv
                + "', AlarmnaKolicina = '" + AlarmnaKolicina
                + "', CijenaProdaje = '" + CijenaProdaje
               + "' WHERE idArtikla = " + idArtikla;
            }

            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Artikl WHERE idArtikla = " + idArtikla;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Artikli> DohvatiSveArtikle()
        {
            List<Artikli> lista = new List<Artikli>();
            string sqlUpit = "SELECT Artikl.idArtikla,Artikl.idKategorijaArtikla,Artikl.Naziv,Artikl.AlarmnaKolicina, Artikl.CijenaProdaje, Coalesce(Sum(StavkeDokumenta.Kolicina),0) AS KolicinaNaSkladistu FROM Artikl  LEFT OUTER JOIN  StavkeDokumenta ON StavkeDokumenta.idArti = Artikl.idArtikla Group by 1;";
            //string sqlUpit = "SELECT * FROM Artikl";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikli dokument = new Artikli(dr);
                //dr["KolicinaNaSkladistu"]="sa";

                //dokument.KolicinaNaSkladistu=
                //p_KolicinaNaSkladistu = int.Parse(dr["KolicinaNaSkladistu"].ToString());
                //p_AlarmnaKolicina = int.Parse(dr["AlarmnaKolicina"].ToString());
                //p_CijenaProdaje = int.Parse(dr["CijenaProdaje"].ToString());

                //dokument.Naziv=dr
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća zaposlenika iz baze prema ID
        /// </summary>
        /// <returns>Zaposlenik</returns>
        public static Artikli DohvatiArtiklePremaID(string ID)
        {
            string sqlUpit = "SELECT Artikl.idArtikla,Artikl.idKategorijaArtikla,Artikl.Naziv,Artikl.AlarmnaKolicina, Artikl.CijenaProdaje, Coalesce(Sum(StavkeDokumenta.Kolicina),0) AS KolicinaNaSkladistu FROM Artikl  LEFT OUTER JOIN  StavkeDokumenta ON StavkeDokumenta.idArti = Artikl.idArtikla Group by 1 HAVING Artikl.idArtikla = " + ID;
            Artikli a = new Artikli(Baza.Instance.DohvatiDataReader(sqlUpit));
            return a;
        }

        /// <summary>
        /// DohvatiKolicinuOtpremnicaPremaID
        /// </summary>
        /// <returns>Zaposlenik</returns>
        public static string DohvatiKolicinuOtpremnicaPremaID(string ID)
        {
            string sqlUpit = "Select Coalesce(Sum(StavkeDokumenta.Kolicina),0) AS KolicinaNaSkladistu  FROM StavkeDokumenta,Dokument,Artikl  where StavkeDokumenta.[idArti] = Artikl.[idArtikla] and Dokument.[TipDokumenta]=2 and StavkeDokumenta.[idDok]=Dokument.[idDokumenta] AND Artikl.[idArtikla] = " + ID;
            string a = Baza.Instance.DohvatiVrijednost(sqlUpit).ToString();
            return a;
        }

        /// <summary>
        /// DohvatiKolicinuPrijamnicaPremaID
        /// </summary>
        /// <returns>Zaposlenik</returns>
        public static string DohvatiKolicinuPrijamnicaPremaID(string ID)
        {
            string sqlUpit = "Select Coalesce(Sum(StavkeDokumenta.Kolicina),0) AS KolicinaNaSkladistu  FROM StavkeDokumenta,Dokument,Artikl  where StavkeDokumenta.[idArti] = Artikl.[idArtikla] and Dokument.[TipDokumenta]=1 and StavkeDokumenta.[idDok]=Dokument.[idDokumenta] AND Artikl.[idArtikla] = " + ID;
            string a = Baza.Instance.DohvatiVrijednost(sqlUpit).ToString();
            return a;
        }


        ///// <summary>
        ///// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        ///// </summary>
        ///// <returns>Lista zaposlenika</returns>
        //public static List<Artikli> DohvatiArtikle()
        //{
        //    List<Artikli> lista = new List<Artikli>();
        //    string sqlUpit = "SELECT Artikl.idArtikla,Artikl.idKategorijaArtikla,Artikl.Naziv,SUM(StavkeDokumenta.Kolicina) AS KolicinaNaSkladistu,Artikl.AlarmnaKolicina, Artikl.CijenaProdaje FROM Artikl,StavkeDokumenta WHERE StavkeDokumenta.idArti = Artikl.idArtikla Group by 1;";
        //    DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
        //    while (dr.Read())
        //    {
        //        Artikli dokument = new Artikli(dr);
        //        lista.Add(dokument);
        //    }
        //    dr.Close();
        //    return lista;
        //}

        /// <summary>
        /// Dohvaća sve artikle koji su na alarmni kolicini i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista artikala</returns>
        public static List<Artikli> DohvatiSveArtikleAlarm()
        {

            List<Artikli> lista = new List<Artikli>();
            List<Artikli> lA = Artikli.DohvatiSveArtikle();
            foreach(Artikli a in lA){
                if (a.KolicinaNaSkladistu < a.AlarmnaKolicina)
                {

                    lista.Add(a);

                }

            }

            //string sqlUpit = "SELECT Artikl.idArtikla,Artikl.idKategorijaArtikla,Artikl.Naziv,Artikl.AlarmnaKolicina, Artikl.CijenaProdaje, Coalesce(Sum(StavkeDokumenta.Kolicina),0) AS KolicinaNaSkladistu FROM Artikl  LEFT OUTER JOIN  StavkeDokumenta ON StavkeDokumenta.idArti = Artikl.idArtikla Group by 1  HAVING KolicinaNaSkladistu < Artikl.AlarmnaKolicina;";
            //DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            //while (dr.Read())
            //{
            //    Artikli dokument = new Artikli(dr);
            //    lista.Add(dokument);
            //}
            //dr.Close();
            return lista;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Ime i prezime zaposlenika</returns>
        public override string ToString()
        {
            return Naziv;
        }


    }
    
}
