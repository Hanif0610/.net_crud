using crud.Entity;
using crud.Model;
using System.Collections.Generic;

namespace crud.Service
{
    public interface IUserService
    {
        int addUser(AddUserDto addUserDto);
    }

    public class UserService : IUserService
    {
        private int cnt = 1;
        private readonly List<User> users = new List<User> { };

        public int addUser(AddUserDto addUserDto)
        {
            users.Add(new User(cnt, addUserDto.name, addUserDto.age, addUserDto.height));
            return cnt++;
        }
    }
}
