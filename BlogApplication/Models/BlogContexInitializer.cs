using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogApplication.Models
{
    public class BlogContexInitializer : DropCreateDatabaseAlways<BlogContex>
    {
        protected override void Seed(BlogContex contex) 
        {
            contex.Users.Add(new User { UserName = "Admin", Age = 32, Email = "myemail@my.ua", About = "I'm superman" });
            contex.SaveChanges();
            base.Seed(contex);
        }
    }
}