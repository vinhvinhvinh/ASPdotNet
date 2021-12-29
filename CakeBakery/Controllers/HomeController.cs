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
using Microsoft.AspNetCore.Http;

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
            // Kiểm tra Cookie - lấy Username từ Cookie
            if(HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }


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
        [HttpPost]
        public async Task<IActionResult> Login(string Username,string Password)
        {

            //----------Login with Cookie

            Account login = _context.Accounts.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();
            if (login!=null)
            {
                CookieOptions cookieDate = new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(30)
                };
                
                HttpContext.Response.Cookies.Append("AccountID",login.Id.ToString(),cookieDate);
                HttpContext.Response.Cookies.Append("AccountName", login.FullName.ToString(),cookieDate);
                HttpContext.Response.Cookies.Append("AccountAvatar", login.Avatar.ToString(),cookieDate);

                if (!login.IsAdmin)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Products");
                }
                
            }
            else
            {
                ViewBag.LoginFailMessage = "Login Fail. Incorrect Username or Password";
                return View();
            }

        }
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Append("AccountID", "", new CookieOptions { Expires=DateTime.Now.AddDays(-1)}) ;
            HttpContext.Response.Cookies.Append("AccountName", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1)});
            HttpContext.Response.Cookies.Append("AccountAvatar", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1)});
            return RedirectToAction("Index", "Home");

        }
    }
}
