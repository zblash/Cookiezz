using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookiezz.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

    }
}
