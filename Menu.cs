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
            //Opens the form that allows us to place an order
            AddOrder addOrder = new AddOrder();
            //Hides current form
            this.Hide();
            addOrder.ShowDialog();
            this.Show();
        }

        private void butUpdateStock_Click(object sender, EventArgs e)
        {

        }

        private void butAddRemove_Click(object sender, EventArgs e)
        {
            //Opens the form that allows us to add/remove/update menu
            AddRemoveItem addRemoveItem = new AddRemoveItem();
            //Hides the menu form
            this.Hide();
            addRemoveItem.ShowDialog();
            this.Show();
        }

        private void butRecordSales_Click(object sender, EventArgs e)
        {
            
        }
        //User is taken to the Display Sales form once the button is clicked
        private void butDisplaySales_Click(object sender, EventArgs e)
        {
            DisplaySales displaySales = new DisplaySales();
            this.Hide();
            displaySales.ShowDialog();
            this.Show();
        }
        //THe menu can be exited by this button
        private void butLogOut_Click(object sender, EventArgs e)
        {
            //Closes this form and takes us back to login form
            this.Close();
        }
    }
}
