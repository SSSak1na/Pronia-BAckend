namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Tag:BaseEntitity
    {
        public string Name { get; set; }

        public List<ProductTag> ProductTags { get; set; }
    }
}
