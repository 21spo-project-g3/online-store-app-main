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

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Asus GeForce DUAL-RTX3060-O12G-V2",
                    Description = "GeForce RTX 30 -sarjan grafiikkasuorittimet antavat äärimmäisen suorituskyvyn niin pelaajien kuin luovan työn tekijöidenkin käyttöön. Tehon salaisuus on Ampere – NVIDIAN toisen sukupolven RTX-arkkitehtuuri, jonka uudistetut RT- ja Tensor-ytimet sekä SM-monisuorittimet varmistavat tähän asti realistisimman säteenseurantagrafiikan ja huippuluokan tekoälytoiminnot",
                    Price = 299.99,
                    EAN = 4711081309925,
                    ImageUrl = "https://i.imgur.com/azEiXOi.png"
                },
                new Product
                {
                    Id = 2,
                    Name = "Asus GeForce TUF-RTX4080-16G-GAMING",
                    Description = "TUF Gaming GeForce RTX 4080 -näytönohjaimen NVIDIA Ada Lovelace -arkkitehtuurin tukena on tehokas jäähdytys ja virransyöttö sekä suorituskyvyn turvaavat vahvistukset. Lataa, varmista ja valmistaudu voittoon.",
                    Price = 1369.99,
                    EAN = 4711081950745,
                    ImageUrl = "https://i.imgur.com/agJa6nK.png"
                },
                new Product
                {
                    Id = 3,
                    Name = "Sapphire PULSE RX 7800 XT Gaming 16 Gt",
                    Description = "AMD Radeon RX 7800 -sarja perustuvat uraauurtavaan AMD RDNA 3 -arkkitehtuuriin, jossa on chiplet-tekniikka, ja ne tarjoavat seuraavan sukupolven suorituskyvyn, visuaalisuuden ja tehokkuuden 4K-tasolla ja sen yli. Radeon RX 7800 -sarjan grafiikassa on edistykselliset AMD RDNA 3 -laskentayksiköt, toisen sukupolven säteenseuranta ja uudet tekoälykiihdyttimet, jotka tuottavat uskomatonta suorituskykyä ja maksimoivat graafisen tarkkuuden.",
                    Price = 619.99,
                    EAN = 4895106294349,
                    ImageUrl = "https://i.imgur.com/LUvFWCe.png"
                }
                );

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(12,2)");
        }
    }
}