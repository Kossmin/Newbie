using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CatName", "Description" },
                values: new object[,]
                {
                    { 1, "Music", "In rem consequatur libero totam voluptatem quos optio perferendis consequatur." },
                    { 2, "Sports", "Sapiente nostrum in quisquam in dolores est eos et natus." },
                    { 3, "Sports", "Sint veritatis blanditiis velit magni praesentium velit atque laboriosam reprehenderit." },
                    { 4, "Industrial", "Aperiam debitis enim rerum praesentium rem voluptatem deleniti magnam beatae." },
                    { 5, "Shoes", "Sed tempora officia ab earum dolore quis ut aut vero." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
