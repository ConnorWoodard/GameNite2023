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
        List<Inventory> ordersList;
        public Books()
        {
            inventoryDB = new InventoryContext();
            InitializeComponent();
            ordersList = inventoryDB.Inventory.Select(o=>o).ToList();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            
        }
    }
}
