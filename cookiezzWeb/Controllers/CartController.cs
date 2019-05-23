using System;
using System.Threading.Tasks;
using cookiezz.Data;
using cookiezz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace cookiezz.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly EfDataContext _context;
        private UserManager<User> _userManager;
        
        public CartController(EfDataContext context,UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        
        public IActionResult Index(){
            return View();
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _context.Products.FindAsync(id);
            CartItem cartItem = new CartItem{User = GetCurrentUserAsync().Result,Product = product,Quantity = 1,TimeAdded = DateTime.Now};
            _context.Add<CartItem>(cartItem);
            _context.SaveChanges();
            return Redirect("/");
        }
    }
}