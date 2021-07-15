using crud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Service
{

    public interface IPostService
    {
        void Write(PostRequestDto postRequestDto);
    }

    public class PostService : IPostService
    {
        public void Write(PostRequestDto postRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
