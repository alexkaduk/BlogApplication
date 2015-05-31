using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [Range(18, 100, ErrorMessage = "Our users must be 18+ years old.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string About { get; set; }

    //    public virtual List<Post> Posts { get; set; }
    }

    //public class Post
    //{

    //}
}