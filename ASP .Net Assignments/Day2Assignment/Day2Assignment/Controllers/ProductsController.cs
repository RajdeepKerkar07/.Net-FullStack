using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2Assignment.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the view return View(p.GetProducts());
            return View(p.GetProducts());
        }
    }
}
