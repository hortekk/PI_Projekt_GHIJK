using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Funkcije;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class MetodaTest
    {
        [TestMethod]
        public void TestMail()
        {
            //@foi.hr
            Metoda m1 = new Metoda();
            bool b1 = m1.ProvjeriMail("@foi.hr");
            double p1 = 0;
            if (b1 == true) p1 = 1;
            else p1 = 2;
            Assert.AreEqual(2, p1, "Krivi unos maila!");

            //marko.mario@@foi.hr
            Metoda m2 = new Metoda();
            bool b2 = m2.ProvjeriMail("marko.mario@@foi.hr");
            double p2 = 0;
            if (b2 == true) p2 = 1;
            else p2 = 2;
            Assert.AreEqual(2, p2, "Krivi unos maila!");

            //marko.mario@foi.hr9
            Metoda m3 = new Metoda();
            bool b3 = m3.ProvjeriMail("marko.mario@foi.hr9");
            double p3 = 0;
            if (b3 == true) p3 = 1;
            else p3 = 2;
            Assert.AreEqual(2, p3, "Krivi unos maila!");

            //marko.mario@foi..hr
            Metoda m4 = new Metoda();
            bool b4 = m4.ProvjeriMail("marko.mario@foi..hr");
            double p4 = 0;
            if (b4 == true) p4 = 1;
            else p4 = 2;
            Assert.AreEqual(2, p4, "Krivi unos maila!");

            //marko.mario*@foi.hr
            Metoda m5 = new Metoda();
            bool b5 = m5.ProvjeriMail("marko.mario*@foi.hr");
            double p5 = 0;
            if (b5 == true) p5 = 1;
            else p5 = 2;
            Assert.AreEqual(2, p5, "Krivi unos maila!");

            //marko#mario@foi.hr
            Metoda m6 = new Metoda();
            bool b6 = m6.ProvjeriMail("marko#mario@foi.hr");
            double p6 = 0;
            if (b6 == true) p6 = 1;
            else p6 = 2;
            Assert.AreEqual(2, p6, "Krivi unos maila!");
        }
    }
}
