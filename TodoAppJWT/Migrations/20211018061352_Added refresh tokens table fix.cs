using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoAppJWT.Migrations
{
    public partial class Addedrefreshtokenstablefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsUser",
                table: "RefreshTokens",
                newName: "IsUsed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsUsed",
                table: "RefreshTokens",
                newName: "IsUser");
        }
    }
}
