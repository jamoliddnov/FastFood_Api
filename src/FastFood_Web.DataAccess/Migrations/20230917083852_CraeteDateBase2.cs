using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastFood_Web.DataAccess.Migrations
{
    public partial class CraeteDateBase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Orders",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "DistrictFilials",
                newName: "LocationId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "DistrictFilials",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LocationId",
                table: "Orders",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_DistrictFilials_LocationId",
                table: "DistrictFilials",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DistrictFilials_Location_LocationId",
                table: "DistrictFilials",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Location_LocationId",
                table: "Orders",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DistrictFilials_Location_LocationId",
                table: "DistrictFilials");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Location_LocationId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LocationId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_DistrictFilials_LocationId",
                table: "DistrictFilials");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Orders",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "DistrictFilials",
                newName: "Location");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "DistrictFilials",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }
    }
}
