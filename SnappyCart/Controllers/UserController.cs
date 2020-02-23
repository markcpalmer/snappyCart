using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnappyCart.Models;


namespace SnappyCart.Controllers
{
    public class UserController : Controller
    {
        SnappyDBDataContext Dc = new SnappyDBDataContext();
        Users U = new Users();

        // GET: User
        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult UserProfile(int? ID) //Nullable Int Type 
        {
            List<Users> getUsers = new List<Users>();

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
                var getResults = U.Users.Where(Users => User.UserId == ID).ToList();
                foreach (var item in getResults)
                {
                    getUsers.Add(item);
                }
                return View(getUsers);
            }
        }
    }
}