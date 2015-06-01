using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskApplication.Models
{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public string SubTaskDescrioption { get; set; }

        public virtual int IssueId { get; set; }
        public virtual int StatusId { get; set; }
    }
}