using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLib;

namespace EmployeeTestsLib
{
    [TestClass]
    public class EmployeeConverterTests
    {
        [TestMethod]
        public void Convert()
        {
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";
            var sut = new EmployeeConverter();
            string actual = sut.Convert(input);
            Assert.AreEqual("Asplund, Mattias (Lön: 35000,00 SEK) Telefon:070-6186120 Födelseår:1971", actual);
        }
    }
}
