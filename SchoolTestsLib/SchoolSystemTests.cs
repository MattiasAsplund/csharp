using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTestsLib
{
    [TestClass]
    public class SchoolSystemTests
    {
        [TestMethod]
        public void Count()
        {
            // Arrange
            var sut = new SchoolSystem();
            // Act
            sut.AddClass("SPO16", 20);
            sut.AddClass("CLOUD16", 30);
            sut.AddClass("SPO16", 10);
            // Assert
            Assert.AreEqual(2, sut.ClassCount);
            Assert.AreEqual(60, sut.StudentCount);
        }
    }
}
