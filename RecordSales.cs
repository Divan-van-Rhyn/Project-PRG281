using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_PRG281
{
    public partial class RecordSales : Form
    {
        public RecordSales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            RecordSales recordSales = new RecordSales();
            menu.Show();
            recordSales.Hide();
            this.Hide();
        }
    }
}
