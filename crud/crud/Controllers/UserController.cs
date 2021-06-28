using crud.Model;
using crud.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace crud.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService ??= userService;
        }

        [HttpPost("add")]
        public int AddUser([FromBody]AddUserDto addUserDto) => _userService.AddUser(addUserDto);

        [HttpGet]
        public List<UserResponseDto> UsertList() => _userService.UserList();

        [HttpGet("{id}")]
        public UserResponseDto UserInfo(int id) => _userService.UserInfo(id);
    }
}