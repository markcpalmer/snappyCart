using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SnappyCart.Models
{
    public class UserModel
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}