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
    public class CartsController : Controller
    {

       
        private readonly CakeBakeryContext _context;

        public CartsController(CakeBakeryContext context)
        {
            _context = context;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }
            var cakeBakeryContext = _context.Carts.Include(c => c.Account).Include(c => c.Product);
            return View(await cakeBakeryContext.ToListAsync());
        }

        // GET: Carts/Details/5
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

            var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }

            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address1");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address1", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", cart.ProductId);
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address1", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", cart.ProductId);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.Id))
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
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address1", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", cart.ProductId);
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Show()
        {
            // Kiểm tra Cookie - lấy Username từ Cookie
            if (HttpContext.Request.Cookies.ContainsKey("AccountName"))
            {
                ViewBag.Fullname = HttpContext.Request.Cookies["AccountName"].ToString();
                ViewBag.Avatar = HttpContext.Request.Cookies["AccountAvatar"].ToString();
            }
            //thông tin người dùng
            int recentUserId = Int32.Parse(HttpContext.Request.Cookies["AccountId"]);
            ViewBag.UserAccount = _context.Accounts.Where(acc => acc.Id == recentUserId).FirstOrDefault();
            // Lấy tổng tiền của Cart 
            ViewBag.TotalPriceInCart = _context.Carts.Include(c => c.Account).Include(c => c.Product)
                                                        .Where(c => c.Account.Id == recentUserId)
                                                        .Sum(c=>c.Quantity*c.Product.Price);

            //Lấy sản phẩm trong cart
            //----
            var prodInCart = from prod in _context.Products
                             join c in _context.Carts on prod.Id equals c.ProductId
                             join a in _context.Accounts on c.AccountId equals a.Id
                             where a.Id == recentUserId 
                             //select new { name = prod.Name, price = prod.Price, image = prod.Image };
                             select prod;

           
            //Lấy số lượng từng sp
            var recentCart = _context.Carts.Include(c => c.Account).Where(c => c.Account.Id == recentUserId);
            
          

                //----
                ViewBag.ProdInCart = prodInCart;
           

            return View();
        }
        public IActionResult AddToCart(int id)
        {
            return AddToCart(id, 1);
        }
       
        [HttpPost]
        public IActionResult AddToCart(int productId,int quantity)
        {
            string recentUserId = HttpContext.Request.Cookies["AccountId"];
            Cart usCart = _context.Carts.FirstOrDefault(cartt => cartt.AccountId == Int32.Parse(recentUserId) && cartt.ProductId == productId) ;
            if (usCart == null)
            {
                usCart = new Cart();
                usCart.AccountId = Int32.Parse(recentUserId);
                usCart.ProductId = productId;
                usCart.Quantity = quantity;
                _context.Carts.Add(usCart);
            }else
            {
                usCart.Quantity += quantity;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

       
        [HttpPost]
        public IActionResult Pay(Order order)
        {

            // 

            int recentUserId = Int32.Parse(HttpContext.Request.Cookies["AccountId"]);
            // Lấy tài khoản
            Account getAddress = _context.Accounts.Where(c => c.Id == recentUserId).First();
            // CẦN CHECK STOCK Ở ĐÂY

            //Thêm hóa đơn 
            DateTime now = DateTime.Now;
            order.AccountId = recentUserId;
            order.IssueDate = now;
            order.ShippingAddress = getAddress.Address1;
            order.Total= _context.Carts.Include(c => c.Account).Include(c => c.Product)
                                                        .Where(c => c.Account.Id == recentUserId)
                                                        .Sum(c => c.Quantity * c.Product.Price);


            
            _context.Add(order);
            _context.SaveChanges();

            //Them chi tiet hoa don
            List<Cart> carts = _context.Carts.Include(c => c.Product).Include(c => c.Account)
            .Where(c => c.Account.Id == recentUserId).ToList();
            
            foreach (Cart c in carts)
            {
                OrderDetail oddtail = new OrderDetail();
                oddtail.OrderId = order.Id;
                oddtail.ProductId = c.ProductId;
                oddtail.Quantity = c.Quantity;
                oddtail.Price = c.Product.Price;
                _context.Add(oddtail);
            }
            _context.SaveChanges();

            //remove giỏ hàng 
            // chưa trừ số lượng
            foreach(Cart c in carts)
            {
                _context.Carts.Remove(c);
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Home");
        }
            
            //public bool CheckStockInThisDay(int recentUser)
            //{
            //List<Cart> carts = _context.Carts.Include(c => c.Product).Include(c => c.Account)
            //.Where(c => c.Account.Id == recentUser).ToList();
            //}
        

    }
}
