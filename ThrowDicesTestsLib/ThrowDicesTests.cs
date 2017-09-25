using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThrowDicesLib;
using System.Diagnostics;

namespace ThrowDicesTestsLib
{
    [TestClass]
    public class ThrowDicesTests
    {
        [TestMethod]
        public void Throws_Seven_Wins()
        {
            Random random = new Random();
            var sut = new Game(random);
            while (!sut.IsWinner)
            {
                sut.ThrowDices();
                Debug.WriteLine(sut.ToString());
            }
            Debug.WriteLine($"Won after {sut.ThrowsMade} throws.");
            Assert.AreEqual(7, sut.NumberOfPoints);
        }
    }
}
