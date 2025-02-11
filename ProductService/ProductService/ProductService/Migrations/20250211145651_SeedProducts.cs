using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Industrial", "Iusto nisi at mollitia sed error totam facere voluptatibus maiores." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Beauty", "Ipsa minima similique incidunt modi harum animi qui sed sed." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Books", "Est veniam voluptates facilis quia doloremque quia quas exercitationem dolor." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Autem beatae sunt rem iusto qui dolorem consequatur doloribus exercitationem.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Health", "Quos laborum et distinctio tempore a perspiciatis labore minus iusto." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Active", "CategoryId", "DateCreated", "DateModified", "Desciption", "Price", "ProductName", "ShortDesc", "ThumbnailImageUrl", "UnitsInStock" },
                values: new object[,]
                {
                    { 6, true, 4, new DateTime(2023, 5, 12, 0, 50, 18, 922, DateTimeKind.Local).AddTicks(1987), new DateTime(2025, 2, 2, 22, 59, 56, 714, DateTimeKind.Local).AddTicks(2296), "Provident rerum eos eaque facere quasi sunt accusamus dicta. Nemo voluptas occaecati soluta iste soluta odit. Autem a quasi ullam aspernatur recusandae perspiciatis vitae. Officia magnam doloremque sint esse voluptatem error unde vel sunt.", 398.167649253092310m, "Sleek Fresh Bike", "A nobis modi asperiores tempora laudantium voluptatum et quis et.", "https://picsum.photos/640/480/?image=586", 85 },
                    { 7, false, 1, new DateTime(2024, 5, 5, 12, 45, 16, 474, DateTimeKind.Local).AddTicks(1542), new DateTime(2025, 2, 2, 20, 44, 4, 486, DateTimeKind.Local).AddTicks(346), "Molestiae amet dolore odio soluta. Illum ut est nesciunt eaque soluta deleniti porro. Aut ab provident eius. Modi deserunt consequatur tempora omnis et pariatur ut dolores sit. Fugit accusamus unde nobis fugiat dolor vel. Nisi ipsam vero a ea accusamus et.", 437.769931601895190m, "Fantastic Fresh Pizza", "Praesentium voluptatum dolorem a officia eveniet aut reiciendis provident vel.", "https://picsum.photos/640/480/?image=31", 70 },
                    { 8, true, 3, new DateTime(2025, 1, 3, 2, 2, 19, 891, DateTimeKind.Local).AddTicks(2891), new DateTime(2025, 2, 10, 11, 0, 14, 942, DateTimeKind.Local).AddTicks(762), "Quaerat autem placeat mollitia quis. Et veritatis in esse voluptas eaque rerum beatae. Et non sunt eum quaerat iusto quos. Ut consequatur voluptas occaecati reiciendis omnis inventore autem. Ab et dolores hic officiis unde tenetur. Quae illo autem aut repudiandae ad et eligendi saepe odio.", 282.742460548663070m, "Generic Granite Chicken", "Ullam totam et nulla voluptatem quisquam accusamus error dolor consequatur.", "https://picsum.photos/640/480/?image=537", 95 },
                    { 9, true, 4, new DateTime(2023, 11, 3, 15, 50, 50, 480, DateTimeKind.Local).AddTicks(7064), new DateTime(2025, 2, 6, 16, 54, 46, 197, DateTimeKind.Local).AddTicks(2723), "Et beatae voluptas. Voluptatum commodi dicta ut minima voluptatem molestias eius delectus sit. Accusantium ipsam impedit harum ut quia tenetur. Aliquam recusandae non voluptatem deserunt reiciendis blanditiis est beatae. Id consequatur quia et optio qui.", 436.626846146079670m, "Refined Plastic Shirt", "Deleniti quia fugiat voluptas voluptatem quam accusamus consequatur et voluptatem.", "https://picsum.photos/640/480/?image=572", 81 },
                    { 10, true, 1, new DateTime(2024, 5, 27, 6, 2, 49, 925, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 2, 2, 13, 40, 11, 704, DateTimeKind.Local).AddTicks(6033), "Sed magnam sit esse quae ad reprehenderit sit. Quos deserunt et fuga fuga aliquid fuga in rerum. Voluptatem cumque sed numquam labore nisi. Velit enim ratione sed. Magni doloremque rem enim asperiores. Occaecati modi libero sapiente et ea.", 76.164146122719960m, "Unbranded Steel Pizza", "Quidem soluta quidem sunt illum autem aut ipsa omnis corporis.", "https://picsum.photos/640/480/?image=1012", 1 },
                    { 11, true, 1, new DateTime(2024, 5, 7, 7, 8, 8, 742, DateTimeKind.Local).AddTicks(7633), new DateTime(2025, 2, 6, 21, 23, 18, 52, DateTimeKind.Local).AddTicks(2200), "Reiciendis officia temporibus est aut temporibus mollitia et ad. Nihil qui recusandae. Autem voluptatum aut qui ut totam sequi sequi. Soluta unde mollitia voluptates.", 212.214187725117540m, "Incredible Concrete Computer", "Culpa blanditiis aut qui error animi architecto et corrupti sunt.", "https://picsum.photos/640/480/?image=203", 5 },
                    { 12, true, 4, new DateTime(2024, 11, 13, 6, 12, 49, 358, DateTimeKind.Local).AddTicks(2362), new DateTime(2025, 2, 7, 16, 57, 34, 359, DateTimeKind.Local).AddTicks(2011), "Nemo ut quos expedita iure hic vel sit. Fuga iure rerum. In quaerat ut odit. Dolores inventore doloremque quod molestiae quo maxime.", 377.366501103182490m, "Unbranded Frozen Salad", "Voluptatem ratione beatae sit nihil non magni blanditiis distinctio quibusdam.", "https://picsum.photos/640/480/?image=692", 91 },
                    { 13, true, 5, new DateTime(2025, 1, 27, 11, 41, 10, 843, DateTimeKind.Local).AddTicks(559), new DateTime(2025, 2, 11, 2, 24, 55, 245, DateTimeKind.Local).AddTicks(6983), "Adipisci delectus eius et tempore ea nisi quia natus. Illum vero beatae nostrum. Quia repudiandae sint et exercitationem earum et voluptatem quia dolor. Ut corporis fuga.", 253.73474969949910m, "Fantastic Steel Chair", "Magnam et est assumenda recusandae debitis unde reprehenderit aut et.", "https://picsum.photos/640/480/?image=776", 78 },
                    { 14, false, 2, new DateTime(2024, 6, 9, 21, 3, 26, 89, DateTimeKind.Local).AddTicks(3940), new DateTime(2025, 2, 5, 10, 12, 43, 516, DateTimeKind.Local).AddTicks(646), "In qui maiores incidunt ipsam qui ullam in reiciendis deserunt. Suscipit vero dolorem explicabo velit nihil aut a ex eos. Quos nam tenetur blanditiis porro accusamus non ullam. Consequatur dignissimos occaecati magni voluptas tenetur aliquid assumenda dignissimos.", 478.391166738985560m, "Ergonomic Cotton Ball", "Aspernatur quisquam rerum aut iste necessitatibus sit nisi in reprehenderit.", "https://picsum.photos/640/480/?image=108", 92 },
                    { 15, true, 3, new DateTime(2024, 9, 12, 5, 32, 29, 471, DateTimeKind.Local).AddTicks(3371), new DateTime(2025, 2, 7, 2, 6, 12, 476, DateTimeKind.Local).AddTicks(9122), "Vitae aperiam voluptatem sint nam laudantium officiis earum. Quae ipsam occaecati nam velit recusandae officiis excepturi. Et neque omnis perspiciatis est doloremque necessitatibus commodi id facere.", 302.4385855536950m, "Sleek Plastic Hat", "Quos animi quod sint earum debitis temporibus voluptas ut similique.", "https://picsum.photos/640/480/?image=580", 70 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Music", "In rem consequatur libero totam voluptatem quos optio perferendis consequatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Sports", "Sapiente nostrum in quisquam in dolores est eos et natus." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Sports", "Sint veritatis blanditiis velit magni praesentium velit atque laboriosam reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Aperiam debitis enim rerum praesentium rem voluptatem deleniti magnam beatae.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CatName", "Description" },
                values: new object[] { "Shoes", "Sed tempora officia ab earum dolore quis ut aut vero." });
        }
    }
}
