using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_store_app.Migrations
{
    /// <inheritdoc />
    public partial class SeedTablesV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "EAN", "ImageUrl", "Name", "Price" },
                values: new object[] { 4, 2, "test", 4895106294349L, "https://i.imgur.com/LUvFWCe.png", "test", 1111m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
