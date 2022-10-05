using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    sizes = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.sizes);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    statuses = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.statuses);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statuses = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TakeAway = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_statuses",
                        column: x => x.statuses,
                        principalTable: "Statuses",
                        principalColumn: "statuses",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ice = table.Column<bool>(type: "bit", nullable: false),
                    Straw = table.Column<bool>(type: "bit", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Drinks_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateTable(
                name: "Snacks",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snacks", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Snacks_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Extras = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SnackName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Extras);
                    table.ForeignKey(
                        name: "FK_Extras_Snacks_SnackName",
                        column: x => x.SnackName,
                        principalTable: "Snacks",
                        principalColumn: "Name");
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Name", "Description", "Ice", "ImageURL", "OrderID", "Price", "Size", "Straw" },
                values: new object[,]
                {
                    { "Chocomel", "Chocomel", false, "~/img/choccy.png", null, 1f, "M", false },
                    { "Coca Cola", "Coca Cola", false, "~/img/coke.png", null, 1.5f, "S", false },
                    { "Coca Cola Zero", "Coca Cola Zero", false, "~/img/coke0.png", null, 1.5f, "XL", false },
                    { "Fanta", "Fanta", false, "~/img/fanta.png", null, 1.5f, "M", false },
                    { "Fristi", "Fristi", false, "~/img/fristi.png", null, 1f, "L", false },
                    { "Pepsi", "Pepsi Cola", false, "~/img/pepsi.png", null, 1.5f, "L", false },
                    { "Spa Blauw", "Water", false, "~/img/water.png", null, 1f, "S", false },
                    { "Spa Rood", "Sprankelend water", false, "~/img/kutwater.png", null, 1f, "S", false }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Extras", "SnackName" },
                values: new object[,]
                {
                    { "Kaas", null },
                    { "Sla", null },
                    { "Tomaat", null },
                    { "Ui", null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                column: "sizes",
                values: new object[]
                {
                    "L",
                    "M",
                    "S",
                    "XL"
                });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Name", "Description", "ImageURL", "OrderID", "Price" },
                values: new object[,]
                {
                    { "Bamischijf", "Bamischijf", "~/img/bami.png", null, 1.85f },
                    { "Cheeseburger", "Cheeseburger", "~/img/cburger.png", null, 4f },
                    { "Frikandel", "Frikandel", "~/img/frikandel.png", null, 1.7f },
                    { "Frikandel Speciaal", "Frikandel Speciaal", "~/img/speciaal.png", null, 2.1f },
                    { "Hamburger", "Hamburger", "~/img/burger.png", null, 3.55f },
                    { "Kaassoufflé", "Kaassoufflé", "~/img/kaas.png", null, 1.85f },
                    { "Kipnuggets", "Kipnuggets", "~/img/nuggets.png", null, 2.05f },
                    { "Kroket", "Kroket", "~/img/kroket.png", null, 1.7f }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                column: "statuses",
                values: new object[]
                {
                    "Gereed",
                    "Wachtrij",
                    "Wordt bereid"
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderID",
                table: "Drinks",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Extras_SnackName",
                table: "Extras",
                column: "SnackName");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_statuses",
                table: "Orders",
                column: "statuses");

            migrationBuilder.CreateIndex(
                name: "IX_Snacks_OrderID",
                table: "Snacks",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Snacks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
