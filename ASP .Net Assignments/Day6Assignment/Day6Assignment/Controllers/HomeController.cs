using Day6Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Day6Assignment.Controllers
{
    public class HomeController : Controller
    {
        static List<User> users = new List<User>();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetServerTime()
        {
            Thread.Sleep(5000);
            return PartialView();
        }
        public ActionResult GetAllUsers()
        {
            return PartialView(users);
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User u)
        {
            users.Add(u);
            return RedirectToAction("GetAllUsers");
        }

    }
}