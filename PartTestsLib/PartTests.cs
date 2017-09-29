using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;

namespace PartTestsLib
{
    [TestClass]
    public class PartTests
    {
        [TestMethod]
        public void CorrectToString()
        {
            var sut = new Part("Mattias Asplund",
                "19710405-7851");
            Assert.AreEqual("Mattias Asplund (19710405-7851)",
                sut.ToString());
        }
    }
}
