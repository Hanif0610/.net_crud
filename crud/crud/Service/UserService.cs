using crud.Entity;
using crud.Middleware;
using crud.Model;
using crud.Util;
using System.Collections.Generic;
using System.Linq;

namespace crud.Service
{
    public interface IUserService
    {
        int AddUser(AddUserDto addUserDto);
        TokenResponseDto Login(LoginRequestDto loginRequestDto);
        List<UserResponseDto> UserList();
        UserResponseDto UserInfo(int id);
        void UpdateUser(int id, AddUserDto addUserDto);
        void DeleteUser(int id);
        User GetById(int id);
    }

    public class UserService : IUserService
    {
        private readonly IJwtService _jwtService;

        private int cnt = 1;
        private List<User> users = new List<User>();

        public UserService(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        public int AddUser(AddUserDto addUserDto)
        {
            users.Add(new User(cnt, addUserDto.name, addUserDto.age, addUserDto.email, addUserDto.password));
            return cnt++;
        }

        public TokenResponseDto Login(LoginRequestDto loginRequestDto)
        {
            User user = users.Find(x => x.email == loginRequestDto.email);
            if(user == null)
            {

            }

            if(user.password != loginRequestDto.password)
            {

            }

            return TokenResponse(user.id);
        }

        public List<UserResponseDto> UserList()
        {
            List<UserResponseDto> userList = new List<UserResponseDto>();
            foreach(User user in users)
            {
                userList.Add(new UserResponseDto().Builder().Id(user.id).Name(user.name).Age(user.age).Email(user.email).Build());
            }
            return userList;
        }

        public UserResponseDto UserInfo(int id)
        {
            User user = users.Find(x => x.id == id);
            if (user == null)
            {
                throw new KeyNotFoundException("User Not Found.");
            }
            return new UserResponseDto().Builder().Id(user.id).Name(user.name).Age(user.age).Email(user.email).Build();
        }

        public void UpdateUser(int id, AddUserDto addUserDto)
        {
            if(users.Find(x => x.id == id) == null)
            {
                throw new KeyNotFoundException("User Not Found.");
            }
            users[id - 1].name = addUserDto.name;
            users[id - 1].age = addUserDto.age;
            users[id - 1].email = addUserDto.email;
            users[id - 1].password = addUserDto.password;
        }

        public void DeleteUser(int id)
        {
            if (users.Find(x => x.id == id) == null)
            {
                throw new KeyNotFoundException("User Not Found.");
            }
            users.RemoveAt(id - 1);
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(x => x.id == id);
        }

        private TokenResponseDto TokenResponse(int accountId) =>
            new TokenResponseDto().Builder().AccessToken(_jwtService.GenerateJwtToken(accountId)).TokenType("Bearer").Build();
    }
}
