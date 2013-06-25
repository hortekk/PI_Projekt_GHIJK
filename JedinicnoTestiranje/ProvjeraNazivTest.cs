using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skladiste_PI;
using Funkcije;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class ProvjeraNazivTest
    {
        [TestMethod]
        public void TestNaziv()
        {
            Provjera unos = new Provjera();
            bool b = unos.provjeriNaziv("");
            int p = 0;
            if (b == true) p = 1;
            else p = 2;
            Assert.AreEqual(2, p, "Krivi unos naziva!");
        }
    }
}
