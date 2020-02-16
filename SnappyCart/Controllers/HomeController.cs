using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnappyCart.Controllers
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
        public ActionResult Login()
        {
           ViewBag.Message = "Login Page";
           return View();
            
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Registration Page";
            return View();
        }
        public ActionResult ShoppingCart()
        {
            ViewBag.Message = "Shopping cart page";
               return View();
        }
    }
}