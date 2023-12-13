using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Models;
using System.Collections.Generic;
using System.Linq;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public HomeController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Search(string query)
    {
        // Perform search logic
        List<Product> searchResults = _dbContext.Products
            .Where(p => p.Name.Contains(query))
            .ToList();

        return View("Search", searchResults);
    }
}
