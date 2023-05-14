using MVC_introViewBag_ViewData_TempData_Front_to_back.ViewModels;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class VehicleColors
    {
        public int ID { get; set; }
        public int VehiclesID { get; set; }
        public int ColorsID { get; set; }
        public Colors Colors { get; set; }
        public Vehicles Vehicles { get; set; }
    }
}