using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskApplication.Models
{
    public class Issue
    {
        public int IssueId { get; set; }

        [Required]
        [Display(Name = "Issue name")]
        public string IssueName { get; set; }

        [Display(Name = "Issue Description")]
        public string IssueDescription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime IssueCreateDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime IssueUpdateDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public virtual int StatusId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public virtual int CategoryId { get; set; }

        public virtual List<SubTask> SubTasks { get; set; }
    }
}