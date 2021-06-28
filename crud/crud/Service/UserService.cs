using crud.Entity;
using crud.Model;
using System.Collections.Generic;

namespace crud.Service
{
    public interface IUserService
    {
        int AddUser(AddUserDto addUserDto);
        List<UserResponseDto> UserList();
    }

    public class UserService : IUserService
    {
        private int cnt = 1;
        private List<User> users = new List<User>();

        public int AddUser(AddUserDto addUserDto)
        {
            users.Add(new User(cnt, addUserDto.name, addUserDto.age, addUserDto.height));
            return cnt++;
        }

        public List<UserResponseDto> UserList()
        {
            List<UserResponseDto> userList = new List<UserResponseDto>();
            foreach(User user in users)
            {
                userList.Add(new UserResponseDto().Builder().Id(user.id).Name(user.name).Age(user.age).Height(user.height).Build());
            }
            return userList;
        }
    }
}
