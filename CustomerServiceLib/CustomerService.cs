using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerServiceLib
{
    public class CustomerService
    {
        private List<Ticket> tickets = new List<Ticket>();

        public Guid EnterTicket(string email, string name, DateTime dateTime, string description)
        {
            var id = Guid.NewGuid();
            tickets.Add(new Ticket
            {
                Id = id,
                Email = email,
                Name = name,
                CreatedAt = dateTime,
                Description = description,
                Offered = false,
                Resolved = false,
                Paid = false          
            });
            return id;
        }

        public decimal OfferedPrice(Guid ticketId)
        {
            var ticket = tickets.SingleOrDefault(t => t.Id == ticketId);
            if (ticket.Offered)
                return ticket.OfferedPrice;
            throw new InvalidOperationException("Can't view offer!");
        }

        public bool OfferExists(Guid ticketId)
        {
            var ticket = tickets.SingleOrDefault(t => t.Id == ticketId);
            return ticket.Offered;
        }

        public void MakeOffer(Guid ticketId, decimal amount)
        {
            var ticket = tickets.SingleOrDefault(t => t.Id == ticketId);
            ticket.Offered = true;
            ticket.OfferedPrice = amount;
        }
    }
}
