using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;
using System.Collections.Generic;
using System.Diagnostics;

namespace PartTestsLib
{
    [TestClass]
    public class PartSystemTests
    {
        [TestMethod]
        public void TwoParts()
        {
            var sut = new PartSystem();
            var p1 = new Part("A", "1");
            var p2 = new Part("B", "2");
            var vd = new Accountability(p1, p2, "VD");
            var employer = new Accountability(p2, p1, "Arbetsgivare");
            sut.AddPart(p1);
            sut.AddPart(p2);
            sut.AddAccountability(vd);
            sut.AddAccountability(employer);
            int actual = sut.NumberOfParts;
            Assert.AreEqual(2, actual);
            actual = sut.NumberOfAccountabilites;
            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void ResponsibilitiesForGivenPart()
        {
            var sut = new PartSystem();
            var p1 = new Part("A", "1");
            var p2 = new Part("B", "2");
            var vd = new Accountability(p1, p2, "VD");
            var employer = new Accountability(p2, p1, "Arbetsgivare");
            sut.AddPart(p1);
            sut.AddPart(p2);
            sut.AddAccountability(vd);
            sut.AddAccountability(employer);
            List<Accountability> accountabilites = sut.ResponsibilitesByParty(p2);
            foreach (var acc in accountabilites)
            {
                Debug.WriteLine(acc.ToString());
            }
            Assert.AreEqual(1, accountabilites.Count);
        }
    }
}
