using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CakeBakery.Data;
using CakeBakery.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CakeBakery.Controllers
{
    public class AccountsController : Controller
    {
        private readonly CakeBakeryContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountsController(CakeBakeryContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment= webHostEnvironment;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            //Thông tin người dùng
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }
            //var res = _context.Accounts.Where(acc => acc.IsAdmin == true && acc.Address1.Contains("Thành phố Hồ Chí Minh"));
            //return View(await res.ToListAsync());
            return View(await _context.Accounts.ToListAsync());
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountId,Username,Password,Email,FullName,Address1,Address2,Phone,ImageFile,Avatar,IsAdmin,AccountStatus")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                if (account.ImageFile != null)
                {
                    var filename = account.Id.ToString() + Path.GetExtension(account.ImageFile.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "user");
                    var filePath = Path.Combine(uploadPath, filename);

                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        account.ImageFile.CopyTo(fs);
                        fs.Flush();
                    }
                    account.Avatar= filename;

                    _context.Accounts.Update(account);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountId,Username,Password,Email,FullName,Address1,Address2,Phone,Avatar,IsAdmin,AccountStatus")] Account account)
        {
            if (id == account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(account);
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            return View();
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }

        public IActionResult Search(string userInput)
        {
            //Thông tin người dùng
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }


            if (userInput == null)
            {
                userInput = "";
            }
            var accounttList = _context.Accounts.Where(acc => acc.Username.Contains(userInput) || acc.Email.Contains(userInput) || acc.FullName.Contains(userInput) || acc.Phone.Contains(userInput) || acc.Address1.Contains(userInput) || acc.Address2.Contains(userInput)).ToList();
            return View(accounttList);
        }

        public IActionResult Profile()
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            var idUser = Int32.Parse(HttpContext.Request.Cookies["AccountId"]);
            var acc = _context.Accounts.Find(idUser);
            var invs = _context.Orders.Where(inv => inv.AccountId == idUser).ToList();
            ViewBag.ListInvoices = invs;
            return View(acc);
        }

        public IActionResult InvoiceDetail(int id)
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            var idUser = Int32.Parse(HttpContext.Request.Cookies["AccountId"]);
            var acc = _context.Accounts.Find(idUser);
            var inv = _context.Orders.Where(i => i.Id == id).First();
            var detail = _context.OrdersDetails.Include(de=>de.Product).Where(de => de.OrderId == id).ToList();
            ViewData["acc"] = acc;
            ViewData["inv"] = inv;
            return View(detail);
        }



        public async Task<IActionResult> Update(  string email, string fullname, string address1, string number )
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            var idUser = Int32.Parse(HttpContext.Request.Cookies["AccountId"]);
            var acc = _context.Accounts.Find(idUser);
            acc.Email = email;
            acc.FullName = fullname;
            acc.Address1 = address1;
            
            acc.Phone = number;
            _context.Accounts.Update(acc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Profile", "Accounts");
           
        }
    }
}
