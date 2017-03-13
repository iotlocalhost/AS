using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace AS
{
    public class BaseController : ApiController
    {
        public const string Action = "[action]";
        public const string Controller = "[controller]";
    }

    public class AuthController: BaseController
    {

    }
}
