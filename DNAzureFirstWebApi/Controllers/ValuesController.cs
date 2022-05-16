using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DNAzureFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };

        }
        //GET api/values/$
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
    }
}
