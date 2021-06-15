using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly HelloService _helloService;

        public HelloController(HelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public string index()
        {
            return _helloService.getHello();
        }

        [HttpGet("world/{num}")]
        public string World(int num)
        {
            return "Hello, Wrold!" + num;
        }
    }
}