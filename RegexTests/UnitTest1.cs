using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RegexTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konto()
        {
            string pattern = @"#KONTO (\d{4}) \""?([^\""]*)\""?";
            string input = @"#KONTO 1010 Patent";

            Match m = Regex.Match(input, pattern);
            Assert.AreEqual("1010", m.Groups[1].Value);
            Assert.AreEqual("Patent", m.Groups[2].Value);
        }
        [TestMethod]
        public void Verifikat()
        {
            string pattern = @"#VER . -?. (\d{8}) \""?([^\""]*)\""? (\d{8})";
            string input = @"#VER A 1 20150902 ""Utbetalningsjournal nr 136"" 20160122";
            Match m = Regex.Match(input, pattern);
            Assert.AreEqual("20150902", m.Groups[1].Value);
            Assert.AreEqual("Utbetalningsjournal nr 136", m.Groups[2].Value);
            Assert.AreEqual("20160122", m.Groups[3].Value);
        }
    }
}
