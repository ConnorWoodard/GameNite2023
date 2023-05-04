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
    public partial class CardGames : Form
    {
        InventoryContext inventoryDB;
        public CardGames()
        {
            inventoryDB = new InventoryContext();
            InitializeComponent();
            foreach(Inventory obj in inventoryDB.Inventory)
            {
                obj.Quantity = 0;
            }
            inventoryDB.SaveChanges();
        }

        private void lnkCoup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 8).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkFluxx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 3).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkGloom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 14).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkMTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 16).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkPokemon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 18).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkONW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 23).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }
    }
}
