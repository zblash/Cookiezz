using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookiezz.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Valid { get; set; }
        public int Quantity { get; set; }
    }
}
