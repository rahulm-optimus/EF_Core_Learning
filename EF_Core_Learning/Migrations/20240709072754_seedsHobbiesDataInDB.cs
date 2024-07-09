using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Core_Learning.Migrations
{
    /// <inheritdoc />
    public partial class seedsHobbiesDataInDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbiesId", "HobbiesName" },
                values: new object[,]
                {
                    { 1, "Reading books" },
                    { 2, "Playing football" },
                    { 3, "Travelling" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbiesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbiesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbiesId",
                keyValue: 3);
        }
    }
}
