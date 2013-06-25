using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skladiste_PI;
using Funkcije;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class ProvjeraKatTest
    {
        [TestMethod]
        public void TestKat()
        {
            Provjera unos = new Provjera();
            bool b = unos.provjeriKat(0);
            int p = 0;
            if (b == true) p = 1;
            else p = 2;
            Assert.AreEqual(2, p, "Krivi unos kategorije(nula)!");

            Provjera unos1 = new Provjera();
            bool b1 = unos1.provjeriKat(-2);
            int p1 = 0;
            if (b1 == true) p1 = 1;
            else p1 = 2;
            Assert.AreEqual(2, p1, "Krivi unos kategorije(negativna)!");
        }
    }
}
