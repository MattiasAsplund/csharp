using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeLib
{
    public class EmployeeConverter
    {
        public string Convert(string input)
        {
            string pattern = @"\""(\w+) (\w+)\"" (\d{1,3}) (\d*.\d*) (.*)";
            Match match = Regex.Match(input, pattern);
            var amount = decimal.Parse(match.Groups[4].Value, CultureInfo.InvariantCulture);
            var amountAsString = amount.ToString("F", CultureInfo.InvariantCulture);
            var age = int.Parse(match.Groups[3].Value);
            var phone = match.Groups[5].Value;
            var year = DateTime.Now.AddYears(-age).Year;
            return $"{match.Groups[2].Value}, {match.Groups[1].Value} (Lön: {amount} SEK) Telefon:{phone} Födelseår:{year}";
        }
    }
}
