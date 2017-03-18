using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Web.Http;

namespace AS
{
    /// <summary>
    /// Non auth controller
    /// </summary>
    //[EnableQuery]
    [ApiVersion(ApiVers.Version1)]
    [ApiVersion(ApiVers.Version2, Deprecated = true)]
    [Route(Controller)]
    public class ASController : ApiController
    {
        public const string Action = "[action]";
        public const string Controller = "[controller]";

        public class ApiVers
        {
            public const string Version1 = "1.0";
            public const string Version2 = "2.0";

        }
    }

    public class AuthController: ASController
    {

    }

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
