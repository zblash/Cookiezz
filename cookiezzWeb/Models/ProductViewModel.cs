using Microsoft.AspNetCore.Http;

namespace cookiezz.Models
{
    public class ProductViewModel
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public decimal Price { get; set; }
    }
}