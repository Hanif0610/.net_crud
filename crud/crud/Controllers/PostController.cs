using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Model;
using crud.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crud.Controllers
{
    [Route("post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        [Authorize]
        public void Write([FromBody] PostRequestDto postRequestDto)
        {
            _postService.Write(postRequestDto);
        }
    }
}
