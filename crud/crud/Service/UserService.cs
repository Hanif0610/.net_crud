using crud.Entity;
using crud.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace crud.Service
{
    public interface IUserService
    {
        int AddUser(AddUserDto addUserDto);
        List<UserResponseDto> UserList();
        UserResponseDto UserInfo(int id);
        void UpdateUser(int id, AddUserDto addUserDto);
        void DeleteUser(int id);
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

        public UserResponseDto UserInfo(int id)
        {
            User user = users.Find(x => x.id == id);
            if (user == null)
            {
                throw new KeyNotFoundException("User Not Found.");
            }
            return new UserResponseDto().Builder().Id(user.id).Name(user.name).Age(user.age).Height(user.height).Build();
        }

        public void UpdateUser(int id, AddUserDto addUserDto)
        {
            if(users.Find(x => x.id == id) == null)
            {
                throw new KeyNotFoundException("User Not Found.");
            }
            users[id - 1].name = addUserDto.name;
            users[id - 1].age = addUserDto.age;
            users[id - 1].height = addUserDto.height;
        }

        public void DeleteUser(int id)
        {
            if (users.Find(x => x.id == id) == null)
            {
                throw new KeyNotFoundException("User Not Found.");
            }
            users.RemoveAt(id - 1);
        }
    }
}
