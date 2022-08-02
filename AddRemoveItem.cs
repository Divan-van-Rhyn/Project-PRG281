using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Project_PRG281
{
    public partial class AddRemoveItem : Form
    {

        

        public AddRemoveItem()
        {
            InitializeComponent();        
            ProductMenu productMenu = new ProductMenu();

            List<string> menuProducts = File.ReadLines(productMenu.productDisplayFilePath).ToList();

            

           for (int i = 0; i < menuProducts.Count; i++)
            {
                this.richTextBox1.AppendText(Environment.NewLine + menuProducts[i]);
            }
            
            
        }
        
        private void button1_Click(object sender, EventArgs e, string removeItem)
        {
            removeItem = itemRemoveTextBox.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            string nameOfProduct = itemAddTextBox.Text;
            string priceOfProduct = priceTextBox.Text;
            productMenu.AddingProduct(nameOfProduct, priceOfProduct);
            productMenu.ExportText();
            productMenu.ImportText();

                List<string> addedProduct = File.ReadAllLines(productMenu.updatedDisplayProductPath).ToList();

            for (int i = 0; i < addedProduct.Count; i++)
            {
                this.richTextBox2.AppendText(Environment.NewLine + addedProduct[i]);
            }

            productMenu.CombineTextFiles();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            string productName = itemRemoveTextBox.Text;
            productMenu.RemovingProduct(productName);
            itemAddTextBox.Clear();
            priceTextBox.Clear();
        }

        private void AddRemoveItem_Load(object sender, EventArgs e)
        {
            itemRemoveTextBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butUpdateName_Click(object sender, EventArgs e)
        {
            string originalName = textUpdate.Text;
            string updatedName = textNameUpdate.Text;

            ProductMenu productMenu = new ProductMenu();
            productMenu.UpdatingProductName(originalName, updatedName);
        }

        private void butUpdatePrice_Click(object sender, EventArgs e)
        {
            string originalName = textUpdate.Text;
            string updatedPrice = textPriceUpdate.Text;

            ProductMenu productMenu = new ProductMenu();
            productMenu.UpdatingProductName(originalName, updatedPrice);
        }
    }
}
