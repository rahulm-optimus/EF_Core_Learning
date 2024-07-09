using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Core_Learning.Migrations
{
    /// <inheritdoc />
    public partial class seedUserDetailsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "UserId", "Email", "UserName" },
                values: new object[,]
                {
                    { 1, "Rahul.mehra@gmail.com", "Rahul" },
                    { 2, "Ashwani@gmail.com", "Ashwani" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "UserId",
                keyValue: 2);
        }
    }
}
