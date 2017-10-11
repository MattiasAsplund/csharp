using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using SIEAccountLib;

namespace SIEImportTests
{
    [TestClass]
    public class SIEImportTester
    {
        [TestMethod]
        public void CanRead()
        {
            var accounts = new Dictionary<string, decimal>();
            var streamReader = File.OpenText(@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
            while (true)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                    break;
                string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
                var match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    var accountId = match.Groups[1].Value;
                    var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                    if (accounts.ContainsKey(accountId))
                        accounts[accountId] += amount;
                    else
                        accounts[accountId] = amount;
                }
            }
            foreach (var entry in accounts.OrderBy(e => e.Key))
                Debug.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");

            Debug.WriteLine(accounts.Sum(entry => entry.Value));
        }
    }
}
