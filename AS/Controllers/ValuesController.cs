using Microsoft.AspNetCore.Mvc;

namespace AS
{
    [ApiVersion(Api.Version1)]
    [ApiVersion(Api.Version2)]
    [ApiVersion(Api.Version3)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ValuesController : ASController
    {
        [HttpGet]
        public IActionResult GetV1()
        {
            return this.Ok(new string[] { "V1", "values" });
        }

        [HttpGet, MapToApiVersion(Api.Version1)]
        public IActionResult GetV2()
        {
            return this.Ok(new string[] { Api.Version2, "values" });
        }

        // GET api/values
        [HttpGet, MapToApiVersion(Api.Version3)]
        public IActionResult GetV3()
        {
            return this.Ok(new string[] { Api.Version3, "values" });
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
    }
}
