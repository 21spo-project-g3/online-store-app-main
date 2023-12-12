// Controllers/SaleController.cs
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using System.Linq;

public class SaleController : Controller
{
    private readonly ApplicationDbContext _context;

    public SaleController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var onSaleProducts = _context.Products.Where(p => p.IsOnSale).ToList();
        return View(onSaleProducts);
    }
}
