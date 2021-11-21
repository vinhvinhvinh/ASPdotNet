using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CakeBakery.Models;
using CakeBakery.Data;
using Microsoft.EntityFrameworkCore;

namespace CakeBakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly CakeBakeryContext _context;

        public HomeController(CakeBakeryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lstProducts = _context.Products.ToList();
            ViewBag.ProductList = lstProducts;
            var lstMenus = _context.Menus.ToList();
            ViewBag.MenuList = lstMenus;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
