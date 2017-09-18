using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarukorgLib
{
    public class Produkt
    {
        private string name;

        public Produkt(string name)
        {
            this.name = name;
        }

        public int Pris { get; set; }
    }
}
