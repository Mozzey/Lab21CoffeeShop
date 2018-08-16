using Lab21CoffeeShop.Models;
using System;
using System.Web;
using System.Web.Mvc;
using Lab21CoffeeShop.Constants;

namespace Lab21CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        int Counter = 0;

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
        public ActionResult UserAdded(UserModel user)
        {
            // FirstName cookie
            HttpCookie firstNameCookie;
            if (Request.Cookies[Cookies.FirstNameCookie] == null)
            {
                firstNameCookie = new HttpCookie(Cookies.FirstNameCookie);
                firstNameCookie.Value = user.FirstName;
                firstNameCookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            else
            {
                firstNameCookie = Request.Cookies[Cookies.FirstNameCookie];
            }

            firstNameCookie.Value = user.FirstName;
            Response.Cookies.Add(firstNameCookie);
            ViewBag.Message = $"{firstNameCookie.Value}";

            // FavCoffeeCookie
            HttpCookie favCoffeeCookie;
            if (Request.Cookies[Cookies.FavCoffeeCookie] == null)
            {
                favCoffeeCookie = new HttpCookie(Cookies.FavCoffeeCookie);
                favCoffeeCookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            else
            {
                favCoffeeCookie = Request.Cookies[Cookies.FavCoffeeCookie];
            }

            favCoffeeCookie.Value = user.Coffee;
            Response.Cookies.Add(favCoffeeCookie);
            
            return View();  
        }

        // not using this yet testing it on the route where the name is displayed first
        public ActionResult Products()
        {
            HttpCookie cookie = HttpContext.Request.Cookies[Cookies.FavCoffeeCookie];
            ViewBag.FavCoffee = cookie.Value;

            return View();
        }
    }
}