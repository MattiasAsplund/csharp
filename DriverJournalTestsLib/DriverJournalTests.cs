using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DriverJournalLib;

namespace DriverJournalTestsLib
{
    [TestClass]
    public class DriverJournalTests
    {
        [TestMethod]
        public void MonthlyStatistics()
        {
            var sut = new DriverJournal();
            sut.AddEntry(2017, 8, 10M, "Fraktade lastpallar till Testbolaget AB");
            sut.AddEntry(2017, 9, 10M, "Fraktade lastpallar till Testbolaget AB");
            sut.AddEntry(2017, 9, 22M, "Hämtade lösgodis");
            sut.AddEntry(2017, 10, 22M, "Hämtade lösgodis");
            decimal milesDriven = sut.MilesDriven(2017, 9);
            Assert.AreEqual(32M, milesDriven);
        }
    }
}
