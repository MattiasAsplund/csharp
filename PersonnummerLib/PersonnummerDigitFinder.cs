using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnummerLib
{
    public class PersonnummerDigitFinder
    {
        private string firstNine;

        public string LastDigit {
            get
            {
                var digits = firstNine
                    .Select(ch => new
                    {
                        Digit = int.Parse(ch.ToString())
                    })
                    .Aggregate(new { Even = true, RunningTotal = 0 },
                        ((aggDigit, digit) =>
                        {
                            return new
                            {
                                Even = !aggDigit.Even,
                                RunningTotal = aggDigit.RunningTotal
                                    + GetDigitSum(aggDigit.Even, digit.Digit)

                            };
                        })).RunningTotal;
                return (10 - (digits % 10)).ToString();
            }
        }

        private int GetDigitSum(bool even, int digit)
        {
            var digitSum = digit;
            if (even)
                digitSum = 2 * digit;
            if (digitSum > 9)
                digitSum -= 9;
            return digitSum;
        }

        public void Process(string firstNine)
        {
            this.firstNine = firstNine;
        }
    }
}
