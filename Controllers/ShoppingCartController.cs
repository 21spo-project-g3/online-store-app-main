// Controllers/ShoppingCartController.cs
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Extensions; // Make sure to include the namespace
using online_store_app.Models;
using System;
using System.Collections.Generic;

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

            cart.Items.Add(product);
            HttpContext.Session.Set("ShoppingCart", cart);
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
            cart.Items.Remove(productToRemove);
            HttpContext.Session.Set("ShoppingCart", cart);
        }

        return RedirectToAction("Index");
    }

}
