using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Web.Http;

namespace AS
{
    //[HttpDelete]
    //[HttpGet]
    //[HttpHead]
    //[HttpOptions]
    //[HttpPatch]
    //[HttpPost]
    //[HttpPut]
    /// <summary>
    /// Default api template and not for all controller define defaul
    /// </summary>
    //[EnableQuery]
    [Route(Controller)]
    public class ASController : ApiController
    {
        public const string Action = "[action]";
        public const string Controller = "api/[controller]";

        /// <summary>
        /// Option to version of api service. Default thinking version 1.0 is existed.
        /// </summary>
        sealed class Api
        {
            public const string Version2 = "2.0";
            public const string Version3 = "3.0";
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
