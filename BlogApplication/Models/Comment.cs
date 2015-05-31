using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime CreateAt { get; set; }

        public virtual int PostId { get; set; }
        public virtual int UserId { get; set; }
    }
}