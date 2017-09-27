using System.Collections.Generic;
using System.Linq;

namespace CarBuilderApp
{
    internal class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
        }

        public List<Part> Parts { get; internal set; } 
            = new List<Part>();
        public decimal Cost {
            get
            {
                return this.Parts.Sum(part => part.Cost) * 1.3M;
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}