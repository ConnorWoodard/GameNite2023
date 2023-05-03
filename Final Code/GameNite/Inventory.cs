using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNite
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string ItemType { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
        public int OnHand { get; set; }
        public int Quantity { get; set; } = 0;
<<<<<<< Updated upstream
        
        //public Inventory(string itemName, double price, int onHand, int quantity, double itemPrice) {
        //    ItemName = itemName;
        //    Price = price;
        //    OnHand = onHand;
        //    Quantity = quantity;
        //    ItemPrice = itemPrice;
        //    itemPrice = price * quantity;
        //}
=======
       
>>>>>>> Stashed changes
        
    }
}
