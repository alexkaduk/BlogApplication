using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public virtual int UserId { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}