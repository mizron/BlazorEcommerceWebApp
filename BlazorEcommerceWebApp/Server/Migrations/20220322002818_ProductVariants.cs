using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerceWebApp.Server.Migrations
{
    public partial class ProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Default" },
                    { 2, "E-book" },
                    { 3, "Paperback" },
                    { 4, "Hardback" },
                    { 5, "Disc Edition" },
                    { 6, "Digital Edition" },
                    { 7, "Series X" },
                    { 8, "Series S" },
                    { 9, "PLayStation 4" },
                    { 10, "PC" },
                    { 11, "PlayStation 5" },
                    { 12, "Xbox" },
                    { 13, "M1 Processor" },
                    { 14, "Intel i5 Processor" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Xbox Series S/X is a home video game consoles developed by Microsoft.", "Xbox" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "Spider-Man");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "God of War");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Halo Infinite");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Call of Duty: Vanguard");

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 5, 699.99m, 699.99m },
                    { 1, 6, 599.99m, 599.99m },
                    { 2, 7, 749.99m, 749.99m },
                    { 2, 8, 549.99m, 549.99m },
                    { 3, 13, 1899.99m, 1899.99m },
                    { 3, 14, 1999.99m, 1999.99m },
                    { 4, 2, 0m, 9.99m },
                    { 4, 3, 0m, 19.99m },
                    { 4, 4, 0m, 29.99m },
                    { 5, 2, 0m, 9.99m },
                    { 5, 3, 0m, 19.99m },
                    { 5, 4, 0m, 29.99m },
                    { 6, 2, 0m, 9.99m },
                    { 6, 3, 0m, 19.99m },
                    { 6, 4, 0m, 29.99m },
                    { 7, 9, 49.99m, 49.99m },
                    { 7, 10, 499.99m, 49.99m },
                    { 7, 11, 69.99m, 69.99m },
                    { 7, 12, 69.99m, 69.99m },
                    { 8, 9, 49.99m, 49.99m },
                    { 8, 10, 499.99m, 49.99m },
                    { 8, 11, 69.99m, 69.99m },
                    { 8, 12, 69.99m, 69.99m },
                    { 9, 9, 49.99m, 49.99m },
                    { 9, 10, 499.99m, 49.99m },
                    { 9, 11, 69.99m, 69.99m },
                    { 9, 12, 69.99m, 69.99m },
                    { 10, 9, 49.99m, 49.99m },
                    { 10, 10, 499.99m, 49.99m },
                    { 10, 11, 69.99m, 69.99m },
                    { 10, 12, 69.99m, 69.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 699.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "The Xbox Series X is a home video game consoles developed by Microsoft.", 599.99m, "Xbox Series X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 1799.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 9.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 7.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 6.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Title" },
                values: new object[] { 69.99m, "Spider-Man (Ps4)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "Title" },
                values: new object[] { 59.99m, "God of War (Ps5)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "Title" },
                values: new object[] { 89.99m, "Halo Infinite (Xbox)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "Title" },
                values: new object[] { 99.99m, "Call of Duty: Vanguard (PC)" });
        }
    }
}
