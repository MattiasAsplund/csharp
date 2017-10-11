using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SIEAccountLib;
using System.Text.RegularExpressions;

namespace SIEImportTests
{
    [TestClass]
    public class RegexMatchCounterTests
    {
        [TestMethod]
        public void CountMatchingLines()
        {
            var contents = File.ReadAllText(@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
            RegexMatchCounter counter = new RegexMatchCounter();
            int rowCount = counter.CountMatchingLines(contents, "#VER");
            Assert.AreEqual(165, rowCount);
        }
        [TestMethod]
        public void CountMatchingLinesWithRegEx()
        {
            var contents = File.ReadAllText(@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
            string pattern = @"(^#VER.*$)";
            RegexOptions options = RegexOptions.Multiline;
            Regex regex = new Regex(pattern, options);
            var match = regex.Matches(contents);
            Assert.AreEqual(165, match.Count);
        }
    }
}
