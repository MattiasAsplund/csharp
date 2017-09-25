using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessNumberLib;

namespace GuessNumberTestsLib
{
    [TestClass]
    public class GuessNumberTests
    {
        [TestMethod]
        public void NewGameReturnsCorrectFeedback()
        {
            var sut = new GuessNumber(42);
            Assert.AreEqual("Guess a number between 1 and 100.", sut.Feedback);
        }
        [TestMethod]
        public void CorrectlyGuess42InThreeTries()
        {
            var sut = new GuessNumber(42);
            sut.Guess(10);
            Assert.AreEqual("Guess higher.", sut.Feedback);
            sut.Guess(55);
            Assert.AreEqual("Guess lower.", sut.Feedback);
            sut.Guess(42);
            Assert.AreEqual($"You made it in {sut.Tries} tries.", sut.Feedback);
            Assert.IsTrue(sut.GameOver);
        }
    }
}
