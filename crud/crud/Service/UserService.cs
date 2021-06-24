using crud.Entity;
using crud.Model;
using System.Collections.Generic;

namespace crud.Service
{
    public interface IUserService
    {
        int AddUser(AddUserDto addUserDto);
        User UserList();
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

        public User UserList() => users[0];
    }
}
