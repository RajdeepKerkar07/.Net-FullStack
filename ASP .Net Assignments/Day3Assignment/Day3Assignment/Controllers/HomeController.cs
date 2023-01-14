using Day3Assignment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Day3Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;


        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
            return View();
        }


        public ActionResult AddUser()
        {
            return View();
        }


        public ActionResult SaveUser(User u)
        {
            string ContentRootPath = _webHostEnvironment.ContentRootPath;
            string path = Path.Combine(ContentRootPath, @"App_Data/users.txt");
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine("User details added on: " + DateTime.Now.ToString());
            sw.WriteLine("User name: " + u.UserName);
            sw.WriteLine("Password: " + u.Password);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");
        }

        public ActionResult HtmlHelpers()
        {
            return View();
        }
    }
}