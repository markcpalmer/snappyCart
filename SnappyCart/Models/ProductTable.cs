﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnappyCart.Models
{
    public class Products
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public decimal productPrice { get; set; }

    }
}