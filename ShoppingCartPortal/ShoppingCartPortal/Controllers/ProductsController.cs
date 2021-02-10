using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using ShoppingCartPortal.Data;
using ShoppingCartPortal.Models;

namespace ShoppingCartPortal.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        public async Task<IActionResult> Shop()
        {
            var products = await _context.Product.OrderBy(d => d.ProductName).ToListAsync();
            return View(products);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(IFormCollection form)
        {
            var qty = int.Parse(form["Qty"]);
            var productId = int.Parse(form["ProductId"]);
            var price = decimal.Parse(form["Price"]);

            IList<Cart> carts = new List<Cart>();
            carts = GetCart();
            carts.Add(new Cart()
            {
                Price = price,
                ProductId = productId,
                Qty = qty
            });

            var cartString = JsonConvert.SerializeObject(carts);

            HttpContext.Session.SetString("MyCart", cartString);
            return RedirectToAction("Shop");
        }

        private IList<Cart> GetCart()
        {
            var myCartString = HttpContext.Session.GetString("MyCart");
            IList<Cart> carts = new List<Cart>();
            if (myCartString != null)
            {
                carts = (IList<Cart>)JsonConvert.DeserializeObject(myCartString, typeof(IList<Cart>));
            }
            return carts;
        }

        [Authorize]
        public IActionResult Cart()
        {
            var myCart = GetCart();

            if (myCart.Count > 0)
            {
                foreach (var item in myCart)
                {
                    var thisProduct = _context.Product.Find(item.ProductId);
                    item.ProductName = thisProduct.ProductName;
                    item.ImageName = thisProduct.ImageName;
                }
            }
            return View(myCart);
        }

        public IActionResult Checkout()
        {
            var myCart = GetCart();
            var orderAmount = myCart.Sum(d => (d.Price * d.Qty));

            // add the order first
            Order order = new Order()
            {
                OrderAmount = orderAmount,
                OrderDate = DateTime.Now,
                UserId = User.Identity.Name
            };
            _context.Add(order);
            _context.SaveChanges();

            // now save the order details
            foreach (var item in myCart)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    Qty = item.Qty
                };
                _context.Add(orderDetail);
                _context.SaveChanges();
            }

            // empty the cart now
            HttpContext.Session.Remove("MyCart");

            return View(order);
        }

        public IActionResult MyOrders()
        {
            var orders = _context.Order.Where(d => d.UserId == User.Identity.Name).ToList();
            return View(orders);
        }

        public IActionResult OrderDetails(int id)
        {
            // first find the order
            var order = _context.Order.Find(id);

            // find the order details
            var orderDetails = _context.OrderDetail.Include(d => d.Product).Where(d => d.OrderId == id).ToList();
            ViewBag.OrderDetails = orderDetails;

            return View(order);

        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Qty,Price,ImageName")] Product product, IFormFile ImageName)
        {
            if (ModelState.IsValid)
            {
                // check and upload the file
                if (ImageName.Length > 0)
                {
                    string path = Environment.CurrentDirectory;
                    string fullName = Path.Combine(path, "wwwroot", "Images", ImageName.FileName);

                    using (var stream = System.IO.File.Create(fullName))
                    {
                        await ImageName.CopyToAsync(stream);
                    }
                    product.ImageName = ImageName.FileName;
                    _context.Add(product);
                }
                await _context.SaveChangesAsync();
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

            var product = await _context.Product.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Qty,Price,ImageName")] Product product)
        {
            if (id != product.ProductId)
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
                    if (!ProductExists(product.ProductId))
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

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
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
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}
