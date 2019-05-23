using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookiezz.Models
{
    public class Address
    {
        public int Id { get; set; } 
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }
        public int Phone { get; set; }

    }
}
