using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnappyCart.Models;

namespace SnappyCart.Controllers
{
    public class HomeController : Controller
    {
        SnappyDBDataContext Dc = new SnappyDBDataContext();
        userProduct Up = new userProduct();//create object Up that represents userProduct table in DB

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

        [HttpGet]
        /// get int ID 
        /// look at db to see if user id exists, if exists grab all related data
        /// store each record of data into the list
        /// display list
        
        public ActionResult ShoppingCart(int ID)
        {
            List<userProduct> getUsersCart = new List<userProduct>();
           var getResults = Dc.userProducts.Where(cart => cart.UserID == ID).ToList();
            foreach(var item in getResults)
            {
                getUsersCart.Add(item);
            }
            return View(getUsersCart);
        }
    }
}