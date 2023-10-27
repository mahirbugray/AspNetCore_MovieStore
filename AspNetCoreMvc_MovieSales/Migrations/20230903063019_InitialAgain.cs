using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreMvc_MovieSales.Migrations
{
    /// <inheritdoc />
    public partial class InitialAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "/images/filmAdi.jpg"),
                    IsLocal = table.Column<bool>(type: "bit", nullable: false),
                    IsPopuler = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDiscount = table.Column<bool>(type: "bit", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieSaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieSaleId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSaleDetails_MovieSales_MovieSaleId",
                        column: x => x.MovieSaleId,
                        principalTable: "MovieSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSaleDetails_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Beşiktaş-İstanbul", "ali@gmail.com", "Ali Uçar", "123", "532 432 45 67" },
                    { 2, "Kadıköy-İstanbul", "nese@gmail.com", "Neşe Sever", "456", "542 532 45 77" },
                    { 3, "Bakırköy-İstanbul", "oya@gmail.com", "Oya Koşar", "789", "537 132 88 99" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Acılı, hüzünlü, dramatik", "Dram" },
                    { 2, "Komik, neşeli, eğlenceli", "Komedi" },
                    { 3, "Hem komik, hem romantik, eğlenceli", "Romantik Komedi" },
                    { 4, "Çok korkunç", "Korku, Gerilim" },
                    { 5, "Tarihi savaş ve aksiyon", "Savaş" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "Director", "GenreId", "ImageUrl", "IsDiscount", "IsLocal", "Name", "Price", "ReleaseDate", "Stock", "Summary" },
                values: new object[,]
                {
                    { 1, "Bradd Pitt, Orlando Bloom", "Wolfgan Pettersen", 5, "/images/Barbie.jpg", false, false, "Truva", 250m, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Eski çağlarda ünlü truva savaşından kesitler" },
                    { 2, "Ananda George, Donny Alamsyah", "Gareth Evans", 5, "/images/BlueBeetle.jpg", false, false, "Baskın", 250m, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Operasyon timinin uyuşturucu baskınları" },
                    { 3, "Leonardo Di Caprio, Cate Winslet", "James Cameron", 1, "/images/CehennemMelekleri.jpg", false, false, "Titanic", 250m, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Lüks Titanic gemisinin hazin öyküsü" },
                    { 4, "Bradd Pitt, Edward Norton", "David Lyinch", 1, "/images/Doru.jpg", false, false, "Fight Club", 250m, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Dövüş kulübü, ilk kural bahsetmemek" },
                    { 5, "Bradd Pitt, Christoph Wals", "Quantin Tarantino", 5, "/images/Efsunlu3.jpg", false, false, "Soysuzlar Çetesi", 250m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.Dünya savaşından kesitler" },
                    { 6, "Bradd Pitt, Christoph Wals", "Quantin Tarantino", 2, "/images/GranTurismo.jpg", false, false, "Soysuzlar Çetesi", 250m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.Dünya savaşından kesitler" },
                    { 7, "Bradd Pitt, Christoph Wals", "Quantin Tarantino", 4, "/images/GucYuzukleri.jpg", false, false, "Soysuzlar Çetesi", 250m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.Dünya savaşından kesitler" },
                    { 8, "Bradd Pitt, Christoph Wals", "Quantin Tarantino", 5, "/images/Hulk.webp", false, false, "Soysuzlar Çetesi", 250m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.Dünya savaşından kesitler" },
                    { 9, "Bradd Pitt, Christoph Wals", "Quantin Tarantino", 1, "/images/Meg2.jpg", false, false, "Soysuzlar Çetesi", 250m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.Dünya savaşından kesitler" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSaleDetails_MovieId",
                table: "MovieSaleDetails",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSaleDetails_MovieSaleId",
                table: "MovieSaleDetails",
                column: "MovieSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSales_CustomerId",
                table: "MovieSales",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieSaleDetails");

            migrationBuilder.DropTable(
                name: "MovieSales");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
