using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cookiezz.Models;
using Microsoft.AspNetCore.Authorization;
using cookiezz.Data;
using Microsoft.EntityFrameworkCore;

namespace cookiezz.Controllers
{
    public class HomeController : Controller
    {
        private readonly EfDataContext _context;
        public HomeController(EfDataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> Store(int id)
        {
            return View(await _context.Products.Where(x => x.Category.Id == id).ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
