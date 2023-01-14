using Day2Assignment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day2Assignment.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index(string id) 
        {
            if (id == null) 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>"); 
            } 
            else if (id.ToLower() == "plain") 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/plain"); 
            } 
            else if (id.ToLower() == "html") 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/html"); 
            } 
            else if (id.ToLower() == "xml") 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/xml"); 
            } 
            return Content("Invalid content type"); 
        }

        public ActionResult DownloadFile() 
        {
            var fileName = @"C:\Users\RAKERKAR\source\repos\Day2Assignment\Day2Assignment\wwwroot\lighthouse.jpg";
            if (!System.IO.File.Exists(fileName)) 
            { 
                return Content("File to be downloaded not found"); 
            }
            return PhysicalFile(fileName, "image/jpg");
        }
        public ActionResult Google() 
        { 
            return Redirect("http://www.google.com"); 
        }
        public ActionResult StartPage() 
        { 
            return RedirectToAction("Index", new { id = "xml" }); 
        }
        public ActionResult Login() { return View(); }
        public ActionResult AboutUs() { return View(); }
    }
}
