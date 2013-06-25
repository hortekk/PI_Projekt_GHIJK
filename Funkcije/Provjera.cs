using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funkcije
{
    public class Provjera
    {
        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public Provjera() 
        { 
        
        }
        public bool provjeriNaziv(string Naziv)
        {
            if (Naziv.Length <= 0) return false;
            else return true;
        }
        public bool provjeriCijenu(int Cijena)
        {
            if (Cijena <= 0) return false;
            else return true;
        }
        public bool provjeriAlarmKol(int AlarmKol)
        {
            if (AlarmKol <= 0) return false;
            else return true;
        }
        public bool provjeriKat(int Kat)
        {
            if (Kat <= 0) return false;
            else return true;
        }

    }
}
