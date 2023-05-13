using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;
using System.Collections.Generic;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slides> Slides { get; set; }

        public DbSet<Specialities> Specialities { get; set; }
        public DbSet<Users> Users { get; set; }
    }

}
