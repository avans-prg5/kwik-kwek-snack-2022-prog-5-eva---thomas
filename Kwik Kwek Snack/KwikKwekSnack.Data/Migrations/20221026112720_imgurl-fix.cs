using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    public partial class imgurlfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Bamischijf",
                column: "ImageURL",
                value: "bami.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Cheeseburger",
                column: "ImageURL",
                value: "cburger.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Chocomel",
                column: "ImageURL",
                value: "~choccy.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Coca Cola",
                column: "ImageURL",
                value: "coke.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Coca Cola Zero",
                column: "ImageURL",
                value: "coke0.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fanta",
                column: "ImageURL",
                value: "fanta.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Frikandel",
                column: "ImageURL",
                value: "frikandel.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Frikandel Speciaal",
                column: "ImageURL",
                value: "speciaal.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fristi",
                column: "ImageURL",
                value: "~fristi.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Hamburger",
                column: "ImageURL",
                value: "burger.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kaassoufflé",
                column: "ImageURL",
                value: "~kaas.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kipnuggets",
                column: "ImageURL",
                value: "nuggets.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kroket",
                column: "ImageURL",
                value: "kroket.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Pepsi",
                column: "ImageURL",
                value: "pepsi.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Blauw",
                column: "ImageURL",
                value: "water.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Rood",
                column: "ImageURL",
                value: "~kutwater.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Bamischijf",
                column: "ImageURL",
                value: "~/img/bami.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Cheeseburger",
                column: "ImageURL",
                value: "~/img/cburger.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Chocomel",
                column: "ImageURL",
                value: "~/img/choccy.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Coca Cola",
                column: "ImageURL",
                value: "~/img/coke.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Coca Cola Zero",
                column: "ImageURL",
                value: "~/img/coke0.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fanta",
                column: "ImageURL",
                value: "~/img/fanta.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Frikandel",
                column: "ImageURL",
                value: "~/img/frikandel.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Frikandel Speciaal",
                column: "ImageURL",
                value: "~/img/speciaal.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fristi",
                column: "ImageURL",
                value: "~/img/fristi.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Hamburger",
                column: "ImageURL",
                value: "~/img/burger.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kaassoufflé",
                column: "ImageURL",
                value: "~/img/kaas.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kipnuggets",
                column: "ImageURL",
                value: "~/img/nuggets.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kroket",
                column: "ImageURL",
                value: "~/img/kroket.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Pepsi",
                column: "ImageURL",
                value: "~/img/pepsi.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Blauw",
                column: "ImageURL",
                value: "~/img/water.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Rood",
                column: "ImageURL",
                value: "~/img/kutwater.png");
        }
    }
}
