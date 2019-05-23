using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using cookiezz.Data;
using cookiezz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace cookiezz.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly EfDataContext _context;
        
        public AdminController(EfDataContext context,IHostingEnvironment environment)
        {
            hostingEnvironment = environment;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(new ProductViewModel());
        }
        
        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            var img = model.Image;
            string uniqueFileName=null;
   
            if (img != null)
            {
                uniqueFileName = GetUniqueFileName(img.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads,uniqueFileName);
                img.CopyTo(new FileStream(filePath, FileMode.Create)); 
            }

            var category = _context.Categories.Find(model.CategoryId);
            var product = new Product{ProductName = model.ProductName,Description = model.Description,ImageUrl = uniqueFileName,Price = model.Price,Category = category};
            _context.Add<Product>(product);
            _context.SaveChanges();
            
            return RedirectToAction("Index","Home");
        }
        
        public IActionResult CreateCategory()
        {
            return View(new CategoryViewModel());
        }
        
        [HttpPost]
        public IActionResult CreateCategory(CategoryViewModel model)
        {
            var category = new Category{CategoryName = model.name};
            _context.Add<Category>(category);
            _context.SaveChanges();
            
            return RedirectToAction("Index","Home");
        }
        
        
        
        
        
        
        
        
        
        
        
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return  Path.GetFileNameWithoutExtension(fileName)
                    + "_" 
                    + Guid.NewGuid().ToString().Substring(0, 4) 
                    + Path.GetExtension(fileName);
        }
    }

}