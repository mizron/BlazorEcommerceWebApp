using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerceWebApp.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment.", "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png", 699.99m, "PlayStation 5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The Xbox Series X is a home video game consoles developed by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/7/7d/Xbox_series_X_%2850648118708%29.jpg", 599.99m, "Xbox Series X" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "The MacBook Pro is a line of Macintosh notebook computers introduced in January 2006 by Apple Inc.", "https://upload.wikimedia.org/wikipedia/commons/9/9a/Late_2016_MacBook_Pro.jpg", 1799.99m, "Macbook Pro" });
        }

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
