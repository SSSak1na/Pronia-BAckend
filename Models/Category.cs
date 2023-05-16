using System.ComponentModel.DataAnnotations;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad daxil etməyiniz tələb olunur")]
        [MaxLength(50, ErrorMessage = "Maksimum simvol sayı 50 olmalıdır")]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
