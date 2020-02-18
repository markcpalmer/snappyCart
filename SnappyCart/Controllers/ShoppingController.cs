using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnappyCart.Models;

namespace SnappyCart.Controllers
{
    public class ShoppingController : Controller
    {

        SnappyDBDataContext Dc = new SnappyDBDataContext();
        userProduct Up = new userProduct();//create object Up that represents userProduct table in DB

        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShoppingCart(int? ID) //Nullable Int Type 
        {
            List<userProduct> getUsersCart = new List<userProduct>();

            /// get int ID 
            /// look at db to see if user id exists, if exists grab all related data
            /// store each record of data into the list
            /// display list
            if (ID == null)
            {
                return View();
            }
            else
            {
                var getResults = Dc.userProducts.Where(cart => cart.UserID == ID).ToList();
                foreach (var item in getResults)
                {
                    getUsersCart.Add(item);
                }
                return View(getUsersCart);
            }
        }
    }
}