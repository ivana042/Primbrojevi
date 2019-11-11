using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Pood
{
    [TestClass]
    public class TestPrimBrojeva
    {
        [TestMethod]
        public void GenerirajPrimBrojeveVraćaPrazanNizZaArgument0()
        {
            Assert.AreEqual(0, PrimBrojevi.GenerirajPrimBrojeve(0).Length);
        }

        [TestMethod]
        public void GenerirajPrimBrojeveVraćaPrazanNizZaArgument1()
        {
            Assert.AreEqual(0, PrimBrojevi.GenerirajPrimBrojeve(1).Length);
        }
        [TestMethod]
        public void GenerirajPrimBrojeveVraćaNizKojiSadržiSamo2ZaArgument2()
        {
            Assert.AreEqual(1, PrimBrojevi.GenerirajPrimBrojeve(2).Length);
            Assert.AreEqual(2, PrimBrojevi.GenerirajPrimBrojeve(2)[0]);
        }

        [TestMethod]
        public void GenerirajPrimBrojeveVraćaNizKojiSadrži25ProstihBrojevaZaArgument100()
        {
            Assert.AreEqual(25, PrimBrojevi.GenerirajPrimBrojeve(100).Length);
            Assert.AreEqual(2, PrimBrojevi.GenerirajPrimBrojeve(100)[0]);
            Assert.AreEqual(97, PrimBrojevi.GenerirajPrimBrojeve(100)[24]);
        }
    }
}
