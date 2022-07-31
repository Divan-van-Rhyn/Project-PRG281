using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_PRG281
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void butNewOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            this.Hide();
            addOrder.ShowDialog();
            this.Show();
        }

        private void butUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock updateStock = new UpdateStock();
            this.Hide();
            updateStock.ShowDialog();
            this.Show();
        }

        private void butAddRemove_Click(object sender, EventArgs e)
        {
            AddRemoveItem addRemoveItem = new AddRemoveItem();
            this.Hide();
            addRemoveItem.ShowDialog();
            this.Show();
        }

        private void butRecordSales_Click(object sender, EventArgs e)
        {
            RecordSales recordSales = new RecordSales();
            this.Hide();
            recordSales.ShowDialog();
            this.Show();

        }

        private void butDisplaySales_Click(object sender, EventArgs e)
        {
            DisplaySales displaySales = new DisplaySales();
            this.Hide();
            displaySales.ShowDialog();
            this.Show();
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
