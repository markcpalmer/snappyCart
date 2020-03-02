using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnappyCart.Models
{

    public class UserProductModel
    {
        //@*UserID,b.ProductID,OrderDate,ProductName, ProductDescription, ProductPrice*@

        public int userID { get; set; }
        public int productId { get; set; }
        public DateTime orderDate { get; set; }

        public string productName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }


    }
}