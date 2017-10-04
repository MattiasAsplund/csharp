using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnummerLib
{
    public class PersonnummerDigitFinderSimple
    {
        private string firstNineCharsOfPersonalId;

        public string LastDigit {
            get
            {
                var total = 0;
                for (int pos = 0; pos < firstNineCharsOfPersonalId.Length; pos++)
                {
                    var digit = int.Parse(firstNineCharsOfPersonalId[pos].ToString());
                    if (pos % 2 == 0)
                    {
                        digit *= 2;
                        if (digit > 9)
                            digit -= 9;
                    }
                    total += digit;
                }
                var lastDigit = (10 - (total % 10)).ToString();
                return lastDigit;
            }
        }

        public void Process(string firstNineCharsOfPersonalId)
        {
            this.firstNineCharsOfPersonalId = firstNineCharsOfPersonalId;
        }
    }
}
