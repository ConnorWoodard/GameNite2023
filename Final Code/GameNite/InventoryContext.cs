using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNite
{
    internal class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GameNiteStore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, ItemName = "Chessex Nebula Polyhedral Dice Set Wisteria with White Luminary (7 dice)", Price = 11.99, OnHand = 7, ItemType = "Accessory", Quantity = 0},
                new Inventory { InventoryId = 2, ItemName = "Call of Cthulhu Keeper's Handbook", Price = 46.99, OnHand = 3, ItemType = "Book", Quantity = 0 },

                new Inventory { InventoryId = 3, ItemName = "Fluxx", Price = 5.99, OnHand=13, ItemType = "Card Game" , Quantity = 0 },
                new Inventory { InventoryId = 4, ItemName = "Catan", Price = 61.99, OnHand =2, ItemType = "Board Game" , Quantity = 0 },
                new Inventory { InventoryId = 5, ItemName = "Battletech Salavage Box", Price = 5.99, OnHand = 25, ItemType = "Accessory" , Quantity = 0 },
                new Inventory { InventoryId = 6, ItemName = "Betrayal at House on the Hill", Price = 59.99, OnHand = 2, ItemType = "Board Game" , Quantity = 0 },
                new Inventory { InventoryId = 7, ItemName = "CandyLand", Price = 30.00, OnHand = 1, ItemType = "Board Game" , Quantity = 0 },
                new Inventory { InventoryId = 8, ItemName = "Coup", Price = 15.99, OnHand = 5, ItemType = "Card Game" , Quantity = 0 },
                new Inventory { InventoryId = 9, ItemName = "Dice Bag", Price = 21.99, OnHand = 14, ItemType = "Accessory" , Quantity = 0 },
                new Inventory { InventoryId = 10, ItemName = "Dice Tray", Price = 14.99, OnHand = 12, ItemType = "Accessory" , Quantity = 0 },
                new Inventory { InventoryId = 11, ItemName = "Dragon Shield", Price = 21.99, OnHand = 14, ItemType = "Accessory" , Quantity = 0 },
                new Inventory { InventoryId = 12, ItemName = "Edge of the Empire", Price = 55.99, OnHand = 3, ItemType = "Book" , Quantity = 0 },
                new Inventory { InventoryId = 13, ItemName = "Eldritch Horror", Price = 65.99, OnHand = 1, ItemType = "Board Game" , Quantity = 0 },

                new Inventory { InventoryId = 3, ItemName = "Fluxx", Price = 5.99, OnHand=13, ItemType = "Card Game", Quantity = 0 },
                new Inventory { InventoryId = 4, ItemName = "Catan", Price = 61.99, OnHand =2, ItemType = "Board Game", Quantity = 0 },
                new Inventory { InventoryId = 5, ItemName = "Battletech Salavage Box", Price = 5.99, OnHand = 25, ItemType = "Accessory", Quantity = 0 },
                new Inventory { InventoryId = 6, ItemName = "Betrayal at House on the Hill", Price = 59.99, OnHand = 2, ItemType = "Board Game", Quantity = 0 },
                new Inventory { InventoryId = 7, ItemName = "CandyLand", Price = 30.00, OnHand = 1, ItemType = "Board Game", Quantity = 0 },
                new Inventory { InventoryId = 8, ItemName = "Coup", Price = 15.99, OnHand = 5, ItemType = "Card Game", Quantity = 0 },
                new Inventory { InventoryId = 9, ItemName = "Dice Bag", Price = 21.99, OnHand = 14, ItemType = "Accessory", Quantity = 0 },
                new Inventory { InventoryId = 10, ItemName = "Dice Tray", Price = 14.99, OnHand = 12, ItemType = "Accessory", Quantity = 0 },
                new Inventory { InventoryId = 11, ItemName = "Dragon Shield", Price = 21.99, OnHand = 14, ItemType = "Accessory", Quantity = 0 },
                new Inventory { InventoryId = 12, ItemName = "Edge of the Empire", Price = 55.99, OnHand = 3, ItemType = "Book", Quantity = 0 },
                new Inventory { InventoryId = 13, ItemName = "Eldritch Horror", Price = 65.99, OnHand = 1, ItemType = "Board Game", Quantity = 0 },

                new Inventory { InventoryId = 14, ItemName = "Gloom", Price = 21.99, OnHand = 5, ItemType = "Card Game" , Quantity = 0 },
                new Inventory { InventoryId = 15, ItemName = "Hunter the Reckoning", Price = 65.99, OnHand = 3, ItemType = "Book" , Quantity = 0 },
                new Inventory { InventoryId = 16, ItemName = "Magic The Gathering Pack", Price = 5.99, OnHand = 35, ItemType = "Card Game" , Quantity = 0 },
                new Inventory { InventoryId = 17, ItemName = "Pathfinder 2e Core Rulebook", Price = 59.99, OnHand = 5, ItemType = "Book" , Quantity = 0 },
                new Inventory { InventoryId = 18, ItemName = "Pokemon Silver Tempest Packs", Price = 5.99, OnHand = 26, ItemType = "Card Game" , Quantity = 0 },
                new Inventory { InventoryId = 19, ItemName = "Red Dragon Inn", Price = 65.99, OnHand = 4, ItemType = "Board Game" , Quantity = 0 },
                new Inventory { InventoryId = 20, ItemName = "Scion Demigod", Price = 62.99, OnHand = 1, ItemType = "Book" , Quantity = 0 },
                new Inventory { InventoryId = 21, ItemName = "Sentinel Comics Core Rulebook", Price = 49.99, OnHand = 6, ItemType = "Book" , Quantity = 0 },
                new Inventory { InventoryId = 22, ItemName = "Warhammer Paintset", Price = 75.99, OnHand = 1, ItemType = "Accessory" , Quantity = 0 },
                new Inventory { InventoryId = 23, ItemName = "One Night Ultimate Werewolf", Price = 29.99, OnHand = 3, ItemType = "Card Game" , Quantity = 0 },
                new Inventory { InventoryId = 24, ItemName = "Zombiecide", Price = 89.99, OnHand = 1, ItemType = "Board Game" , Quantity = 0 }
                );
            
        }
    }
}
