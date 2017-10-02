using System;
using System.Collections.Generic;
using System.Linq;

namespace ByggahusApp
{
    public class House
    {
        private List<Room> Rooms = new List<Room>();
        public int NumberOfClosedWindows
        {
            get
            {
                int numberOfClosedWindows = 0;
                foreach (var room in Rooms)
                {
                    numberOfClosedWindows += room.NumberOfClosedWindows;
                }
                return numberOfClosedWindows;
            }
        }

        public void AddRoom(Room room1)
        {
            Rooms.Add(room1);
        }
    }
}