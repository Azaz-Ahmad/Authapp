using Microsoft.EntityFrameworkCore.Migrations;

namespace Authapp.Migrations
{
    public partial class MobileNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CCCVV",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CCExpiry",
                table: "AspNetUsers",
                type: "nvarchar(5)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CCNumber",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CCCVV",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CCExpiry",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CCNumber",
                table: "AspNetUsers");
        }
    }
}
