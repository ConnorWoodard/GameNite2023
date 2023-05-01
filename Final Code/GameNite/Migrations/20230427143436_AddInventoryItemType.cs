using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameNite.Migrations
{
    /// <inheritdoc />
    public partial class AddInventoryItemType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemType",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "ItemType",
                value: "Accessory");

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "ItemType",
                value: "Book");

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "ItemType",
                value: "Card Game");

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "ItemType",
                value: "Board Game");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Inventory");
        }
    }
}
