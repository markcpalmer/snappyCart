using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnappyCart.Models
{
    public class UserProductModel
    {
        public int userID { get; set; }
        public int productId { get; set; }
        public DateTime orderDate { get; set; }
    }
}