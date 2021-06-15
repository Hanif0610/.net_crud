using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Service
{
    public class HelloService : IHelloService
    {
        public string getHello() => "Hello, World!";

        public string getHelloParam(int num) => "Hello, World!" + num;
    }
}
