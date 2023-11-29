// Controllers/AdminController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Authorize(Policy = "AdminOnly")]
    public IActionResult InventoryManagement()
    {
        var lowQuantityProducts = _context.Products.Where(p => p.Quantity < 1000).ToList(); //Adjust what quantity level product is shown, currently show all products
        return View(lowQuantityProducts);
    }


}
