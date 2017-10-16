using System;
using System.Collections.Generic;
using System.Text;

namespace DriverJournalLib
{
    public class Entry
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Miles { get; set; }
        public string Description { get; set; }
    }
}
