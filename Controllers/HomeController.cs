using Microsoft.AspNetCore.Mvc;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Slides> slides = new List<Slides>();
            List<Product> products = new List<Product>();
            List<Users> users = new List<Users>();
            slides.Add(new Slides
            {
                ID = 1,
                Title = "First Slide",
                Subtitle = "First Slide Subitle",
                Description = "This Slide Is Better Than Other Slides",
                ImageUrl = "1-1-524x617.png",
                Order = 1
            });
            slides.Add(new Slides
            {
                ID = 2,
                Title = "Second Slide",
                Subtitle = "Second Slide Subitle",
                Description = "This Slide Is Better Than First Slides",
                ImageUrl = "1-2-524x617.png",
                Order = 2
            });
            slides.Add(new Slides
            {
                ID = 3,
                Title = "3rd Slide",
                Subtitle = "3rd Slide Subitle",
                Description = "3rd Slide Is Better Than Second Slides",
                ImageUrl = "FMX4OtXVQAEZ5rR.png",
                Order = 3
            });
            slides.Add(new Slides
            {
                ID = 4,
                Title = "Slide",
                Subtitle = "Slide Subitle",
                Description = "this Slide Is Better Than Second Slides",
                ImageUrl = "FMX4OtXVQAEZ5rR.png",
                Order = 4
            });
            slides.Add(new Slides
            {
                ID = 5,
                Title = "Slide",
                Subtitle = " Slide Subitle",
                Description = "This Slide Is Better Than Second Slides",
                ImageUrl = "FMX4OtXVQAEZ5rR.png",
                Order = 5
            });
            slides.Add(new Slides
            {
                ID = 6,
                Title = " Slide",
                Subtitle = " Slide Subitle",
                Description = "This Slide Is Better Than Second Slides",
                ImageUrl = "FMX4OtXVQAEZ5rR.png",
                Order = 6
            });

            products.Add(new Product
            {
                Id = 1,
                Name = "Frog Puzzle",
                Price = $12.25,
                ImageURL = "Screenshot 2023-05-10 212706.png"
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "Frog And Panther Puzzle",
                Price = $23.25,
                ImageURL = "Screenshot 2023-05-10 215520.png"
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Sad Frog",
                Price = $23.25
                ImageURL = "sad frog.png"
            });
            products.Add(new Product
            {
                Id = 4,
                Name = "Happy Frog",
                Price =$31.20,
                ImageURL = "BWd6WMRCIAE2Qi4.jpg"
            });
            products.Add(new Product
            {
                Id = 5,
                Name = "Popular Frog",
                Price = $12.47,
                ImageURL = "h280_49723872.jpg"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Hardworking Frog",
                Price = $15.29,
                ImageURL = "h280_38646443.jpg"
            });
            products.Add(new Product
            {
                Id = 7,
                Name = "Drunk Frog",
                Price = 4.99m,
                ImageURL = "kermit-1651610_1280.jpg"
            });
            products.Add(new Product
            {
                Id = 8,
                Name = "Alone Frog",
                Price = $14.25,
                ImageURL = "pole-dance-2862307_1280.jpg"
            });

            users.Add(new Users
            {
                Id = 1,
                Name = "Sanan",
                Surname = "Abdunov",
                Position = "System administrator",
                Comment = "About the Sanan Abdonov",
                ImageURL = "debbf36082c.m.jpeg"
            });
            users.Add(new Users
            {
                Id = 2,
                Name = "Ramziyya",
                Surname = "Abdunova",
                Position = "Audit",
                Comment = "About the Ramziyya Abdunova",
                ImageURL = "1107715-8211.jpg"
            });
            users.Add(new Users
            {
                Id = 3,
                Name = "Sabina",
                Surname = "Abdunova",
                Position = "Graphic designer",
                Comment = "About the Sabina Abdunova",
                ImageURL = "232802.1297711_77.jpg"
            });
            users.Add(new Users
            {
                Id = 4,
                Name = "Sakina",
                Surname = "Allahverdiyeva",
                Position = "Student",
                Comment = "About the Sakina Allahverdiyeva",
                ImageURL = "2822745.1472069_77.jpg"
            });
           



            HomeVM homeVM = new HomeVM
            {
                Products = products,
                Sliders = slides.OrderBy(x => x.Order).Take(3).ToList(),
                Users = users

            };
            return View(homeVM);
        }
    }
    }
}
