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
            Menu menu = new Menu();
            addOrder.Show();
            menu.Hide();
            this.Hide();
        }

        private void butUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock updateStock = new UpdateStock();
            Menu menu = new Menu();
            updateStock.Show();
            menu.Hide();
            this.Hide();
        }

        private void butAddRemove_Click(object sender, EventArgs e)
        {
            AddRemoveItem addRemoveItem = new AddRemoveItem();
            Menu menu = new Menu();
            addRemoveItem.Show();
            menu.Hide();
            this.Hide();
        }

        private void butRecordSales_Click(object sender, EventArgs e)
        {
            RecordSales recordSales = new RecordSales();
            Menu menu = new Menu();
            recordSales.Show();
            menu.Hide();
            this.Hide();
        }

        private void butDisplaySales_Click(object sender, EventArgs e)
        {
            DisplaySales displaySales = new DisplaySales();
            Menu menu = new Menu();
            displaySales.Show();
            menu.Hide();
            this.Hide();
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Menu menu = new Menu();
            login.Show();
            menu.Hide();
            this.Hide();
        }
    }
}
