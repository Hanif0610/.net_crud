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

        public User(int _id, string _name, int _age, int _height)
        {
            id = _id;
            name = _name;
            age = _age;
            height = _height;
        }
    }
}
