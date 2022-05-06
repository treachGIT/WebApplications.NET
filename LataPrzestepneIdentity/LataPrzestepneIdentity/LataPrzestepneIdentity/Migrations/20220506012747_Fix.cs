using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LataPrzestepneIdentity.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Birthdays_AspNetUsers_UserId",
                table: "Birthdays");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Birthdays",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Birthdays_AspNetUsers_UserId",
                table: "Birthdays",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Birthdays_AspNetUsers_UserId",
                table: "Birthdays");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Birthdays",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Birthdays_AspNetUsers_UserId",
                table: "Birthdays",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
