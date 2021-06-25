using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Entity
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int height { get; set; }

        public User() { }

        public User(int id, string name, int age, int height)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = height;
        }

        public User Builder()
        {
            return new User();
        }

        public User Id(int id)
        {
            this.id = id;
            return this;
        }
        public User Name(string name)
        {
            this.name = name;
            return this;
        }
        public User Age(int age)
        {
            this.age = age;
            return this;
        }
        public User Height(int height)
        {
            this.height = height;
            return this;
        }

        public User Build()
        {
            return this;
        }
    }
}
