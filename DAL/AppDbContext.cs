using Microsoft.EntityFrameworkCore;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;
using System.Collections.Generic;
using System.Drawing;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slide> Slides { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Profession> Professions { get; set; }




    }

}
