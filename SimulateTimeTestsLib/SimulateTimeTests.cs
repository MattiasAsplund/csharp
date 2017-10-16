using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulateTimeLib;
using System.Diagnostics;

namespace SimulateTimeTestsLib
{
    [TestClass]
    public class SimulateTimeTests
    {
        [TestMethod]
        public void TenMinutes()
        {
            var fakeTimeProvider = new FakeTimeProvider();
            fakeTimeProvider.Now = new DateTime(2017, 1, 1);
            var sut = new Game(new RealTimeProvider(), 5);
            while (!sut.GameOver)
            {
                fakeTimeProvider.AddSeconds(1);
            }
        }
    }
}
