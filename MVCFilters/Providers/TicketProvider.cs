using MVCFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilters.Providers
{
    public class TicketProvider : ITicketProvider
    {
        public Ticket Buy(double amount, User purchaser)
        {
            throw new NotImplementedException();
        }

        public Ticket GetTicketById(int id)
        {
            throw new NotImplementedException();
        }
    }
}