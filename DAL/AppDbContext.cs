using Microsoft.EntityFrameworkCore;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;
using System.Collections.Generic;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<VehicleColors> VehicleColors { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<VehicleTags> VehicleTags { get; set; }




    }

}
