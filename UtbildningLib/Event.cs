using System;
using System.Collections.Generic;
using System.Linq;

namespace UtbildningLib
{
    public class Event
    {
        public Event()
        {
            Children = new List<Event>();
        }
        public string Name { get; set; }
        public bool IsSummary { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public List<Event> Children { get; set; }
        public double Hours {
            get
            {
                if (this.IsSummary)
                    return this.Children.Sum(child => child.Hours);
                return (this.To - this.From).TotalHours;
            }
        }
    }
}
