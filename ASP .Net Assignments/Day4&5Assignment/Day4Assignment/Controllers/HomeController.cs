using Day4Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Day4Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Accounts);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateAccount(Account a)
        {
            /*if (a.AccountNumber < 0)
            {
                ModelState.AddModelError("AccountNumber", "Account number cannot be negative");
            }
            if (string.IsNullOrEmpty(a.Name))
            {
                ModelState.AddModelError("Name", "Account holder's name is required");
            }
            if ((a.CurrentBalance >= 1 && a.CurrentBalance < 500) ||
                        a.CurrentBalance < 0)
            {
                ModelState.AddModelError("CurrentBalance", "Minimum balance must be atleast 500");
            }*/

            if (ModelState.IsValid)
            {
                context.Accounts.Add(a);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");

        }

        public ActionResult Edit(int? accno)
        {
            var account_to_edit = (from a in context.Accounts
                                   where a.AccountNumber == accno
                                   select a).SingleOrDefault();
            return View(account_to_edit);
        }
        public ActionResult EditAccount(Account a)
        {
            context.Entry<Account>(a).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? accno)
        {
            var account_to_delete = (from a in context.Accounts
                                     where a.AccountNumber == accno
                                     select a).SingleOrDefault();
            context.Entry<Account>(account_to_delete).State =
                    EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public JsonResult CheckAccountNumber(int AccountNumber)
        {
            var acc = (from a in context.Accounts
                       where a.AccountNumber == AccountNumber
                       select a).SingleOrDefault();

            if (acc == null)
            {
                return Json(true, new Newtonsoft.Json.JsonSerializerSettings());
            }
            return Json("Account number " + AccountNumber + "already exists", new Newtonsoft.Json.JsonSerializerSettings());
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
