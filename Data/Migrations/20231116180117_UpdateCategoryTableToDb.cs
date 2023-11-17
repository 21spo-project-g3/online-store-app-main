using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_store_app.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "In the Turrbobuy selection, there is technology for every departure. So if the search includes a computer or its peripherals, you will find them.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "In the Turrbobuy selection, there is technology for every departure. So if the search includes a computer or its peripherals, you will find them.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "In the Turrbobuy selection, there is technology for every departure. So if the search includes a computer or its peripherals, you will find them.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "In the Turrbobuy selection, there is technology for every departure. So if the search includes a computer or its peripherals, you will find them.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "In the Turrbobuy selection, there is technology for every departure. So if the search includes a computer or its peripherals, you will find them.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");
        }
    }
}
