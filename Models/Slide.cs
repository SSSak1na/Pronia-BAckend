using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Slide:BaseEntitity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Order { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
