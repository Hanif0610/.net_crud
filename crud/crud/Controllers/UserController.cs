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
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public int AddUser([FromBody] AddUserDto addUserDto) => _userService.AddUser(addUserDto);

        [HttpPost("login")]
        public TokenResponseDto Login([FromBody] LoginRequestDto loginRequestDto) => _userService.Login(loginRequestDto);

        [HttpGet]
        public List<UserResponseDto> UsertList() => _userService.UserList();

        [HttpGet("{id}")]
        public UserResponseDto UserInfo(int id) => _userService.UserInfo(id);

        [HttpPut("{id}")]
        public void UpdateUser(int id, [FromBody] AddUserDto addUserDto) => _userService.UpdateUser(id, addUserDto);

        [HttpDelete("{id}")]
        public void DeleteUser(int id) => _userService.DeleteUser(id);
    }
}