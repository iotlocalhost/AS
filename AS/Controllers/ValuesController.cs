using Microsoft.AspNetCore.Mvc;

namespace AS
{
    [ApiVersion(Api.Version2)]
    [ApiVersion(Api.Version3)]
    public class ValuesController : ASController
    {
        // GET api/values
        [HttpGet]
        public IActionResult GetV1()
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
    }
}
