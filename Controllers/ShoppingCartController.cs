// Controllers/ShoppingCartController.cs
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Extensions; // Make sure to include the namespace
using online_store_app.Models;
using System;
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
            if (cart.ProductQuantities.Count == 0)
            {
                cart.CartTimestamp = DateTime.Now;
            }

            // Decrease the quantity
            if (cart.ProductQuantities.ContainsKey(product.Id) && cart.ProductQuantities[product.Id] > 0)
            {
                cart.ProductQuantities[product.Id]--;
                HttpContext.Session.Set("ShoppingCart", cart);

                // Update the quantity in the database
                var dbProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
                if (dbProduct != null)
                {
                    dbProduct.Quantity = cart.ProductQuantities[product.Id];
                    _context.SaveChanges();
                }
            }
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult RemoveFromCart(string ean)
    {
        var product = _context.Products.FirstOrDefault(p => p.EAN == ean);

        if (product != null)
        {
            var cart = HttpContext.Session.Get<ShoppingCart>("ShoppingCart") ?? new ShoppingCart();

            // Increase the quantity
            if (cart.ProductQuantities.ContainsKey(product.Id))
            {
                cart.ProductQuantities[product.Id]++;
                HttpContext.Session.Set("ShoppingCart", cart);

                // Update the quantity in the database
                var dbProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
                if (dbProduct != null)
                {
                    dbProduct.Quantity = cart.ProductQuantities[product.Id];
                    _context.SaveChanges();
                }
            }
        }

        return RedirectToAction("Index");
    }
}
