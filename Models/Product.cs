namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
    }
}
