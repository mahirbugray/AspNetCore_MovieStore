using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreMvc_MovieSales.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "/images/filmAdi.jpg");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Beşiktaş-İstanbul", "Ali Uçar", "532 432 45 67" },
                    { 2, "Kadıköy-İstanbul", "Neşe Sever", "542 532 45 77" },
                    { 3, "Bakırköy-İstanbul", "Oya Koşar", "537 132 88 99" }
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
                columns: new[] { "Id", "Cast", "Director", "GenreId", "IsDiscount", "Name", "Price", "ReleaseDate", "Stock", "Summary" },
                values: new object[,]
                {
                    { 1, "Bradd Pitt, Orlando Bloom", "Wolfgan Pettersen", 5, false, "Truva", 250m, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Eski çağlarda ünlü truva savaşından kesitler" },
                    { 2, "Ananda George, Donny Alamsyah", "Gareth Evans", 5, false, "Baskın", 250m, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Operasyon timinin uyuşturucu baskınları" },
                    { 3, "Leonardo Di Caprio, Cate Winslet", "James Cameron", 1, false, "Titanic", 250m, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Lüks titanic gemisinin hazin öyküsü" },
                    { 4, "Bradd Pitt, Edward Norton", "David Lyinch", 1, false, "Fight Club", 250m, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Dövüş kulübü ilk kural bahsetmemek" },
                    { 5, "Bradd Pitt, Cristoph Wals", "Quantin Tarantino", 5, false, "Soysuzlar Çetesi", 250m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2.Dünya savaşından kesitler" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movies");
        }
    }
}
