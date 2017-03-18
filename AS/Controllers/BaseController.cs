using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Web.Http;

namespace AS
{
    /// <summary>
    /// Default api template and not for all controller define defaul
    /// </summary>
    //[EnableQuery]
    [ApiVersion(Api.Version2)]
    [Route(Controller)]
    public class ASController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new string[] { "V1", "value2" });
        } 

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public const string Action = "[action]";
        public const string Controller = "[controller]";

        /// <summary>
        /// Default existed version 1.0
        /// </summary>
        sealed class Api
        {
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
