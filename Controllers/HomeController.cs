﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_introViewBag_ViewData_TempData_Front_to_back.DAL;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;
using MVC_introViewBag_ViewData_TempData_Front_to_back.ViewModels;
using System;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slide> slides = _context.Slides.OrderBy(s => s.Order).Take(3).ToList();

            List<Product> products = _context.Products.Include(p => p.Category).Include(p => p.ProductImages).ToList();

            HomeVM homeVM = new HomeVM
            {
                Sliders = slides,
                Products = products
            };

            return View(homeVM);
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id < 1) return BadRequest();

            Product product = _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();
           
            List<Product> products = _context.Products.Include(p => p.ProductImages).Where(p => p.CategoryId == product.CategoryId && p.Id != product.Id).ToList();
            
            DetailsVM detailsVM = new DetailsVM
            {
                Product = product,
                Products = products
            };

            return View(detailsVM);
        }
        public IActionResult About()
        {
            return View();
        }

    }
}

