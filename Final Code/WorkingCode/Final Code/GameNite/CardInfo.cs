﻿using System;
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
    public partial class CardInfo : Form
    {
        ThankYou thankYou = new ThankYou();
        public CardInfo()
        {
            InitializeComponent();
        }

        private void btnUseCard_Click(object sender, EventArgs e)
        {
            thankYou.Show();
        }

    }
}
