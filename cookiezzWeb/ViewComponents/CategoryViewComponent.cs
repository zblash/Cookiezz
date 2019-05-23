using System.Threading.Tasks;
using cookiezz.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cookiezz.ViewComponents
{
    [ViewComponent(Name = "Category")]
    public class CategoryViewComponent : ViewComponent
    {
        private readonly EfDataContext _context;
        public CategoryViewComponent(EfDataContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(
                _context.Categories.ToListAsync().Result
            );
        }
    }
}