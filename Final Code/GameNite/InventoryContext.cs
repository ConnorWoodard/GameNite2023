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
                new Inventory { InventoryId=1, ItemName="Chessex Nebula Polyhedral Dice Set", Price=11.99, OnHand=7},
                new Inventory { InventoryId = 2, ItemName = "Call of Cthulhu Keeper's Handbook", Price = 46.99, OnHand=3 },
                new Inventory { InventoryId = 3, ItemName = "Fluxx", Price = 5.99, OnHand=13 },
                new Inventory { InventoryId = 4, ItemName = "Catan", Price = 61.99, OnHand =2 }
                );
        }
    }
}
