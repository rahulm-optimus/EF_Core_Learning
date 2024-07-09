using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Learning.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyBetweenUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Details_UserId",
                table: "Roles",
                column: "UserId",
                principalTable: "Details",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
