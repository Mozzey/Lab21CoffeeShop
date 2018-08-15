using Lab21CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Welcome(UserModel user)
        {
            var fullname = $"{user.FirstName} {user.LastName}";
            ViewBag.Message = fullname;
            return View(user);
        }
    }
}