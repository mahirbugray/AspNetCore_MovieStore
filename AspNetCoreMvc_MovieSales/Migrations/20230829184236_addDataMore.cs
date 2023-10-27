using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreMvc_MovieSales.Migrations
{
    /// <inheritdoc />
    public partial class addDataMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Barbie.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/BlueBeetle.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/CehennemMelekleri.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/Doru.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/Efsunlu.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "Director", "GenreId", "ImageUrl", "IsDiscount", "IsLocal", "Name", "Price", "ReleaseDate", "Stock", "Summary" },
                values: new object[,]
                {
                    { 6, "Bradd Pitt, Orlando Bloom", "Wolfgan Pettersen", 2, "/images/GranTurismo.jpg", false, false, "Truva", 250m, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Eski çağlarda ünlü truva savaşından kesitler" },
                    { 7, "Ananda George, Donny Alamsyah", "Gareth Evans", 4, "/images/GucYuzukleri.jpg", false, false, "Baskın", 250m, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Operasyon timinin uyuşturucu baskınları" },
                    { 8, "Leonardo Di Caprio, Cate Winslet", "James Cameron", 1, "/images/Hulk.webp", false, false, "Titanic", 250m, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Lüks titanic gemisinin hazin öyküsü" },
                    { 9, "Bradd Pitt, Edward Norton", "David Lyinch", 1, "/images/Meg2.jpg", false, false, "Fight Club", 250m, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Dövüş kulübü ilk kural bahsetmemek" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/filmAdi.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/filmAdi.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/filmAdi.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/filmAdi.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/filmAdi.jpg");
        }
    }
}
