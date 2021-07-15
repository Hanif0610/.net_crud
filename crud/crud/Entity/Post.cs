using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Entity
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime createdAt { get; set; }

        public Post() { }

        public Post(int id, string title, string content, DateTime createdAt)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
