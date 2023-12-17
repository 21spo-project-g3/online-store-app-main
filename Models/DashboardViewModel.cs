//Models/DashboardViewModel.cs
using online_store_app.Models;
using System.Collections.Generic;

namespace online_store_app.ViewModels
{
    public class DashboardViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
