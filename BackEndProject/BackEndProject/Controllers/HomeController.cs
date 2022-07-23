﻿using BackEndProject.DAL;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BackEndProject.Controllers
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
            HomeVM homeVM = new HomeVM();
            //homeVM.Sliders = _context.Sliders.ToList();
            homeVM.SliderContents = _context.SliderContents.Include(p => p.Slider).ToList();
            homeVM.Banners = _context.Banners.ToList();
            homeVM.Categories = _context.Categories.Take(6).ToList();
            // homeVM.Categories = _context.Categories.Skip(6).Take(6).ToList();
            homeVM.Products = _context.Products.Include(p => p.Category).ToList();
            return View(homeVM);
        }

    }
}
