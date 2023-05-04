using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameNite.Migrations
{
    /// <inheritdoc />
    public partial class Inventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "Quantity",
                value: 0);

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "InventoryId", "ItemName", "ItemType", "OnHand", "Price", "Quantity" },
                values: new object[,]
                {
                    { 5, "Battletech Salavage Box", "Accessory", 25, 5.9900000000000002, 0 },
                    { 6, "Betrayal at House on the Hill", "Board Game", 2, 59.990000000000002, 0 },
                    { 7, "CandyLand", "Board Game", 1, 30.0, 0 },
                    { 8, "Coup", "Card Game", 5, 15.99, 0 },
                    { 9, "Dice Bag", "Accessory", 14, 21.989999999999998, 0 },
                    { 10, "Dice Tray", "Accessory", 12, 14.99, 0 },
                    { 11, "Dragon Shield", "Accessory", 14, 21.989999999999998, 0 },
                    { 12, "Edge of the Empire", "Book", 3, 55.990000000000002, 0 },
                    { 13, "Eldritch Horror", "Board Game", 1, 65.989999999999995, 0 },
                    { 14, "Gloom", "Card Game", 5, 21.989999999999998, 0 },
                    { 15, "Hunter the Reckoning", "Book", 3, 65.989999999999995, 0 },
                    { 16, "Magic The Gathering Pack", "Card Game", 35, 5.9900000000000002, 0 },
                    { 17, "Pathfinder 2e Core Rulebook", "Book", 5, 59.990000000000002, 0 },
                    { 18, "Pokemon Silver Tempest Packs", "Card Game", 26, 5.9900000000000002, 0 },
                    { 19, "Red Dragon Inn", "Board Game", 4, 65.989999999999995, 0 },
                    { 20, "Scion Demigod", "Book", 1, 62.990000000000002, 0 },
                    { 21, "Sentinel Comics Core Rulebook", "Book", 6, 49.990000000000002, 0 },
                    { 22, "Warhammer Paintset", "Accessory", 1, 75.989999999999995, 0 },
                    { 23, "One Night Ultimate Werewolf", "Card Game", 3, 29.989999999999998, 0 },
                    { 24, "Zombiecide", "Board Game", 1, 89.989999999999995, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "InventoryId",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Inventory");
        }
    }
}
