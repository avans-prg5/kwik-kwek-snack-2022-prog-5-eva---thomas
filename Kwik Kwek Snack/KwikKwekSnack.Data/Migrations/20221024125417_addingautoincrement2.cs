using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    public partial class addingautoincrement2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsDrink = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TakeAway = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    DrinkName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Straw = table.Column<bool>(type: "bit", nullable: false),
                    Ice = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => new { x.OrderID, x.DrinkId });
                    table.ForeignKey(
                        name: "FK_Drinks_Items_DrinkName",
                        column: x => x.DrinkName,
                        principalTable: "Items",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drinks_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Snacks",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    SnackID = table.Column<int>(type: "int", nullable: false),
                    SnackName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snacks", x => new { x.OrderID, x.SnackID });
                    table.ForeignKey(
                        name: "FK_Snacks_Items_SnackName",
                        column: x => x.SnackName,
                        principalTable: "Items",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Snacks_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Name = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    SnackInOrderOrderID = table.Column<int>(type: "int", nullable: true),
                    SnackInOrderSnackID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Extras_Snacks_SnackInOrderOrderID_SnackInOrderSnackID",
                        columns: x => new { x.SnackInOrderOrderID, x.SnackInOrderSnackID },
                        principalTable: "Snacks",
                        principalColumns: new[] { "OrderID", "SnackID" });
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Name", "Price", "SnackInOrderOrderID", "SnackInOrderSnackID" },
                values: new object[,]
                {
                    { 0, 0.5f, null, null },
                    { 1, 0.5f, null, null },
                    { 2, 0.5f, null, null },
                    { 3, 0.5f, null, null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Name", "Description", "ImageURL", "IsAvailable", "IsDrink", "Price" },
                values: new object[,]
                {
                    { "Bamischijf", "Bamischijf", "~/img/bami.png", true, false, 1.85f },
                    { "Cheeseburger", "Cheeseburger", "~/img/cburger.png", true, false, 4f },
                    { "Chocomel", "Chocomel", "~/img/choccy.png", true, true, 1f },
                    { "Coca Cola", "Coca Cola", "~/img/coke.png", true, true, 1.5f },
                    { "Coca Cola Zero", "Coca Cola Zero", "~/img/coke0.png", true, true, 1.5f },
                    { "Fanta", "Fanta", "~/img/fanta.png", true, true, 1.5f },
                    { "Frikandel", "Frikandel", "~/img/frikandel.png", true, false, 1.7f },
                    { "Frikandel Speciaal", "Frikandel Speciaal", "~/img/speciaal.png", true, false, 2.1f },
                    { "Fristi", "Fristi", "~/img/fristi.png", true, true, 1f },
                    { "Hamburger", "Hamburger", "~/img/burger.png", true, false, 3.55f },
                    { "Kaassoufflé", "Kaassoufflé", "~/img/kaas.png", true, false, 1.85f },
                    { "Kipnuggets", "Kipnuggets", "~/img/nuggets.png", true, false, 2.05f },
                    { "Kroket", "Kroket", "~/img/kroket.png", true, false, 1.7f },
                    { "Pepsi", "Pepsi Cola", "~/img/pepsi.png", true, true, 1.5f },
                    { "Spa Blauw", "Water", "~/img/water.png", true, true, 1f },
                    { "Spa Rood", "Sprankelend water", "~/img/kutwater.png", true, true, 1f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_DrinkName",
                table: "Drinks",
                column: "DrinkName");

            migrationBuilder.CreateIndex(
                name: "IX_Extras_SnackInOrderOrderID_SnackInOrderSnackID",
                table: "Extras",
                columns: new[] { "SnackInOrderOrderID", "SnackInOrderSnackID" });

            migrationBuilder.CreateIndex(
                name: "IX_Snacks_SnackName",
                table: "Snacks",
                column: "SnackName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Snacks");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
