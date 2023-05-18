namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class Profession:BaseEntitity
    {
        public int Name { get; set; }
        public List<Client> Clients { get; set; }
    }
}
