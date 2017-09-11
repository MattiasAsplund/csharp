using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class FileConverter
    {
        public string Transform(string row)
        {
            string[] tokens = row.Split(';');
            var firstName = tokens[0].ToUpper();
            var lastName = tokens[1].ToUpper();
            var years = DateTime.Now.Year - int.Parse(tokens[2]);
            var message = $"{firstName} {lastName} ÄR {years} ÅR GAMMAL.";
            return message;
        }
        public void TransformFile(string inputName, string outputName)
        {
            StreamWriter sw = new StreamWriter(File.Create(outputName), 
                Encoding.GetEncoding("iso-8859-1"));
            string[] lines = File.ReadAllLines(inputName);
            foreach (var line in lines)
            {
                sw.WriteLine(Transform(line));
            }
            sw.Close();
            File.WriteAllText(outputName, sw.ToString());
        }
    }
}
