using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SnappyCart.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required (ErrorMessage ="Email required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        public UserModel GetUser(UserModel logon, bool cookie)
        {
            SnappyDBDataContext Dc = new SnappyDBDataContext();
            user user = new user();

            // Determine if the cookie exists
            if (cookie == false)
            {
                /// assign login password what is currently stored in logon.password.  
                /// because there is a cookie being stored.  
                /// If someone hacks password then the passord wouldn't match backend?

                logon.Password = logon.Password;
            }
            
            // Determine if user exists
            try
            {   
                user = Dc.users.Single(a => a.UserName == logon.UserName); //Gets UserName and Password
                
            }
            catch
            {
                logon = null;
                return logon;
            }

            return logon;
        }
    }
}