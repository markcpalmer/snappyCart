﻿using System;
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
                return View(); // returns a view but which one?  how does it know the right view to choose
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
                
                ModelState.AddModelError("error", "User already exists");
                return View(RegisteredUser);
            }
            else
            {
                
                Dc.insertregistereduser(RegisteredUser.UserName, RegisteredUser.LastName, RegisteredUser.FirstName, RegisteredUser.Password);
                return RedirectToAction("Login", "Home");

            }

        }

    }
}