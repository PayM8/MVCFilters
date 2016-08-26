using MVCFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilters.Providers
{
    public interface ITicketProvider
    {
        Ticket Buy(double amount, User purchaser);

        Ticket GetTicketById(int id);

    }
}