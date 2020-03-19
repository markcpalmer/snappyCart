using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnappyCart.Models;
using System.Web.Security;

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
                //TODO: Replace these 5 lines with one line of code
                //Use a SP.
                var getResults = Dc.users.Where(user => user.UserID == ID).ToList();
                foreach (var item in getResults)
                {
                    getUsers.Add(item);
                }
                return View(getUsers);
            }
        }

        # region Register
        public ActionResult Register()
        {
            ViewBag.Message = "Registration Page";
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel RegisteredUser)
        {
            //Comparison to see if the user exists
            user doesUserExists = new user();
            doesUserExists = Dc.users
                .Where(exists => exists.UserName == RegisteredUser.UserName)
                .SingleOrDefault();

            if (doesUserExists != null)
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
        #endregion

        public ActionResult Login(UserModel Login) //Nullable Int Type 
        {
            var userExists = Dc.users.Where(a => a.UserName == Login.UserName).FirstOrDefault();//defaults to null and doesn't error out

            if (userExists != null)
            {
                try
                {   
                    //FormsAuthentication common Windows/Microsoft Method. This tells your server to whitelist the cookie.
                    FormsAuthentication.SetAuthCookie(Login.UserName, true); //True is for Remember ME
                    PrepareUserSession(Login);
                    return RedirectToAction("ShoppingCart", "Shopping", new { ID = userExists.UserID });//redirects user to different action"                    
                }
                catch { }
                return View();
            }
            else
            {
                return View(); 
            }


        }

        public void PrepareUserSession(UserModel model)
        {
            // Assigning variables from the model parameter into the Session
            Session["SnappyUser"] = new UserModel()
            {
                UserName = model.UserName,
                Password = model.Password
            };

            /// Assigning the session variables (password/username) into the UserModel 
            /// to reference valid user within each controller of the project.
            /// AUTHENTICATION.  the website knows who the user is at all times
            UserModel usermng = (UserModel)(Session["SnappyUser"]);
        }

    }
}