using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalendarz2.Infrastructure.EntityFramework
{
    public partial class Addedverification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isVerified",
                table: "Users");
        }
    }
}
