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
        UserModel U = new UserModel();

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

        public ActionResult Register(UserModel RegisteredUser) 
        {            
            //Comparison to see if the user exists
            user doesUserExists = new user();
            doesUserExists = Dc.users
                .Where(exists => exists.UserName == RegisteredUser.UserName)
                .SingleOrDefault();

            if(doesUserExists != null)
            {
                //Error Message - User Exists
                //Typically if an item exists, you do an update here (just not for register page)
            }
            else
            {
                //Add new user and password
                user newUser = new user
                {
                    UserName = RegisteredUser.UserName,
                    FirstName = RegisteredUser.FirstName,
                    LastName = RegisteredUser.LastName
                };

                password newPass = new password
                {
                    password1 = RegisteredUser.Password,
                    UserID = RegisteredUser.UserId
                };

                Dc.users.InsertOnSubmit(newUser);
                Dc.passwords.InsertOnSubmit(newPass);
                Dc.SubmitChanges();
            }

            return View();
        }

    }
}