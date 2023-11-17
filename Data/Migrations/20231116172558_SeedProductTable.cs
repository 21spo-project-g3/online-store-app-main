using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace online_store_app.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "EAN", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "GeForce RTX 30 -sarjan grafiikkasuorittimet antavat äärimmäisen suorituskyvyn niin pelaajien kuin luovan työn tekijöidenkin käyttöön. Tehon salaisuus on Ampere – NVIDIAN toisen sukupolven RTX-arkkitehtuuri, jonka uudistetut RT- ja Tensor-ytimet sekä SM-monisuorittimet varmistavat tähän asti realistisimman säteenseurantagrafiikan ja huippuluokan tekoälytoiminnot", 4711081309925L, "Asus GeForce DUAL-RTX3060-O12G-V2", 299.99m },
                    { 2, "TUF Gaming GeForce RTX 4080 -näytönohjaimen NVIDIA Ada Lovelace -arkkitehtuurin tukena on tehokas jäähdytys ja virransyöttö sekä suorituskyvyn turvaavat vahvistukset. Lataa, varmista ja valmistaudu voittoon.", 4711081950745L, "Asus GeForce TUF-RTX4080-16G-GAMING", 1369.99m },
                    { 3, "AMD Radeon RX 7800 -sarja perustuvat uraauurtavaan AMD RDNA 3 -arkkitehtuuriin, jossa on chiplet-tekniikka, ja ne tarjoavat seuraavan sukupolven suorituskyvyn, visuaalisuuden ja tehokkuuden 4K-tasolla ja sen yli. Radeon RX 7800 -sarjan grafiikassa on edistykselliset AMD RDNA 3 -laskentayksiköt, toisen sukupolven säteenseuranta ja uudet tekoälykiihdyttimet, jotka tuottavat uskomatonta suorituskykyä ja maksimoivat graafisen tarkkuuden.", 4895106294349L, "Sapphire PULSE RX 7800 XT Gaming 16 Gt", 619.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
