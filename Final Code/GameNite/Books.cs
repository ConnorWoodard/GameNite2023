using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNite
{
    public partial class Books : Form
    {
        InventoryContext inventoryDB;
        List<Order> ordersList;

        public Books()
        {
            inventoryDB = new InventoryContext();
            InitializeComponent();
            ordersList = new List<Order>();
            foreach (Inventory obj in inventoryDB.Inventory)
            {
                obj.Quantity = 0;
            }
            inventoryDB.SaveChanges();
        }

        private void lnkCoC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 2).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkEdge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 12).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkHunter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 15).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkPathfinder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 17).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkScion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 20).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkSentinel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 21).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }
    }
}
