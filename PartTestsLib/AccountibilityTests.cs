using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;

namespace PartTestsLib
{
    [TestClass]
    public class AccountibilityTests
    {
        [TestMethod]
        public void CorrectToString()
        {
            var mattiasAsplund = 
                new Part("Mattias Asplund", "19710405-7851");
            var someCompany = new Part("Mattias Asplund AB", "556599-5239");
            var sut = new Accountability(someCompany, mattiasAsplund, "VD");
            Assert.AreEqual("Mattias Asplund, VD på Mattias Asplund AB",
                sut.ToString());
        }
    }
}
