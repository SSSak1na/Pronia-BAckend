using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.ViewModels
{
    public class HomeVM
    {
        public List<Product> Products { get; set; }
        public List<Slides> Sliders { get; set; }
        public List<Users> Users { get; set; }
    }
}
