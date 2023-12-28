using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel TV (HD, with French channels as well as Netflix)", "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o", "Royal Villa", 5, 5.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel TV (HD, with French channels as well as Netflix)", "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o", "Royal Villa", 5, 5.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel TV (HD, with French channels as well as Netflix)", "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o", "Royal Villa", 5, 5.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel TV (HD, with French channels as well as Netflix)", "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o", "Royal Villa", 5, 5.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With about 270 sq. meters, on three levels, the villa, which is accessed through remote-controlled electric gates, features on the ground floor a large and bright 70 m² Living room comfortably furnished, with a baby grand piano and a flat panel TV (HD, with French channels as well as Netflix)", "https://unsplash.com/photos/a-swimming-pool-with-lounge-chairs-and-palm-trees-HDX63jhsD3o", "Royal Villa", 5, 5.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
