﻿namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class ProductTag:BaseEntitity
    {

        public int ProductId { get; set; }
        public int TagId { get; set; }

        public Product Product { get; set; }
        public Tag Tag { get; set; }
    }
}
