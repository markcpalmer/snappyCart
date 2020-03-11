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

        public ActionResult Catalog()
        {
            var catalog = Dc.products.ToList();
            return View(catalog);
        }
        /// get int ID 
        /// look at db to see if user id exists, if exists grab all related data
        /// store each record of data into the list
        /// display list
        [HttpGet]
        public ActionResult ShoppingCart(int? ID) //Nullable Int Type 
        {
            // run the sp to get back the contents of the items a user has ordered
            //assign results the database selectuserproduct details sp sending it an ID it gets returned a list
            var results = Dc.selectUserProductDetails(ID).ToList();
           
            //if the ID is null or the table results is empty return the cart is empty message? why if the id is null do we want that message returned?

            if (ID == null || results.Count == 0)
            {
                return View();
            }
            else
            {                
                return View(results);
            }
        }
    }
}