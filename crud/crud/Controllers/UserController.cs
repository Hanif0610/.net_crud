using crud.Model;
using crud.Service;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public int AddUser([FromBody]AddUserDto addUserDto) => _userService.AddUser(addUserDto);
    }
}