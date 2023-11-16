using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using online_store_app.Models;

namespace online_store_app.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Gaming", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Picture & sound", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Phones & tablets", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Hobbies & free time", DisplayOrder = 5 }
                );

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(12,2)");
        }
    }
}