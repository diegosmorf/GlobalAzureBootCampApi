using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GlobalAzureBootCampApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarWarsController : ControllerBase
    {
        private readonly string[] repository = new string[] { "Luke Skywalker",
                "C-3PO",
                "R2-D2",
                "Darth Vader",
                "Leia Organa",
                "Han Solo",
                "Obi-Wan Kenobi",
                "Yoda",
                "Rey",
                "Kylo Ren",
                "BB-8"
            };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return repository;
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public ActionResult<IEnumerable<string>> Get(string name)
        {
            return Ok(repository.Where(x => x.Contains(name)));
        }
    }
}
