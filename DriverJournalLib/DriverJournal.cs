using System;
using System.Collections.Generic;
using System.Linq;

namespace DriverJournalLib
{
    public class DriverJournal
    {
        private List<Entry> entries = new List<Entry>();
        public decimal MilesDriven(int year, int month)
        {
            return entries
                .Where(entry => entry.Year == year && entry.Month == month)
                .Sum(entry => entry.Miles);
        }

        public void AddEntry(int year, int month, decimal miles, string description)
        {
            entries.Add(new Entry { Year = year, Month = month, Miles = miles, Description = description });
        }
    }
}
