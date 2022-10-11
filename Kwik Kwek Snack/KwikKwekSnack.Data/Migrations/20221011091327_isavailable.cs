using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    public partial class isavailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Snacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Drinks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Bamischijf",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Cheeseburger",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Chocomel",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Coca Cola",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Coca Cola Zero",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fanta",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Frikandel",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Frikandel Speciaal",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fristi",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Hamburger",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kaassoufflé",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kipnuggets",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kroket",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Pepsi",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Blauw",
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Rood",
                column: "IsAvailable",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Drinks");
        }
    }
}
