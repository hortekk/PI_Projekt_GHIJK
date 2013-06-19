using System;
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
                p_KolicinaNaSkladistu = int.Parse(dr["KolicinaNaSkladistu"].ToString());
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
            set
            {
                if (p_KolicinaNaSkladistu != value) p_KolicinaNaSkladistu = value;
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

            sqlUpit = "INSERT INTO Artikl (idKategorijaArtikla, Naziv, KolicinaNaSkladistu, AlarmnaKolicina,CijenaProdaje) VALUES ('" + idKategorijeArtikla + "','" + Naziv + "','" + KolicinaNaSkladistu + "', '" + AlarmnaKolicina + "', '" + CijenaProdaje + "' )";


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
        public static List<Artikli> DohvatiArtikle()
        {
            List<Artikli> lista = new List<Artikli>();
            string sqlUpit = "SELECT * FROM Artikl";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikli dokument = new Artikli(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }

    
    }
    
}
