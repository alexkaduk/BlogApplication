using BlogApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class UserController : Controller
    {
        // це неправильно робити. неправильно працювати з бд напряму
        private BlogContex Repository { get; set; }

        public UserController()
        {
            Repository = new BlogContex();
        }
        
        //
        // GET: /User/
        public ActionResult Index()
        {
            var list = Repository.Users.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            // щоб не втратити даны. заводимо пустого юзера
            var user = new User();
            return View(user);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Repository.Users.Add(user);
                    Repository.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return View(user);
                }
            }
            else
            {
                return View(user);
            }
        }

        public ActionResult Details(int id)
        {
            var user = Repository.Users.FirstOrDefault(x => x.UserId == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

    }
}
