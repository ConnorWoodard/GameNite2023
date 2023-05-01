using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNite
{
    public class Order
    {
       public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
      
        public string ItemType { get; set; } = string.Empty; 
        public double Price { get; set; } = 0.0;
        public int Quantity { get; set; }
    }
}
