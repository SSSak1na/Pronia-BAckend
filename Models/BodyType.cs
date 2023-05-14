using MVC_introViewBag_ViewData_TempData_Front_to_back.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class BodyType
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Body Type not null")]
        [MaxLength(25, ErrorMessage = "Body Type  MaxLenght 25 ")]
        [MinLength(3, ErrorMessage = "Body Type MinLenght 3")]
        public string Body { get; set; }
        public List<Vehicles> Vehicles { get; set; }
    }
}
