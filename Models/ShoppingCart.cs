// Models/ShoppingCart.cs
namespace online_store_app.Models
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new List<Product>();
    }
}