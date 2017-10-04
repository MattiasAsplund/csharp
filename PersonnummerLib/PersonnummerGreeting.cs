using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnummerLib
{
    public class PersonnummerGreeting
    {
        private string first;
        private string last;
        private string personnummer;
        public string Greeting {
            get
            {
                var sexDigit = int.Parse(personnummer.Substring(9, 1));
                if(sexDigit % 2 == 1)
                    return $"God morgon herr {this.last}";
                return $"God morgon fröken {this.last}";
            }
        }

        public void EnterDetails(string first, string last, string personnummer)
        {
            this.first = first;
            this.last = last;
            this.personnummer = personnummer;
        }
    }
}
