﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
         

            InitializeComponent();
        }

        private void Button_sellers_Click(object sender, EventArgs e)
        {
            Sellers SellersForm = new Sellers();
            SellersForm.Show();
        }

        private void Button_financing_Click(object sender, EventArgs e)
        {
            Pages.Finance FinanceForm = new Pages.Finance();
            FinanceForm.Show();
        }

      

       

        
    }
}
