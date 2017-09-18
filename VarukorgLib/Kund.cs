using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarukorgLib
{
    public class Kund
    {
        public string FirstName;
        public string LastName;
        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public Kund(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
