using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerServiceLib
{
    public class Offer
    {
        public Ticket Ticket { get; set; }
        public string Salesperson { get; set; }
        public decimal Price { get; set; }
        public bool Accepted { get; set; }

        public void Accept()
        {
            Accepted = true;
        }
    }
}
