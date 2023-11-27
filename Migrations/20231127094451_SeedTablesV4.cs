using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_store_app.Migrations
{
    /// <inheritdoc />
    public partial class SeedTablesV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EAN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "GeForce RTX 30 series graphics processors provide extreme performance for both gamers and creative workers. The secret to power is Ampere - NVIDIA's second-generation RTX architecture, with renewed RT and Tensor cores and SM multiprocessors ensuring the most realistic ray-tracing graphics and state-of-the-art AI functions yet", "4711081309925" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "The NVIDIA Ada Lovelace architecture of the TUF Gaming GeForce RTX 4080 graphics card is supported by efficient cooling and power supply, as well as performance-enhancing reinforcements. Download, secure and prepare to win.", "4711081950745" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "Based on the groundbreaking AMD RDNA 3 architecture with chiplet technology, the AMD Radeon RX 7800 series delivers next-generation performance, visuals and efficiency at 4K and beyond. The Radeon RX 7800 series graphics feature advanced AMD RDNA 3 compute units, second-generation ray tracing, and new AI accelerators to deliver incredible performance and maximize graphic fidelity.", "4895106294349" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "The PS5 console offers new, unexpected gaming possibilities. Enjoy lightning-fast charging, ultra-fast SSD drive and immersive features such as haptic feedback, adaptive triggers, 3D sound and a brand new generation of PlayStation games.", "0711719576778" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "The Microsoft Xbox Series X offers the most powerful Xbox console we've seen. Xbox Series X offers consoles unprecedented power and performance in a stunning package. The console is equipped with a disc drive, so you can enjoy not only digital games but also physical games on discs.", "0889842640809" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "EAN",
                value: "0711719399506");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "Samsung CU7172 / CU7192 in 55 inch size is Samsung's Crystal UHD TV. The high-definition 4K UHD resolution really comes to life when you watch HDR material from the most popular streaming services supported by the Tizen 2023 operating system.", "8806094853483" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "OnePlus Open is a phone with a folding screen that does not compromise on the camera. The revolutionary Hasselblad mobile camera system with three Pro-level cameras, highlighted by Sony's new LYTIA \"Pixel Stacked\" sensor. The OnePlus Open's camera capabilities have not been compromised, even in a compact and slim size. Three cameras, each of which stands at its best alongside conventional non-folding flagship phones. You can be sure that every moment and angle can be captured with uncompromising clarity.", "6921815625674" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "Apple iPhone 13. The most advanced iPhone dual camera system. Lightning fast A15 Bionic chip. Big leap in battery life. Durable construction. Super fast 5G. And a brighter Super Retina XDR display.", "0194252903834" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "Baana Flesu has been striving to be the most handsome fat bike in town for seven years, always with a little improvement!\r\nA good and affordable fatbike with an excellent price-quality ratio keeps things simple and is still badass. The sturdy aluminum is a durable and light frame compared to the steel of the cheapest fat bikes. The suspension provided by the thick tires makes the ride smooth, so you don't need a separate suspension.", "6438148036997" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "EAN",
                table: "Products",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "GeForce RTX 30 -sarjan grafiikkasuorittimet antavat äärimmäisen suorituskyvyn niin pelaajien kuin luovan työn tekijöidenkin käyttöön. Tehon salaisuus on Ampere – NVIDIAN toisen sukupolven RTX-arkkitehtuuri, jonka uudistetut RT- ja Tensor-ytimet sekä SM-monisuorittimet varmistavat tähän asti realistisimman säteenseurantagrafiikan ja huippuluokan tekoälytoiminnot", 4711081309925L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "TUF Gaming GeForce RTX 4080 -näytönohjaimen NVIDIA Ada Lovelace -arkkitehtuurin tukena on tehokas jäähdytys ja virransyöttö sekä suorituskyvyn turvaavat vahvistukset. Lataa, varmista ja valmistaudu voittoon.", 4711081950745L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "AMD Radeon RX 7800 -sarja perustuvat uraauurtavaan AMD RDNA 3 -arkkitehtuuriin, jossa on chiplet-tekniikka, ja ne tarjoavat seuraavan sukupolven suorituskyvyn, visuaalisuuden ja tehokkuuden 4K-tasolla ja sen yli. Radeon RX 7800 -sarjan grafiikassa on edistykselliset AMD RDNA 3 -laskentayksiköt, toisen sukupolven säteenseuranta ja uudet tekoälykiihdyttimet, jotka tuottavat uskomatonta suorituskykyä ja maksimoivat graafisen tarkkuuden.", 4895106294349L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "PS5-konsoli tarjoaa uusia, odottamattomia pelimahdollisuuksia. Nauti salamannopeasta latauksesta, erittäin nopeasta SSD-asemasta ja mukaansatempaavista toiminnoista, kuten kosketuspalautteesta, mukautuvista liipaisimista, 3D-äänestä ja upouudesta PlayStation-pelien sukupolvesta.", 711719576778L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "Microsoft Xbox Series X tarjoaa tehokkaimman Xbox-konsolin mitä olemme nähneet. Xbox Series X tarjoaa konsoleille ennennäkemätöntä tehoa ja suorituskykyä upeassa paketissa. Konsoli on varustettu levyasemalla joten voit nauttia digitaalisten pelien lisäksi myös fyysisistä peleistä levyillä.", 889842640809L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "EAN",
                value: 711719399506L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "TV", 8806094853483L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "5G phone", 6921815625674L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "5G phone", 194252903834L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EAN" },
                values: new object[] { "free time", 6438148036997L });
        }
    }
}
