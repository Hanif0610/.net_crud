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

        public User UserList()
        {
            //            return new User(users[0].id, users[0].name, users[0].age, users[0].height);
            return new User().Builder().Id(users[0].id).Name(users[0].name).Age(users[0].age).Height(users[0].height).Build();
        }
    }
}
