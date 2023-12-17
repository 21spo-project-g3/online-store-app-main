// CheckoutController.cs
using Microsoft.AspNetCore.Mvc;
using online_store_app.Extensions;

public class CheckoutController : Controller
{
    public IActionResult Index()
    {
        var checkoutModel = new CheckoutModel();
        return View(checkoutModel);
    }

    [HttpPost]
    public IActionResult PlaceOrder(CheckoutModel model)
    {
        // Process the order (replace this with your actual order processing logic)

        // Clear the shopping cart
        HttpContext.Session.Remove("ShoppingCart");

        // Redirect to the order confirmation page
        return RedirectToAction("OrderConfirmation");
    }

    public IActionResult OrderConfirmation()
    {
        return View();
    }
}
