using crud.Model;
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

        public string postTest(HelloDto helloDto)
        {
            string name = helloDto.name;
            int age = helloDto.age;

            return name + "님의 나이는" + age + "세 입니다.";
        }
    }
}
