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
    public partial class Accessories : Form
    {
        InventoryContext inventoryDB;
        public Accessories()
        {
            inventoryDB = new InventoryContext();
            InitializeComponent();
            
            
        }

        private void lnkBattletech_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 5).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkChessex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 1).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkDiceBag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 9).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkDiceTray_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 10).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkDragonShield_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 11).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }

        private void lnkWarhammerPaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inventoryDB.Inventory.Where(x => x.InventoryId == 22).ToList()[0].Quantity++;
            inventoryDB.SaveChanges();
        }
    }
}
