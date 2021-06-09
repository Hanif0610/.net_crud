using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {

        [HttpGet]
        public string index()
        {
            return "Hello, World!";
        }

        [HttpGet("world/{num}")]
        public string World(int num)
        {
            return "Hello, Wrold!" + num;
        }
    }
}