// Controllers/ShoppingCartController.cs
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Extensions; // Make sure to include the namespace
using online_store_app.Models;
using System.Linq;

public class ShoppingCartController : Controller
{
    private readonly ApplicationDbContext _context;

    public ShoppingCartController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var cart = HttpContext.Session.Get<ShoppingCart>("ShoppingCart") ?? new ShoppingCart();
        var model = new List<ShoppingCart> { cart }; // Wrap the cart in a list
        return View(model);
    }

    [HttpPost]
    public IActionResult AddToCart(string ean)
    {
        var product = _context.Products.FirstOrDefault(p => p.EAN == ean);

        if (product != null)
        {
            var cart = HttpContext.Session.Get<ShoppingCart>("ShoppingCart") ?? new ShoppingCart();

            // If the cart is empty, set the timestamp
            if (cart.Items.Count == 0)
            {
                cart.CartTimestamp = DateTime.Now;
            }

            // Decrease the quantity
            if (product.Quantity > 0)
            {
                product.Quantity--;
                cart.Items.Add(product);
                HttpContext.Session.Set("ShoppingCart", cart);

                // Update the quantity in the database
                var dbProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
                if (dbProduct != null)
                {
                    dbProduct.Quantity = product.Quantity;
                    _context.SaveChanges();
                }
            }
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult RemoveFromCart(string ean)
    {
        var cart = HttpContext.Session.Get<ShoppingCart>("ShoppingCart") ?? new ShoppingCart();
        var productToRemove = cart.Items.FirstOrDefault(p => p.EAN == ean);

        if (productToRemove != null)
        {
            // Increase the quantity
            productToRemove.Quantity++;
            cart.Items.Remove(productToRemove);
            HttpContext.Session.Set("ShoppingCart", cart);

            // Update the quantity in the database
            var dbProduct = _context.Products.FirstOrDefault(p => p.Id == productToRemove.Id);
            if (dbProduct != null)
            {
                dbProduct.Quantity = productToRemove.Quantity;
                _context.SaveChanges();
            }
        }

        return RedirectToAction("Index");
    }
}
