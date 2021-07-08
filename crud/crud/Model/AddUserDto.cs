using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Model
{
    public class AddUserDto
    {
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
