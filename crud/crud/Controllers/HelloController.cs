using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Model;
using crud.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IHelloService _helloService;

        public HelloController(IHelloService helloService)
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
            return _helloService.getHelloParam(num);
        }

        [HttpPost]
        public string PostTest([FromBody]HelloDto helloDto)
        {
            return _helloService.postTest(helloDto);
        }
    }
}