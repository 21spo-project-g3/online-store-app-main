// Controllers/ShoppingCartController.cs
using Microsoft.AspNetCore.Mvc;

public class ShoppingCartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
