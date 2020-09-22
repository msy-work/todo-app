using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoGroupController : ControllerBase
    {
        // GET: api/<TodoGroupController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TodoGroupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodoGroupController>
        [HttpPost("{id}/{id}")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
