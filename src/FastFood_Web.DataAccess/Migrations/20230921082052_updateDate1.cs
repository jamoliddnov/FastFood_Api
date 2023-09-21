using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastFood_Web.DataAccess.Migrations
{
    public partial class updateDate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Delivers_DeliverId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ReceivingOperators_ReceivingOperatorId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ReceivingOperatorId",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "DeliverId",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Delivers_DeliverId",
                table: "Orders",
                column: "DeliverId",
                principalTable: "Delivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ReceivingOperators_ReceivingOperatorId",
                table: "Orders",
                column: "ReceivingOperatorId",
                principalTable: "ReceivingOperators",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Delivers_DeliverId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ReceivingOperators_ReceivingOperatorId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ReceivingOperatorId",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliverId",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Delivers_DeliverId",
                table: "Orders",
                column: "DeliverId",
                principalTable: "Delivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ReceivingOperators_ReceivingOperatorId",
                table: "Orders",
                column: "ReceivingOperatorId",
                principalTable: "ReceivingOperators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
