using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnappyCart.Models
{
    public class Password
    {
        public int passwordId { get; set; }
        public string password { get; set; }

        public int userId { get; set; }

    }
}