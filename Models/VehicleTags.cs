﻿namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Models
{
    public class VehicleTags
    {

        public int ID { get; set; }
        public int VehiclesID { get; set; }
        public int TagsID { get; set; }
        public Vehicles Vehicles { get; set; }
        public Tags Tags { get; set; }
    }
}
