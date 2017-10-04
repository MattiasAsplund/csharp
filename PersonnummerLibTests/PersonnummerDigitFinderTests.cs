using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnummerLib;

namespace PersonnummerLibTests
{
    [TestClass]
    public class PersonnummerDigitFinderTests
    {
        [TestMethod]
        public void Mattias()
        {
            var sut = new PersonnummerDigitFinder();
            sut.Process("710405785");
            var expected = "1";
            Assert.AreEqual(expected, sut.LastDigit);
        }
        [TestMethod]
        public void Jazmina()
        {
            var sut = new PersonnummerDigitFinder();
            sut.Process("711207922");
            var expected = "8";
            Assert.AreEqual(expected, sut.LastDigit);
        }
        [TestMethod]
        public void Gentrit()
        {
            var sut = new PersonnummerDigitFinder();
            sut.Process("810927889");
            var expected = "8";
            Assert.AreEqual(expected, sut.LastDigit);
        }
    }
}
