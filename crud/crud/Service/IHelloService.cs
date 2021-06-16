using crud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Service
{
    public interface IHelloService
    {
        String getHello();
        String getHelloParam(int num);
        String postTest(HelloDto helloDto);
    }
}
