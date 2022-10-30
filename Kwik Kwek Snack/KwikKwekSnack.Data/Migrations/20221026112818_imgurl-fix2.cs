using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack.Data.Migrations
{
    public partial class imgurlfix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Chocomel",
                column: "ImageURL",
                value: "choccy.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fristi",
                column: "ImageURL",
                value: "fristi.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kaassoufflé",
                column: "ImageURL",
                value: "kaas.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Rood",
                column: "ImageURL",
                value: "kutwater.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Chocomel",
                column: "ImageURL",
                value: "~choccy.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Fristi",
                column: "ImageURL",
                value: "~fristi.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Kaassoufflé",
                column: "ImageURL",
                value: "~kaas.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Name",
                keyValue: "Spa Rood",
                column: "ImageURL",
                value: "~kutwater.png");
        }
    }
}
