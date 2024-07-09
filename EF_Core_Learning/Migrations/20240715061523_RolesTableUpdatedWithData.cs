using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Core_Learning.Migrations
{
    /// <inheritdoc />
    public partial class RolesTableUpdatedWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passwords",
                keyColumn: "PasswordId",
                keyValue: 1,
                column: "Password",
                value: "o*RE0ESV@8wewWt1");

            migrationBuilder.UpdateData(
                table: "Passwords",
                keyColumn: "PasswordId",
                keyValue: 2,
                column: "Password",
                value: "YjoTimXu&Bg8F4Oj");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName", "UserId" },
                values: new object[,]
                {
                    { 1, "PMO", 1 },
                    { 2, "PO", 2 },
                    { 3, "User", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
