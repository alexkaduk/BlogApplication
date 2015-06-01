﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual int IssueId { get; set; }
        public virtual int SubTaskId { get; set; }
    }
}