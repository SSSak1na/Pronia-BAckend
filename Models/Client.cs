using Microsoft.Build.Framework;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Client: BaseEntitity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Image { get; set; }
        [Required]
        public string Message { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
