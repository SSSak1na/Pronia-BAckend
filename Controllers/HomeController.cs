using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            List<Slides> slides = _context.Slides.OrderBy(s => s.Order).Take(3).ToList();
            List<Product> products = _context.Products.ToList();

            List<Users> users = _context.Users.Include(x => x.Speciality).ToList();
        }
    }
}
