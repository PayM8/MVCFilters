using MVCFilters.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;

namespace MVCFilters.Middleware
{
    /// <summary>
    /// A validation extensions.
    /// </summary>
    public static class ValidationExtensions
    {
        /// <summary>
        /// A HttpActionContext extension method that validates.
        /// </summary>
        /// <param name="context">The context to act on.</param>
        /// <param name="model">The model.</param>
        public static void Validate(this HttpActionContext context, ArbitraryModel model)
        {
            if (model.FutureDateOnly < DateTime.Today)
            {
                context.Response = context.Request.CreateErrorResponse(
            HttpStatusCode.BadRequest, "ArbitaryModel Date Must Always be in the future.");
            }
        }

        /// <summary>
        /// A HttpActionContext extension method that validates.
        /// </summary>
        /// <param name="context">The context to act on.</param>
        /// <param name="model">The model.</param>
        public static void Validate(this HttpActionContext context, User model)
        {
            if (model.Password == "unwantedPattern")
            {
                context.Response = context.Request.CreateErrorResponse(
            HttpStatusCode.BadRequest, "Password pattern in not acceptable here.");
            }
        }

        /// <summary>
        /// A HttpActionContext extension method that validates.
        /// </summary>
        /// <param name="context">The context to act on.</param>
        /// <param name="model">The model.</param>
        public static void Validate(this HttpActionContext context, Ticket model)
        {
            if (model.Amount < 5.3)
            {
                context.Response = context.Request.CreateErrorResponse(
            HttpStatusCode.BadRequest, "Ticket amount too little");
            }
        }
    }
}