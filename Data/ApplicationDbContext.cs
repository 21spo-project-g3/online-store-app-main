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
                    Description = "GeForce RTX 30 -sarjan grafiikkasuorittimet antavat äärimmäisen suorituskyvyn niin pelaajien kuin luovan työn tekijöidenkin käyttöön. Tehon salaisuus on Ampere – NVIDIAN toisen sukupolven RTX-arkkitehtuuri, jonka uudistetut RT- ja Tensor-ytimet sekä SM-monisuorittimet varmistavat tähän asti realistisimman säteenseurantagrafiikan ja huippuluokan tekoälytoiminnot",
                    Price = 299.99,
                    EAN = 4711081309925,
                    ImageUrl = "https://i.imgur.com/azEiXOi.png",
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Asus GeForce TUF-RTX4080-16G-GAMING Graphics card",
                    Description = "TUF Gaming GeForce RTX 4080 -näytönohjaimen NVIDIA Ada Lovelace -arkkitehtuurin tukena on tehokas jäähdytys ja virransyöttö sekä suorituskyvyn turvaavat vahvistukset. Lataa, varmista ja valmistaudu voittoon.",
                    Price = 1369.99,
                    EAN = 4711081950745,
                    ImageUrl = "https://i.imgur.com/agJa6nK.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Sapphire PULSE RX 7800 XT Gaming 16 Gt Graphics card",
                    Description = "AMD Radeon RX 7800 -sarja perustuvat uraauurtavaan AMD RDNA 3 -arkkitehtuuriin, jossa on chiplet-tekniikka, ja ne tarjoavat seuraavan sukupolven suorituskyvyn, visuaalisuuden ja tehokkuuden 4K-tasolla ja sen yli. Radeon RX 7800 -sarjan grafiikassa on edistykselliset AMD RDNA 3 -laskentayksiköt, toisen sukupolven säteenseuranta ja uudet tekoälykiihdyttimet, jotka tuottavat uskomatonta suorituskykyä ja maksimoivat graafisen tarkkuuden.",
                    Price = 619.99,
                    EAN = 4895106294349,
                    ImageUrl = "https://i.imgur.com/LUvFWCe.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Sony PlayStation 5 (PS5) Call of Duty: Modern Warfare III Console & Game bundle",
                    Description = "PS5-konsoli tarjoaa uusia, odottamattomia pelimahdollisuuksia. Nauti salamannopeasta latauksesta, erittäin nopeasta SSD-asemasta ja mukaansatempaavista toiminnoista, kuten kosketuspalautteesta, mukautuvista liipaisimista, 3D-äänestä ja upouudesta PlayStation-pelien sukupolvesta.",
                    Price = 489.99,
                    EAN = 0711719576778,
                    ImageUrl = "https://i.imgur.com/lIqutAw.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Name = "Microsoft Xbox Series X Console",
                    Description = "Microsoft Xbox Series X tarjoaa tehokkaimman Xbox-konsolin mitä olemme nähneet. Xbox Series X tarjoaa konsoleille ennennäkemätöntä tehoa ja suorituskykyä upeassa paketissa. Konsoli on varustettu levyasemalla joten voit nauttia digitaalisten pelien lisäksi myös fyysisistä peleistä levyillä.",
                    Price = 438.99,
                    EAN = 0889842640809,
                    ImageUrl = "https://i.imgur.com/Ty8T94a.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Name = "Sony DualSense Gaming Controller, white, PS5",
                    Description = "PlayStation 5's DualSense wireless controller features haptic feedback that brings you closer to games, dynamically adaptive triggers and a built-in microphone – all in the same iconic controller.",
                    Price = 49.99,
                    EAN = 0711719399506,
                    ImageUrl = "https://i.imgur.com/MwlBwh7.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Samsung CU7172 55\" 4K LED TV",
                    Description = "TV",
                    Price = 399.99,
                    EAN = 8806094853483,
                    ImageUrl = "https://i.imgur.com/q6S6KYM.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 8,
                    Name = "OnePlus Open 5G Phone, 512/16 Gb, green",
                    Description = "5G phone",
                    Price = 1799.99,
                    EAN = 6921815625674,
                    ImageUrl = "https://i.imgur.com/yfFoVkO.png",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 9,
                    Name = "Apple iPhone 13 128GB Phone, Midnight",
                    Description = "5G phone",
                    Price = 668.99,
                    EAN = 0194252903834,
                    ImageUrl = "https://i.imgur.com/vLN5QGj.png",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 10,
                    Name = "Baana Flesu 26\" SE fatbike",
                    Description = "free time",
                    Price = 399.99,
                    EAN = 6438148036997,
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