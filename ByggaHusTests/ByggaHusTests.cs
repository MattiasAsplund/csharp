using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ByggahusApp;

namespace ByggaHusTests
{
    [TestClass]
    public class ByggaHusTests
    {
        [TestMethod]
        public void ClosedWindows()
        {
            House aHouse = new House();
            Window window1 = new Window();
            Window window2 = new Window();
            Window window3 = new Window();
            Window window4 = new Window();
            Room room1 = new Room();
            Room room2 = new Room();
            Room room3 = new Room();
            Room room4 = new Room();
            room1.AddWindow(window1);
            room2.AddWindow(window2);
            room2.AddWindow(window3);
            room2.AddWindow(window4);
            aHouse.AddRoom(room1);
            aHouse.AddRoom(room2);
            aHouse.AddRoom(room3);
            aHouse.AddRoom(room4);
            window1.Open();
            Assert.AreEqual(3, aHouse.NumberOfClosedWindows);
        }
    }
}
