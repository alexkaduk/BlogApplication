using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskApplication.Models
{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public string SubTaskDescrioption { get; set; }

        public int IssueId { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}