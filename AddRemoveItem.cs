using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_PRG281
{
    public partial class AddRemoveItem : Form
    {
        public AddRemoveItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRemoveItem addRemoveItem = new AddRemoveItem();
            Menu menu = new Menu();
            menu.Show();
            addRemoveItem.Hide();
            this.Hide();
        }
    }
}
