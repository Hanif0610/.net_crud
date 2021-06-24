using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Entity
{
    public class User
    {
        private int id { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private int height { get; set; }

        public User(int id, string name, int age, int height)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = height;
        }
    }
}
