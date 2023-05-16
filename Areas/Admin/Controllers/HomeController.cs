using Microsoft.AspNetCore.Mvc;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {   public IActionResult Index()
            {
                return View();
            }
        }
    }

