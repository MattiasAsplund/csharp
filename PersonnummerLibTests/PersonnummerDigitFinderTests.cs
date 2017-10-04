using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnummerLib;

namespace PersonnummerLibTests
{
    [TestClass]
    public class PersonnummerDigitFinderTests
    {
        [TestMethod]
        public void MattiasSimple()
        {
            var sut = new PersonnummerDigitFinderSimple();
            sut.Process("710405785");
            var expected = "1";
            Assert.AreEqual(expected, sut.LastDigit);
        }
        [TestMethod]
        public void JazminaSimple()
        {
            var sut = new PersonnummerDigitFinderSimple();
            sut.Process("711207922");
            var expected = "8";
            Assert.AreEqual(expected, sut.LastDigit);
        }

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
        [TestMethod]
        public void Moses()
        {
            var sut = new PersonnummerDigitFinder();
            sut.Process("930604293");
            var expected = "9";
            Assert.AreEqual(expected, sut.LastDigit);
        }
    }
}
