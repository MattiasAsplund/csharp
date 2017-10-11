using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtbildningLib;

namespace UtbildningTestsLib
{
    [TestClass]
    public class UtbildningTests
    {
        [TestMethod]
        public void SPO16()
        {
            var spo16 = new Event { Name="SPO16", From = DateTime.Now, To = DateTime.Now, IsSummary = true };
            var cs = new Event { Name = "SPO16", From = DateTime.Now, To = DateTime.Now, IsSummary = true };
            var day1 = new Event { Name = "Dag 1", From = new DateTime(2017, 1, 1, 9, 0, 0), To = new DateTime(2017, 1, 1, 15, 0, 0), IsSummary = false };
            var day2 = new Event { Name = "Dag 2", From = new DateTime(2017, 2, 1, 9, 0, 0), To = new DateTime(2017, 2, 1, 15, 0, 0), IsSummary = false };
            var day3 = new Event { Name = "Dag 3", From = new DateTime(2017, 3, 1, 9, 0, 0), To = new DateTime(2017, 3, 1, 15, 0, 0), IsSummary = false };
            cs.Children.Add(day1);
            cs.Children.Add(day2);
            cs.Children.Add(day3);
            spo16.Children.Add(cs);
            double actual = spo16.Hours;
            Assert.AreEqual(18, actual);
        }
    }
}
