using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Web.Http;

namespace AS
{
    /// <summary>
    /// Non auth controller
    /// </summary>
    public class ASController : ApiController
    {
        public const string Action = "[action]";
        public const string Controller = "[controller]";
    }

    /// <summary>
    /// Auth controller
    /// </summary>
    public class AuthController: ASController
    {

    }

    /// <summary>
    /// Action filter controller
    /// </summary>
    public class ActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
