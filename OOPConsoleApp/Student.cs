using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    class Student
    {
        public string Name;
        public string Email;
        private int StudyHarderCounter = 0;
        public event EventHandler TooTired;
        public override string ToString()
        {
            return $"{this.Name} \n{this.Email}";
        }

        internal void StudyHarder()
        {
            StudyHarderCounter++;
            if (StudyHarderCounter > 2)
                TooTired?.Invoke(this, null);
            Name = "Super " + Name;
        }
    }

}
