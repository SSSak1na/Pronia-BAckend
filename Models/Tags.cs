namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Tags
    {
        public int ID { get; set; }
        public string TagName { get; set; }
        List<VehicleTags> VehicleTags { get; set; }
    }
}
