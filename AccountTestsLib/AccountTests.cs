using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountLib;

namespace AccountTestsLib
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Sum()
        {
            Account assets = new Account("A", "Assets", 0, true);
            Account cars = new Account("1010", "Car fleet", 0, true);
            Account volvo = new Account("1030", "Volvo fleet", 50000000, false);
            Account tesla = new Account("1040", "Tesla fleet", 20000000, false);
            cars.Children.Add(volvo);
            cars.Children.Add(tesla);
            Account spacerockets = new Account("1020", "Rockets", 750000000, false);
            assets.Children.Add(cars);
            assets.Children.Add(spacerockets);
            Assert.AreEqual(assets.Amount, 820000000);
        }
    }
}
