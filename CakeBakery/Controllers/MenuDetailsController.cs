using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CakeBakery.Data;
using CakeBakery.Models;

namespace CakeBakery.Controllers
{
    public class MenuDetailsController : Controller
    {
        private readonly CakeBakeryContext _context;

        public MenuDetailsController(CakeBakeryContext context)
        {
            _context = context;
        }

        // GET: MenuDetails
        public async Task<IActionResult> Index()
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            var cakeBakeryContext = _context.MenuDetails.Include(m => m.Menu).Include(m => m.Product);
            return View(await cakeBakeryContext.ToListAsync());
        }

        // GET: MenuDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }
            if (id == null)
            {
                return NotFound();
            }

            var menuDetail = await _context.MenuDetails
                .Include(m => m.Menu)
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuDetail == null)
            {
                return NotFound();
            }

            return View(menuDetail);
        }

        // GET: MenuDetails/Create
        public IActionResult Create()
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: MenuDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MenuId,ProductId,Stock")] MenuDetail menuDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menuDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", menuDetail.MenuId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", menuDetail.ProductId);
            return View(menuDetail);
        }

        // GET: MenuDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuDetail = await _context.MenuDetails.FindAsync(id);
            if (menuDetail == null)
            {
                return NotFound();
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", menuDetail.MenuId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", menuDetail.ProductId);
            return View(menuDetail);
        }

        // POST: MenuDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MenuId,ProductId,Stock")] MenuDetail menuDetail)
        {
            if (id != menuDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menuDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuDetailExists(menuDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", menuDetail.MenuId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", menuDetail.ProductId);
            return View(menuDetail);
        }

        // GET: MenuDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuDetail = await _context.MenuDetails
                .Include(m => m.Menu)
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuDetail == null)
            {
                return NotFound();
            }

            return View(menuDetail);
        }

        // POST: MenuDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menuDetail = await _context.MenuDetails.FindAsync(id);
            _context.MenuDetails.Remove(menuDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuDetailExists(int id)
        {
            return _context.MenuDetails.Any(e => e.Id == id);
        }
        public IActionResult Search(DateTime userInput)
        {
            if (userInput == null)
            {
                userInput = DateTime.Now;
            }
            var menuList = _context.Menus.Where(menu => menu.MenuDate == userInput).ToList();
            ViewBag.ggg = menuList;
            return View(menuList);
        }
    }
}
