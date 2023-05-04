using GameNite.Migrations;
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
    public partial class BoardGames : Form
    {
        InventoryContext inventoryDB;
        public BoardGames()
        {
            inventoryDB = new InventoryContext();
            InitializeComponent();
            
        }

        private void lnkBetrayal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 6).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkCandyland_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 7).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkCatan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 4).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkEldritch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 13).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkRedDragonInn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 19).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkZombiecide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 24).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }
    }
}
