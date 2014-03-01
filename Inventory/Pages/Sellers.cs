using System;
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
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
        }

        private void Button_addseller_Click(object sender, EventArgs e)
        {
            #region Adding to combo Box
            //if it isn't blank, add the name
            if (ComboBox_sellers.Text != "")
            {
                ComboBox_sellers.Items.Add(ComboBox_sellers.Text);
            }
            else
            {
                MessageBox.Show("You have not entered a name. Please enter a name before " +
                    "adding it to the list.", "Error");
            }
            #endregion

        }

        private void Button_deleteseller_Click(object sender, EventArgs e)
        {
            ComboBox_sellers.Items.Remove(ComboBox_sellers.SelectedItem);
        }

 
    }
}
