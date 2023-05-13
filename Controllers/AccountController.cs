using Microsoft.AspNetCore.Mvc;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
