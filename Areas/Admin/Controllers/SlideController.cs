using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_introViewBag_ViewData_TempData_Front_to_back.DAL;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlideController : Controller
    {
        private readonly AppDbContext _context;

        public SlideController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slide> slides = await _context.Slides.ToListAsync();

            return View(slides);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Slide slide)
        {
            if (slide.Photo == null)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil daxil edin");
                return View();
            }

            if (!slide.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File tipi duzgun formatda deyil");
                return View();
            }
            if (slide.Photo.Length > 200 * 1024)
            {
                ModelState.AddModelError("Photo", "File hecmi 200 kb dan boyuk ola bilmez");
                return View();
            }


            return Content(slide.Photo.Length + " " + slide.Photo.ContentType);
        }
    }
}
