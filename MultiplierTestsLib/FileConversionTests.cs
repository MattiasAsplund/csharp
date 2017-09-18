using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace MultiplierTestsLib
{
    [TestClass]
    public class FileConversionTests
    {
        [TestMethod]
        public void mattias_asplund_1971()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("mattias;asplund;1971");
            Assert.AreEqual("MATTIAS ASPLUND ÄR 46 ÅR GAMMAL.", actual);
        }
        [TestMethod]
        public void amanda_asplund_2003()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("amanda;asplund;2003");
            Assert.AreEqual("AMANDA ASPLUND ÄR 14 ÅR GAMMAL.", actual);
        }
        [TestMethod]
        public void TransformFile()
        {
            NullFileProvider nullFile = new NullFileProvider();
            File.WriteAllText("before.txt", "mattias;asplund;1971\namanda;asplund;2003\n");
            File.WriteAllText("after.txt", "MATTIAS ASPLUND ÄR 46 ÅR GAMMAL.\nAMANDA ASPLUND ÄR 14 ÅR GAMMAL.\n");
            var sut = new FileConverter();
            sut.TransformFile("before.txt", "actual.txt");
            string expected = File.ReadAllText("after.txt");
            string actual = File.ReadAllText("actual.txt");
            Assert.AreEqual(expected, actual);
        }
    }
}
