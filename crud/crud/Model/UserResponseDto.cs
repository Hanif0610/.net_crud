using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Model
{
    public class UserResponseDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }


        public UserResponseDto Builder()
        {
            return new UserResponseDto();
        }

        public UserResponseDto Id(int id)
        {
            this.id = id;
            return this;
        }
        public UserResponseDto Name(string name)
        {
            this.name = name;
            return this;
        }
        public UserResponseDto Age(int age)
        {
            this.age = age;
            return this;
        }

        public UserResponseDto Email(string email)
        {
            this.email = email;
            return this;
        }

        public UserResponseDto Build()
        {
            return this;
        }
    }
}
