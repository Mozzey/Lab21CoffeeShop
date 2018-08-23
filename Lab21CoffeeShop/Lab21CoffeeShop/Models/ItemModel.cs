﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21CoffeeShop.Models
{
    public class ItemModel
    {
        public int ItemModelID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}