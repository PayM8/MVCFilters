using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilters.Models
{
    public class Ticket
    {
        public string Id { get; set; }

        public double Amount { get; set; }

        public DateTime WhenPurchased { get; set; }

        public User Owner { get; set; }

        private User owner;

        public Ticket(User user)
        {
            owner = user;
        }
    }
}