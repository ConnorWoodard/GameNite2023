using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameNite.Migrations
{
    /// <inheritdoc />
    public partial class DBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OnHand = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryId);
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "InventoryId", "ItemName", "OnHand", "Price" },
                values: new object[,]
                {
                    { 1, "Chessex Nebula Polyhedral Dice Set Wisteria with White Luminary (7 dice)", 7, 11.99 },
                    { 2, "Call of Cthulhu Keeper's Handbook", 3, 46.990000000000002 },
                    { 3, "Fluxx", 13, 5.9900000000000002 },
                    { 4, "Catan", 2, 61.990000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
