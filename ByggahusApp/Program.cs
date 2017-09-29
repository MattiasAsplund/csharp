using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByggahusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            House aHouse = new House();
            Window window1 = new Window();
            Window window2 = new Window();
            Room room1 = new Room();
            Room room2 = new Room();
            room1.AddWindow(window1);
            room2.AddWindow(window2);
            aHouse.AddRoom(room1);
            aHouse.AddRoom(room2);
            window1.Open();
            int numberOfClosedWindows = aHouse.NumberOfClosedWindows;
            Console.WriteLine();
        }
    }
}
