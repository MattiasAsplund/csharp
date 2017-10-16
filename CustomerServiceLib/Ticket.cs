using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerServiceLib
{
    class Ticket
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool Offered { get; set; }
        public bool Resolved { get; set; }
        public bool Paid { get; set; }
        public decimal OfferedPrice { get; set; }
    }
}
