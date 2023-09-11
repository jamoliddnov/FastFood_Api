using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastFood_Web.DataAccess.Migrations
{
    public partial class CreateDateBase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "Admins",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "Admins");
        }
    }
}
