﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookiezz.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public Unit Unit { get; set; }
        public int Quantity { get; set; }

    }
}
