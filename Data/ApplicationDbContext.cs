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
        
        public List<Product> GetProductsByCategory(string categoryName)
        {
            var products = Products
                .Where(p => p.Category.Name == categoryName)
                .ToList();
            return products;
        }

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

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Asus GeForce DUAL-RTX3060-O12G-V2 Graphics card",
                    Description = "GeForce RTX 30 series graphics processors provide extreme performance for both gamers and creative workers. The secret to power is Ampere - NVIDIA's second-generation RTX architecture, with renewed RT and Tensor cores and SM multiprocessors ensuring the most realistic ray-tracing graphics and state-of-the-art AI functions yet",
                    Price = 299.99,
                    EAN = "4711081309925",
                    ImageUrl = "https://i.imgur.com/azEiXOi.png",
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Asus GeForce TUF-RTX4080-16G-GAMING Graphics card",
                    Description = "The NVIDIA Ada Lovelace architecture of the TUF Gaming GeForce RTX 4080 graphics card is supported by efficient cooling and power supply, as well as performance-enhancing reinforcements. Download, secure and prepare to win.",
                    Price = 1369.99,
                    EAN = "4711081950745",
                    ImageUrl = "https://i.imgur.com/agJa6nK.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Sapphire PULSE RX 7800 XT Gaming 16 Gt Graphics card",
                    Description = "Based on the groundbreaking AMD RDNA 3 architecture with chiplet technology, the AMD Radeon RX 7800 series delivers next-generation performance, visuals and efficiency at 4K and beyond. The Radeon RX 7800 series graphics feature advanced AMD RDNA 3 compute units, second-generation ray tracing, and new AI accelerators to deliver incredible performance and maximize graphic fidelity.",
                    Price = 619.99,
                    EAN = "4895106294349",
                    ImageUrl = "https://i.imgur.com/LUvFWCe.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Sony PlayStation 5 (PS5) Call of Duty: Modern Warfare III Console & Game bundle",
                    Description = "The PS5 console offers new, unexpected gaming possibilities. Enjoy lightning-fast charging, ultra-fast SSD drive and immersive features such as haptic feedback, adaptive triggers, 3D sound and a brand new generation of PlayStation games.",
                    Price = 489.99,
                    EAN = "0711719576778",
                    ImageUrl = "https://i.imgur.com/lIqutAw.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Name = "Microsoft Xbox Series X Console",
                    Description = "The Microsoft Xbox Series X offers the most powerful Xbox console we've seen. Xbox Series X offers consoles unprecedented power and performance in a stunning package. The console is equipped with a disc drive, so you can enjoy not only digital games but also physical games on discs.",
                    Price = 438.99,
                    EAN = "0889842640809",
                    ImageUrl = "https://i.imgur.com/Ty8T94a.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Name = "Sony DualSense Gaming Controller, white, PS5",
                    Description = "PlayStation 5's DualSense wireless controller features haptic feedback that brings you closer to games, dynamically adaptive triggers and a built-in microphone – all in the same iconic controller.",
                    Price = 49.99,
                    EAN = "0711719399506",
                    ImageUrl = "https://i.imgur.com/MwlBwh7.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Samsung CU7172 55\" 4K LED TV",
                    Description = "Samsung CU7172 / CU7192 in 55 inch size is Samsung's Crystal UHD TV. The high-definition 4K UHD resolution really comes to life when you watch HDR material from the most popular streaming services supported by the Tizen 2023 operating system.",
                    Price = 399.99,
                    EAN = "8806094853483",
                    ImageUrl = "https://i.imgur.com/q6S6KYM.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 8,
                    Name = "OnePlus Open 5G Phone, 512/16 Gb, green",
                    Description = "OnePlus Open is a phone with a folding screen that does not compromise on the camera. The revolutionary Hasselblad mobile camera system with three Pro-level cameras, highlighted by Sony's new LYTIA \"Pixel Stacked\" sensor. The OnePlus Open's camera capabilities have not been compromised, even in a compact and slim size. Three cameras, each of which stands at its best alongside conventional non-folding flagship phones. You can be sure that every moment and angle can be captured with uncompromising clarity.",
                    Price = 1799.99,
                    EAN = "6921815625674",
                    ImageUrl = "https://i.imgur.com/yfFoVkO.png",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 9,
                    Name = "Apple iPhone 13 128GB Phone, Midnight",
                    Description = "Apple iPhone 13. The most advanced iPhone dual camera system. Lightning fast A15 Bionic chip. Big leap in battery life. Durable construction. Super fast 5G. And a brighter Super Retina XDR display.",
                    Price = 668.99,
                    EAN = "0194252903834",
                    ImageUrl = "https://i.imgur.com/vLN5QGj.png",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 10,
                    Name = "Baana Flesu 26\" SE fatbike",
                    Description = "Baana Flesu has been striving to be the most handsome fat bike in town for seven years, always with a little improvement!\r\nA good and affordable fatbike with an excellent price-quality ratio keeps things simple and is still badass. The sturdy aluminum is a durable and light frame compared to the steel of the cheapest fat bikes. The suspension provided by the thick tires makes the ride smooth, so you don't need a separate suspension.",
                    Price = 399.99,
                    EAN = "6438148036997",
                    ImageUrl = "https://i.imgur.com/WKvJ5s8.png",
                    CategoryId = 5
                }
                );

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(12,2)");
        }
    }
}