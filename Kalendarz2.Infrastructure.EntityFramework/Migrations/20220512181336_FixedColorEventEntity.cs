using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kalendarz2.Infrastructure.EntityFramework
{
    public partial class FixedColorEventEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorB",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ColorG",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "ColorR",
                table: "Events",
                newName: "Color");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Events",
                newName: "ColorR");

            migrationBuilder.AddColumn<int>(
                name: "ColorB",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorG",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
