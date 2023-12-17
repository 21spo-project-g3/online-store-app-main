// Models/ShoppingCart.cs
using System;
using System.Collections.Generic;

namespace online_store_app.Models
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new List<Product>();
        public DateTime? CartTimestamp { get; set; } // Nullable DateTime to store when the cart was created
    }
}
