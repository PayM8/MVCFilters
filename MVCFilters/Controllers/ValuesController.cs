using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCFilters.Models;
using MVCFilters.Middleware;
using Microsoft.Practices.Unity;
using MVCFilters.Providers;


namespace MVCFilters.Controllers
{
    
    public class ValuesController : ApiController
    {
        /// <summary>
        /// (An Action that handles HTTP POST requests) executes some action operation.
        /// </summary>
        /// <param name="arbitraryModel">The arbitrary model.</param>
        /// <returns>
        /// An IHttpActionResult.
        /// </returns>
        [Route("api/test")]
        [HttpPost]
        [ModelValidationAttribute]
        public IHttpActionResult DoSomeAction([FromBody]ArbitraryModel arbitraryModel)
        {
            return Ok();
        }

        /// <summary>
        /// (An Action that handles HTTP POST requests) adds a user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        /// An IHttpActionResult.
        /// </returns>
        [Route("api/AddUser")]
        [HttpPost]
        [ModelValidationAttribute]
        public IHttpActionResult AddUser(User user)
        {
            return Ok();
        }

        /// <summary>
        /// (An Action that handles HTTP POST requests) adds a ticket.
        /// </summary>
        /// <param name="ticket">The ticket.</param>
        /// <returns>
        /// An IHttpActionResult.
        /// </returns>
        [Route("api/AddTicket")]
        [HttpPost]
        [ModelValidationAttribute]
        public IHttpActionResult AddTicket(Ticket ticket)
        {
            return Ok();
        }

    }
}
