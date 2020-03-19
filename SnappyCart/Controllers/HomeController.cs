using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SnappyCart.Models;

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

            UserModel Login = new UserModel();

            try
            {
                if (Request.Cookies["SnappyUser"] != null)
                {
                    Login.UserName = Request.Cookies["SnappyUser"].Values["UserName"];
                    Login.Password = Request.Cookies["SnappyUser"].Values["Password"];

                    Login = Login.GetUser(Login, true);
                    if (Login != null)
                    {
                        PrepareUserSession(Login);
                        FormsAuthentication.SetAuthCookie(Login.UserName, true);
                        //return RedirectToAction("ShoppingCart", "Shopping", new { ID = userExists.UserID });//redirects user to different action"
                    }
                }
                else
                {
                    return View();
                }
            }
            catch { }
            return View();
        }

        public ActionResult Catalog()
        {
            ViewBag.Message = "Catalog Page";
            return View();
        }

        public void PrepareUserSession(UserModel model)
        {
            Session["SnappyUser"] = new UserModel()
            {
                UserName = model.UserName,
                Password = model.Password
            };

            UserModel usermng = (UserModel)(Session["SnappyUser"]);

        }
    }
}