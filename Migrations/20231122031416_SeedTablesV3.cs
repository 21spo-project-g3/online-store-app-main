using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace online_store_app.Migrations
{
    /// <inheritdoc />
    public partial class SeedTablesV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Asus GeForce DUAL-RTX3060-O12G-V2 Graphics card");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Asus GeForce TUF-RTX4080-16G-GAMING Graphics card");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Sapphire PULSE RX 7800 XT Gaming 16 Gt Graphics card");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EAN", "ImageUrl", "Name", "Price" },
                values: new object[] { "PS5-konsoli tarjoaa uusia, odottamattomia pelimahdollisuuksia. Nauti salamannopeasta latauksesta, erittäin nopeasta SSD-asemasta ja mukaansatempaavista toiminnoista, kuten kosketuspalautteesta, mukautuvista liipaisimista, 3D-äänestä ja upouudesta PlayStation-pelien sukupolvesta.", 711719576778L, "https://i.imgur.com/lIqutAw.png", "Sony PlayStation 5 (PS5) Call of Duty: Modern Warfare III Console & Game bundle", 489.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "EAN", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 5, 2, "Microsoft Xbox Series X tarjoaa tehokkaimman Xbox-konsolin mitä olemme nähneet. Xbox Series X tarjoaa konsoleille ennennäkemätöntä tehoa ja suorituskykyä upeassa paketissa. Konsoli on varustettu levyasemalla joten voit nauttia digitaalisten pelien lisäksi myös fyysisistä peleistä levyillä.", 889842640809L, "https://i.imgur.com/Ty8T94a.png", "Microsoft Xbox Series X Console", 438.99m },
                    { 6, 2, "PlayStation 5's DualSense wireless controller features haptic feedback that brings you closer to games, dynamically adaptive triggers and a built-in microphone – all in the same iconic controller.", 711719399506L, "https://i.imgur.com/MwlBwh7.png", "Sony DualSense Gaming Controller, white, PS5", 49.99m },
                    { 7, 3, "TV", 8806094853483L, "https://i.imgur.com/q6S6KYM.png", "Samsung CU7172 55\" 4K LED TV", 399.99m },
                    { 8, 4, "5G phone", 6921815625674L, "https://i.imgur.com/yfFoVkO.png", "OnePlus Open 5G Phone, 512/16 Gb, green", 1799.99m },
                    { 9, 4, "5G phone", 194252903834L, "https://i.imgur.com/vLN5QGj.png", "Apple iPhone 13 128GB Phone, Midnight", 668.99m },
                    { 10, 5, "free time", 6438148036997L, "https://i.imgur.com/WKvJ5s8.png", "Baana Flesu 26\" SE fatbike", 399.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Asus GeForce DUAL-RTX3060-O12G-V2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Asus GeForce TUF-RTX4080-16G-GAMING");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Sapphire PULSE RX 7800 XT Gaming 16 Gt");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EAN", "ImageUrl", "Name", "Price" },
                values: new object[] { "test", 4895106294349L, "https://i.imgur.com/LUvFWCe.png", "test", 1111m });
        }
    }
}
