using Microsoft.AspNetCore.Mvc;

namespace AS
{
    [Route(Controller)]
    public class ValuesController : ASController
    {
        
        // GET api/values
        [HttpGet()]
        public IActionResult Get()
        {
            return this.Ok(new string[] { "value1", "value2" });
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
