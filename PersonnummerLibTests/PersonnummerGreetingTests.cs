using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnummerLib;

namespace PersonnummerLibTests
{
    [TestClass]
    public class PersonnummerGreetingTests
    {
        [TestMethod]
        public void Man()
        {
            var sut = new PersonnummerGreeting();
            var personnummer = "710405-7851";
            sut.EnterDetails("Mattias", "Asplund", personnummer);
            var expected = "God morgon herr Asplund";
            Assert.AreEqual(expected, sut.Greeting);            
        }
        [TestMethod]
        public void Kvinna()
        {
            var sut = new PersonnummerGreeting();
            var personnummer = "711207-9228";
            sut.EnterDetails("Jazmina", "Asplund", personnummer);
            var expected = "God morgon fröken Asplund";
            Assert.AreEqual(expected, sut.Greeting);
        }
    }
}
