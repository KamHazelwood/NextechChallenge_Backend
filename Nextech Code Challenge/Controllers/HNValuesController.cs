using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nextech_Code_Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // input each api http request
    public class HackerValuesController : ControllerBase
    {
        // Create GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // Create GET api
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // Create POST api
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //Create  PUT api
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        //Create DELETE api
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
