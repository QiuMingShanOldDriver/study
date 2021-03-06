﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore2._2.Filter;

namespace AspNetCore2._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[ResourceFilter]
        //[ActionFilter]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {           
            return new string[] { "AspNetCore2.2", "Port:5000" };           
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("health")]
        public ActionResult Health()
        {
            return new OkResult();
        }
    }
}
