using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerServiceLib
{
    public class CustomerService
    {
        private List<Ticket> tickets = new List<Ticket>();
        private List<Offer> offers = new List<Offer>();
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

        public Offer Offer(Guid ticketId)
        {
            var offer = offers.FirstOrDefault(x => x.Ticket.Id == ticketId);
            if (offer != null)
                return offer;
            throw new InvalidOperationException("Can't view offer!");
        }

        public Invoice Invoice(string email)
        {
            return new Invoice { Email = email, Total = 
                offers
                .Where(o => o.Ticket.Email == email && o.Accepted)
                .Sum(o => o.Price) };
        }

        public void ResolveTicket(Guid ticketId)
        {
            var ticket = tickets.SingleOrDefault(t => t.Id == ticketId);
            ticket.Resolved = true;
        }

        public bool OfferExists(Guid ticketId)
        {
            return offers.Any(offer => offer.Ticket.Id == ticketId);
        }

        public void MakeOffer(Guid ticketId, string name, decimal amount)
        {
            var ticket = tickets.SingleOrDefault(t => t.Id == ticketId);
            var offer = new Offer { Ticket = ticket, Salesperson = name, Price = amount };
            offers.Add(offer);
        }
    }
}
