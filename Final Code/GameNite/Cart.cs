using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GameNite
{
    public partial class Cart : Form
    {

        CardInfo cardInfo = new CardInfo();
        InventoryContext inventoryDB;



        ThankYou thankYou = new ThankYou();
        
        List<Inventory> ordersList;

        public Cart()
        {
            inventoryDB = new InventoryContext();
            InitializeComponent();
            ordersList = new List<Inventory>();
        }
        private void SetResultOnDataGridView()
        {


        }

        private void Cart_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = inventoryDB.Inventory.ToList();
            if (dataGridView1.DataSource != null)
            {
                return;
            }
            var count = dataGridView1.Rows.Count;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //if ( row.Index + 1 == count ) {
                //    break;
                //}
                //var nextrow = dataGridView1.Rows[row.Index + 1];

                //string col1 = row.Cells["Quantity"].Value.ToString();
                //string col2 = row.Cells["Price"].Value.ToString();


                double val1 = Convert.ToDouble(row.Cells["Quantity"].Value.ToString());
                double val2 = Convert.ToDouble(row.Cells["Price"].Value.ToString());
                double product = val1 * val2;
                row.Cells["UnitPrice"].Value = product.ToString();
            }

            foreach  (Inventory inventory in ordersList)
            {
                lblCart.Text = ordersList.Count.ToString();
            }
            

        }

        private void inventoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            foreach (Inventory item in inventoryDB.Inventory)
            {
                inventoryDB.Inventory.Where(x => x.OnHand == x.OnHand - x.Quantity).ToList(); //i hope this works
            }

            inventoryDB.SaveChanges();
            cardInfo.Show();
        }
    }
}
