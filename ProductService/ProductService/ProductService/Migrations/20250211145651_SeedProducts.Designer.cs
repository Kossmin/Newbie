﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductService.Models;

#nullable disable

namespace ProductService.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20250211145651_SeedProducts")]
    partial class SeedProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ProductService.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CatName")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatName = "Industrial",
                            Description = "Iusto nisi at mollitia sed error totam facere voluptatibus maiores."
                        },
                        new
                        {
                            Id = 2,
                            CatName = "Beauty",
                            Description = "Ipsa minima similique incidunt modi harum animi qui sed sed."
                        },
                        new
                        {
                            Id = 3,
                            CatName = "Books",
                            Description = "Est veniam voluptates facilis quia doloremque quia quas exercitationem dolor."
                        },
                        new
                        {
                            Id = 4,
                            CatName = "Industrial",
                            Description = "Autem beatae sunt rem iusto qui dolorem consequatur doloribus exercitationem."
                        },
                        new
                        {
                            Id = 5,
                            CatName = "Health",
                            Description = "Quos laborum et distinctio tempore a perspiciatis labore minus iusto."
                        });
                });

            modelBuilder.Entity("ProductService.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Desciption")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("longtext");

                    b.Property<string>("ThumbnailImageUrl")
                        .HasColumnType("longtext");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 6,
                            Active = true,
                            CategoryId = 4,
                            DateCreated = new DateTime(2023, 5, 12, 0, 50, 18, 922, DateTimeKind.Local).AddTicks(1987),
                            DateModified = new DateTime(2025, 2, 2, 22, 59, 56, 714, DateTimeKind.Local).AddTicks(2296),
                            Desciption = "Provident rerum eos eaque facere quasi sunt accusamus dicta. Nemo voluptas occaecati soluta iste soluta odit. Autem a quasi ullam aspernatur recusandae perspiciatis vitae. Officia magnam doloremque sint esse voluptatem error unde vel sunt.",
                            Price = 398.167649253092310m,
                            ProductName = "Sleek Fresh Bike",
                            ShortDesc = "A nobis modi asperiores tempora laudantium voluptatum et quis et.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=586",
                            UnitsInStock = 85
                        },
                        new
                        {
                            ProductId = 7,
                            Active = false,
                            CategoryId = 1,
                            DateCreated = new DateTime(2024, 5, 5, 12, 45, 16, 474, DateTimeKind.Local).AddTicks(1542),
                            DateModified = new DateTime(2025, 2, 2, 20, 44, 4, 486, DateTimeKind.Local).AddTicks(346),
                            Desciption = "Molestiae amet dolore odio soluta. Illum ut est nesciunt eaque soluta deleniti porro. Aut ab provident eius. Modi deserunt consequatur tempora omnis et pariatur ut dolores sit. Fugit accusamus unde nobis fugiat dolor vel. Nisi ipsam vero a ea accusamus et.",
                            Price = 437.769931601895190m,
                            ProductName = "Fantastic Fresh Pizza",
                            ShortDesc = "Praesentium voluptatum dolorem a officia eveniet aut reiciendis provident vel.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=31",
                            UnitsInStock = 70
                        },
                        new
                        {
                            ProductId = 8,
                            Active = true,
                            CategoryId = 3,
                            DateCreated = new DateTime(2025, 1, 3, 2, 2, 19, 891, DateTimeKind.Local).AddTicks(2891),
                            DateModified = new DateTime(2025, 2, 10, 11, 0, 14, 942, DateTimeKind.Local).AddTicks(762),
                            Desciption = "Quaerat autem placeat mollitia quis. Et veritatis in esse voluptas eaque rerum beatae. Et non sunt eum quaerat iusto quos. Ut consequatur voluptas occaecati reiciendis omnis inventore autem. Ab et dolores hic officiis unde tenetur. Quae illo autem aut repudiandae ad et eligendi saepe odio.",
                            Price = 282.742460548663070m,
                            ProductName = "Generic Granite Chicken",
                            ShortDesc = "Ullam totam et nulla voluptatem quisquam accusamus error dolor consequatur.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=537",
                            UnitsInStock = 95
                        },
                        new
                        {
                            ProductId = 9,
                            Active = true,
                            CategoryId = 4,
                            DateCreated = new DateTime(2023, 11, 3, 15, 50, 50, 480, DateTimeKind.Local).AddTicks(7064),
                            DateModified = new DateTime(2025, 2, 6, 16, 54, 46, 197, DateTimeKind.Local).AddTicks(2723),
                            Desciption = "Et beatae voluptas. Voluptatum commodi dicta ut minima voluptatem molestias eius delectus sit. Accusantium ipsam impedit harum ut quia tenetur. Aliquam recusandae non voluptatem deserunt reiciendis blanditiis est beatae. Id consequatur quia et optio qui.",
                            Price = 436.626846146079670m,
                            ProductName = "Refined Plastic Shirt",
                            ShortDesc = "Deleniti quia fugiat voluptas voluptatem quam accusamus consequatur et voluptatem.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=572",
                            UnitsInStock = 81
                        },
                        new
                        {
                            ProductId = 10,
                            Active = true,
                            CategoryId = 1,
                            DateCreated = new DateTime(2024, 5, 27, 6, 2, 49, 925, DateTimeKind.Local).AddTicks(5108),
                            DateModified = new DateTime(2025, 2, 2, 13, 40, 11, 704, DateTimeKind.Local).AddTicks(6033),
                            Desciption = "Sed magnam sit esse quae ad reprehenderit sit. Quos deserunt et fuga fuga aliquid fuga in rerum. Voluptatem cumque sed numquam labore nisi. Velit enim ratione sed. Magni doloremque rem enim asperiores. Occaecati modi libero sapiente et ea.",
                            Price = 76.164146122719960m,
                            ProductName = "Unbranded Steel Pizza",
                            ShortDesc = "Quidem soluta quidem sunt illum autem aut ipsa omnis corporis.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=1012",
                            UnitsInStock = 1
                        },
                        new
                        {
                            ProductId = 11,
                            Active = true,
                            CategoryId = 1,
                            DateCreated = new DateTime(2024, 5, 7, 7, 8, 8, 742, DateTimeKind.Local).AddTicks(7633),
                            DateModified = new DateTime(2025, 2, 6, 21, 23, 18, 52, DateTimeKind.Local).AddTicks(2200),
                            Desciption = "Reiciendis officia temporibus est aut temporibus mollitia et ad. Nihil qui recusandae. Autem voluptatum aut qui ut totam sequi sequi. Soluta unde mollitia voluptates.",
                            Price = 212.214187725117540m,
                            ProductName = "Incredible Concrete Computer",
                            ShortDesc = "Culpa blanditiis aut qui error animi architecto et corrupti sunt.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=203",
                            UnitsInStock = 5
                        },
                        new
                        {
                            ProductId = 12,
                            Active = true,
                            CategoryId = 4,
                            DateCreated = new DateTime(2024, 11, 13, 6, 12, 49, 358, DateTimeKind.Local).AddTicks(2362),
                            DateModified = new DateTime(2025, 2, 7, 16, 57, 34, 359, DateTimeKind.Local).AddTicks(2011),
                            Desciption = "Nemo ut quos expedita iure hic vel sit. Fuga iure rerum. In quaerat ut odit. Dolores inventore doloremque quod molestiae quo maxime.",
                            Price = 377.366501103182490m,
                            ProductName = "Unbranded Frozen Salad",
                            ShortDesc = "Voluptatem ratione beatae sit nihil non magni blanditiis distinctio quibusdam.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=692",
                            UnitsInStock = 91
                        },
                        new
                        {
                            ProductId = 13,
                            Active = true,
                            CategoryId = 5,
                            DateCreated = new DateTime(2025, 1, 27, 11, 41, 10, 843, DateTimeKind.Local).AddTicks(559),
                            DateModified = new DateTime(2025, 2, 11, 2, 24, 55, 245, DateTimeKind.Local).AddTicks(6983),
                            Desciption = "Adipisci delectus eius et tempore ea nisi quia natus. Illum vero beatae nostrum. Quia repudiandae sint et exercitationem earum et voluptatem quia dolor. Ut corporis fuga.",
                            Price = 253.73474969949910m,
                            ProductName = "Fantastic Steel Chair",
                            ShortDesc = "Magnam et est assumenda recusandae debitis unde reprehenderit aut et.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=776",
                            UnitsInStock = 78
                        },
                        new
                        {
                            ProductId = 14,
                            Active = false,
                            CategoryId = 2,
                            DateCreated = new DateTime(2024, 6, 9, 21, 3, 26, 89, DateTimeKind.Local).AddTicks(3940),
                            DateModified = new DateTime(2025, 2, 5, 10, 12, 43, 516, DateTimeKind.Local).AddTicks(646),
                            Desciption = "In qui maiores incidunt ipsam qui ullam in reiciendis deserunt. Suscipit vero dolorem explicabo velit nihil aut a ex eos. Quos nam tenetur blanditiis porro accusamus non ullam. Consequatur dignissimos occaecati magni voluptas tenetur aliquid assumenda dignissimos.",
                            Price = 478.391166738985560m,
                            ProductName = "Ergonomic Cotton Ball",
                            ShortDesc = "Aspernatur quisquam rerum aut iste necessitatibus sit nisi in reprehenderit.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=108",
                            UnitsInStock = 92
                        },
                        new
                        {
                            ProductId = 15,
                            Active = true,
                            CategoryId = 3,
                            DateCreated = new DateTime(2024, 9, 12, 5, 32, 29, 471, DateTimeKind.Local).AddTicks(3371),
                            DateModified = new DateTime(2025, 2, 7, 2, 6, 12, 476, DateTimeKind.Local).AddTicks(9122),
                            Desciption = "Vitae aperiam voluptatem sint nam laudantium officiis earum. Quae ipsam occaecati nam velit recusandae officiis excepturi. Et neque omnis perspiciatis est doloremque necessitatibus commodi id facere.",
                            Price = 302.4385855536950m,
                            ProductName = "Sleek Plastic Hat",
                            ShortDesc = "Quos animi quod sint earum debitis temporibus voluptas ut similique.",
                            ThumbnailImageUrl = "https://picsum.photos/640/480/?image=580",
                            UnitsInStock = 70
                        });
                });

            modelBuilder.Entity("ProductService.Models.Product", b =>
                {
                    b.HasOne("ProductService.Models.Category", "Cat")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("ProductService.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
