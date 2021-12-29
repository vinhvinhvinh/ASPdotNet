using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CakeBakery.Data;
using CakeBakery.Models;
//upload file
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CakeBakery.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CakeBakeryContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(CakeBakeryContext context,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            //Thông tin Admin
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            //Trả về các sản phẩm có số lượng tồn kho nhiều từ thứ 3-10 (skip 3 take 7)
            //int menuId = _context.Menus.Where(menu => menu.MenuDate == DateTime.Today).Select(menu => menu.Id).FirstOrDefault(); //b1 lấy menu của ngày hôm nay
            //var menuToday = _context.MenuDetails.Where(i => i.MenuId == menuId);
            //var res=from prod in _context.Products
            //        join prodInMenu in menuToday
            //        on prod.Id equals prodInMenu.Id
            //        select new {Id=prod.Id,Name=prod.Name,Stock=prodInMenu.Stock};
            //ViewBag.MenuProd = res;
            return View(await _context.Products.Include(prod=>prod.ProductType).ToListAsync()); // default
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Image,ImageFile,ProductTypeId,Description,Discount,Status")] Product product)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();

                //Xử lý upload file

                if (product.ImageFile != null)
                {
                    var filename = product.Id.ToString() + Path.GetExtension(product.ImageFile.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "cake-feature");
                    var filePath = Path.Combine(uploadPath, filename);

                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        product.ImageFile.CopyTo(fs);
                        fs.Flush();
                    }
                    product.Image = filename;
                    _context.Products.Update(product);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Image,ProductTypeId,Description,Discount,Status")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
        public IActionResult ListProduct()
        {
            var productList = _context.Products.ToList();
            ViewBag.ProductList = productList;
            return View(productList);
        }
        public IActionResult Search(string keyword="")
        {
            if (keyword == null)
            {
                keyword = "";
            }
            var productList = _context.Products.Where(prod=>prod.Name.Contains(keyword)|| prod.Description.Contains(keyword) || prod.ProductType.TypeName.Contains(keyword)).ToList();
            return View(productList);
        }
        public async Task<IActionResult> ProductDetail(int? id)
        {
            var typeIdOfThisProd = _context.Products.Where(prod => prod.Id == id).Select(prod => prod.ProductTypeId).First();
            var relateProd = _context.Products.Where(prod => prod.ProductTypeId == typeIdOfThisProd).ToList();
            
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.relateProductPackage = relateProd;
            return View(product);
           
        }

        [HttpGet]
        public IActionResult SearchAdmin(string userInput = "")
        {
            if (userInput == null)
            {
                userInput = "";
            }
            var productList = _context.Products.Where(prod => prod.Name.Contains(userInput) || prod.Description.Contains(userInput) || prod.ProductType.TypeName.Contains(userInput)).ToList();
            return View(productList);
        }
    }
}
