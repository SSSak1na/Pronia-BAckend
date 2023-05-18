namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class ProductColor: BaseEntitity
    { 
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}
