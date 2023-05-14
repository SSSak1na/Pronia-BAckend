using MVC_introViewBag_ViewData_TempData_Front_to_back.ViewModels;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Images
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public bool IsPrimary { get; set; }
        public int VehiclesID { get; set; }
        public Vehicles Vehicles { get; set; }
    }
}
