using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoretellerLib;

namespace StoretellerTestsLib
{
    [TestClass]
    public class StorytellerTests
    {
        [TestMethod]
        public void TellStoryToYoungNotScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Alexander", 6, false);
            Assert.AreEqual($"Lyssna nu Alexander. Det var en gång en prinsessa som tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldNotScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Linda", 8, false);
            Assert.AreEqual($"Hallå Linda! En gång fanns en kille som tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Linda", 8, true);
            Assert.AreEqual($"Hallå Linda! En gång fanns en kille som egentligen var en varulv.", actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Peter", 4, true);
        }
    }
}
