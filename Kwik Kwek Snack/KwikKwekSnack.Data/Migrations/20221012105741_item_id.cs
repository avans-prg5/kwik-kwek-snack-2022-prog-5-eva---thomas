using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    public partial class item_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Orders_OrderId",
                table: "Drinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Snacks_SnackInOrderOrderId_SnackInOrderSnackId",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_Snacks_Orders_OrderId",
                table: "Snacks");

            migrationBuilder.RenameColumn(
                name: "SnackId",
                table: "Snacks",
                newName: "SnackID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Snacks",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "SnackInOrderSnackId",
                table: "Extras",
                newName: "SnackInOrderSnackID");

            migrationBuilder.RenameColumn(
                name: "SnackInOrderOrderId",
                table: "Extras",
                newName: "SnackInOrderOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Extras_SnackInOrderOrderId_SnackInOrderSnackId",
                table: "Extras",
                newName: "IX_Extras_SnackInOrderOrderID_SnackInOrderSnackID");

            migrationBuilder.RenameColumn(
                name: "straw",
                table: "Drinks",
                newName: "Straw");

            migrationBuilder.RenameColumn(
                name: "size",
                table: "Drinks",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "ice",
                table: "Drinks",
                newName: "Ice");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Drinks",
                newName: "OrderID");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Orders_OrderID",
                table: "Drinks",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Snacks_SnackInOrderOrderID_SnackInOrderSnackID",
                table: "Extras",
                columns: new[] { "SnackInOrderOrderID", "SnackInOrderSnackID" },
                principalTable: "Snacks",
                principalColumns: new[] { "OrderID", "SnackID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Snacks_Orders_OrderID",
                table: "Snacks",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Orders_OrderID",
                table: "Drinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Snacks_SnackInOrderOrderID_SnackInOrderSnackID",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_Snacks_Orders_OrderID",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "SnackID",
                table: "Snacks",
                newName: "SnackId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Snacks",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "SnackInOrderSnackID",
                table: "Extras",
                newName: "SnackInOrderSnackId");

            migrationBuilder.RenameColumn(
                name: "SnackInOrderOrderID",
                table: "Extras",
                newName: "SnackInOrderOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Extras_SnackInOrderOrderID_SnackInOrderSnackID",
                table: "Extras",
                newName: "IX_Extras_SnackInOrderOrderId_SnackInOrderSnackId");

            migrationBuilder.RenameColumn(
                name: "Straw",
                table: "Drinks",
                newName: "straw");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Drinks",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "Ice",
                table: "Drinks",
                newName: "ice");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Drinks",
                newName: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Orders_OrderId",
                table: "Drinks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Snacks_SnackInOrderOrderId_SnackInOrderSnackId",
                table: "Extras",
                columns: new[] { "SnackInOrderOrderId", "SnackInOrderSnackId" },
                principalTable: "Snacks",
                principalColumns: new[] { "OrderId", "SnackId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Snacks_Orders_OrderId",
                table: "Snacks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
