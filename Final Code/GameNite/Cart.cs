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

namespace GameNite
{
    public partial class Cart : Form
    {
        ThankYou thankYou = new ThankYou();
        
        public Cart()
        {
            InitializeComponent();

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            
        }

    }
}
