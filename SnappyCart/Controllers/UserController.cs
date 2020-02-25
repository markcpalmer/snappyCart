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
        [HttpGet]
        public ActionResult UserProfile(int? ID) //Nullable Int Type 
        {
            List<user> getUsers = new List<user>();

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
                var getResults = Dc.users.Where(user => user.UserID == ID).ToList();
                foreach (var item in getResults)
                {
                    getUsers.Add(item);
                }
                return View(getUsers);
            }
        }

        public ActionResult Register(Users RegisteredUser)
        {
            user ord = new user
            {
                UserName = RegisteredUser.UserName,
                FirstName = RegisteredUser.FirstName,
                LastName = RegisteredUser.LastName
            };

            Dc.users.InsertOnSubmit(ord);

            Dc.SubmitChanges();
            return View();
        }

    }
}