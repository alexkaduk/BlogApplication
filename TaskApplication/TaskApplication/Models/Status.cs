using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskApplication.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual int IssueId { get; set; }
        public virtual int SubTaskId { get; set; }
    }
}