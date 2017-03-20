using Microsoft.AspNetCore.Authorization;
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

    //[EnableQuery]

    
    public class ASController : ApiController
    {
        public class Api
        {
            public const string Version1 = "1.0";
            public const string Version2 = "2.0";
            public const string Version3 = "3.0";
        }
    }

    [Authorize]
    public class AuthController : ASController
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
