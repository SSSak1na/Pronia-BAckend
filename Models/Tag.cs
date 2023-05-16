namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductTag> ProductTags { get; set; }
    }
}
