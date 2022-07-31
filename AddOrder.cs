using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_PRG281
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void butCheckout_Click(object sender, EventArgs e)
        {
            DisplaySales displaySales = new DisplaySales();
            displaySales.Show();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
