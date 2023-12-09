using Microsoft.AspNetCore.Identity;
using online_store_app.Models;

namespace online_store_app.Data
{
    public class ApplicationUser : IdentityUser
    {
        public Address UserAddress { get; set; }
    }
}