using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_introViewBag_ViewData_TempData_Front_to_back.DAL;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product>products=await _context.Products.Include(p=>p.ProductImages).ToListAsync();
            return View(products);
            //return View(Task.FromResult(products));

        }
    }
}
