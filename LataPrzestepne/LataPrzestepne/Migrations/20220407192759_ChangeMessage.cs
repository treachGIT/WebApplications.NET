using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LataPrzestepne.Migrations
{
    public partial class ChangeMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SavedMessage",
                table: "Birthdays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SavedMessage",
                table: "Birthdays",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
