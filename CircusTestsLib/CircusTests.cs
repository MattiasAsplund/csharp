using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusLib;

namespace CircusTestsLib
{
    [TestClass]
    public class CircusTests
    {
        [TestMethod]
        public void TestToString()
        {
            // Arrange
            Cirkus sut = new Cirkus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansare = new Artist("Lindansaren Repo");
            sut.Anställ(clown);
            sut.Anställ(lindansare);
            sut.ArtistUppträdande(clown);
            sut.ArtistUppträdande(lindansare);
            sut.ArtistUppträdande(lindansare);
            var expected = "Cirkusen Elefanten har 2 artister. Clownen Surskratt har uppträtt 1 gång. Lindansaren Repo har uppträtt 2 gånger.";

            // Act
            string actual = sut.ToString();

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
