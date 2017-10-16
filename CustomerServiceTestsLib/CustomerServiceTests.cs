using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerServiceLib;
using System.Diagnostics;

namespace CustomerServiceTestsLib
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        public void CompleteFlow()
        {
            var sut = new CustomerService();
            var ticketId = sut.EnterTicket("test@test.com", "Testing", new DateTime(2017, 10, 1), "My coffee pot is malfunctioning");
            sut.MakeOffer(ticketId, 1000M);
            bool offerExists = false;
            do
            {
                offerExists = sut.OfferExists(ticketId);
            } while (!offerExists);
            Debug.WriteLine(sut.OfferedPrice(ticketId));
        }
    }
}
