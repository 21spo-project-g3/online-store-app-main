// Controllers/ShoppingCartController.cs
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Models; // Make sure to include the namespace

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
