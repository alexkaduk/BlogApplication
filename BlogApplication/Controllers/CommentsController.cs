// 1:53 - розказав все, що і як працює!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApplication.Models;

namespace BlogApplication.Controllers
{
    public class CommentsController : Controller
    {
        private BlogContex Repository = new BlogContex();
        //
        // GET: /Comments/

        public PartialViewResult _GetForPost(int id)
        {
            ViewBag.PostId = id;
            var comments = Repository.Comments.Where(x => x.PostId == id).ToList();
            return PartialView("_GetForPost", comments);
        }

        [ChildActionOnly]
        public PartialViewResult _CommentForm(int id) 
        {
            var model = new Comment { PostId = id };
            return PartialView("_CommentForm", model);
        }

        [ValidateAntiForgeryToken]
        public PartialViewResult _SubmitComment(Comment comment)
        {
            comment.CreateAt = DateTime.Now;
            Repository.Comments.Add(comment);
            Repository.SaveChanges();

            ViewBag.PostId = comment.PostId;
            var comments = Repository.Comments.Where(x => x.PostId == comment.PostId).ToList();
            return PartialView("_GetForPost", comments);
        }
    }
}
