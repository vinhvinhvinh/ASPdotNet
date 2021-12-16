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
            //lấy MenuId của ngày hôm nay
            int menuId = _context.Menus.Where(menu => menu.MenuDate == DateTime.Today).Select(menu=>menu.Id).FirstOrDefault();
            //get List MenuDetail của MenuId trên
            var menu2day = _context.MenuDetails.Where(i => i.MenuId == menuId).ToList();
            //đóng gói
            ViewBag.MenuToday = menu2day;
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
