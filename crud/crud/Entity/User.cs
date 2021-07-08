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
        public string email { get; set; }
        public string password { get; set; }

        public User() { }

        public User(int id, string name, int age, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
            this.password = password;
        }
    }
}
