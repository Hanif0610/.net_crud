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
        public int height { get; set; }


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
        public UserResponseDto Height(int height)
        {
            this.height = height;
            return this;
        }

        public UserResponseDto Build()
        {
            return this;
        }
    }
}
