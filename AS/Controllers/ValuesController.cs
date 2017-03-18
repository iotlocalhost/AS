using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AS
{
    public class ValuesController : ASController
    {
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new string[] { "V1", "value2" });
        }

        // GET api/values
        [HttpGet, MapToApiVersion(ApiVers.Version2)]
        public IActionResult GetV2()
        {
            return this.Ok(new string[] { "V2", "value2" });
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
