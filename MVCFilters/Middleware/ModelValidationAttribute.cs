using MVCFilters.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MVCFilters.Middleware
{
    /// <summary>
    /// Attribute for model validation.
    /// </summary>
    public class ModelValidationAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Occurs before the action method is invoked.
        /// </summary>
        /// <param name="actionContext">The action context.</param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //early rejection of invalid models
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, actionContext.ModelState);
            }

            if (actionContext.ActionArguments.ContainsKey("arbitraryModel"))
            {
                var model = actionContext.ActionArguments.FirstOrDefault(x => x.Key == "arbitraryModel");
                actionContext.Validate((ArbitraryModel)model.Value);
            }

            if (actionContext.ActionArguments.ContainsKey("user"))
            {
                var model = actionContext.ActionArguments.FirstOrDefault(x => x.Key == "user");
                actionContext.Validate((User)model.Value);
            }

            if (actionContext.ActionArguments.ContainsKey("ticket"))
            {
                var model = actionContext.ActionArguments.FirstOrDefault(x => x.Key == "ticket");
                actionContext.Validate((Ticket)model.Value);
            }

            base.OnActionExecuting(actionContext);
        }


    }
}