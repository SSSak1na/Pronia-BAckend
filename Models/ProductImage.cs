namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class ProductImage:BaseEntitity
    {
        public string Image { get; set; }
        public bool? IsPrimary { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
