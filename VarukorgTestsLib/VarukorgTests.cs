using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarukorgLib;

namespace VarukorgTestsLib
{
    [TestClass]
    public class VarukorgTests
    {
        [TestMethod]
        public void Orderbekräftelse()
        {
            // Arrange
            Kund testKund = new Kund("Test", "Testsson");
            Produkt testLaptop = new Produkt("Laptop test");
            testLaptop.Pris = 4000;
            Produkt testSkärm = new Produkt("Skärm test");
            testSkärm.Pris = 1500;
            Varukorg sut = new Varukorg();
            sut.Kund = testKund;
            sut.LäggTillProdukt(testLaptop);
            sut.LäggTillProdukt(testSkärm);
            var expected = "Test Testsson har beställt varor för 5500 kr";

            // Act
            sut.Beställ();
            Orderbekräftelse result = sut.Orderbekräftelse;
            string actual = result.Meddelande;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
