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

            List<string> updatedMenuList = File.ReadLines(productMenu.updatedDisplayProductPath).ToList();



            using (StreamWriter writer = File.AppendText(@"C:\Project PRG281\TextFiles\BCMenu.txt"))
            {
                for (int i = 0; i < updatedMenuList.Count; i++)
                {
                    writer.WriteLine(updatedMenuList[i]);
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e, string removeItem)
        {
            removeItem = itemRemoveTextBox.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();

            ProductMenu productMenu = new ProductMenu();
            string nameOfProduct = itemAddTextBox.Text;
            string priceOfProduct = priceTextBox.Text;
            productMenu.AddingProduct(nameOfProduct, priceOfProduct);
            productMenu.ExportText();
            //productMenu.ImportText();

            //List<string> addedProduct = File.ReadAllLines(productMenu.updatedDisplayProductPath).ToList();

            //for (int i = 0; i < addedProduct.Count; i++)
            //{
            //    this.richTextBox2.AppendText(Environment.NewLine + addedProduct[i]);
            //}

            //productMenu.CombineTextFiles();

            string content = File.ReadAllText(productMenu.addedfilePath);
            File.AppendAllText(productMenu.updatedDisplayProductPath, content);

            List<string> updatedMenu = File.ReadAllLines(productMenu.updatedDisplayProductPath).ToList();

            for (int i = 0; i < updatedMenu.Count; i++)
            {
                this.richTextBox2.AppendText(Environment.NewLine + updatedMenu[i]);
            }


            itemAddTextBox.Clear();
            priceTextBox.Clear();
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

            List<string> updatedMenu = File.ReadAllLines(productMenu.updatedDisplayProductPath).ToList();

            for (int i = 0; i < updatedMenu.Count; i++)
            {
                this.richTextBox2.AppendText(Environment.NewLine + updatedMenu[i]);
            }

            itemRemoveTextBox.Clear();
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
            ProductMenu productMenu = new ProductMenu();

            if (textNameUpdate == null || textPriceUpdate == null)
            {
                MessageBox.Show("One or more fields have not been filled in", "ERROR");
            }
            else
            {
                FileInfo file = new FileInfo(productMenu.updatedDisplayProductPath);
                using (StreamWriter writer = file.AppendText())
                {
                    writer.WriteLine(textNameUpdate.Text + ", " + textPriceUpdate.Text);
                }

                MessageBox.Show("Product has succesfully been updated", "SUCCESS");
            }

            //string originalName = textUpdate.Text;
            //string updatedName = textNameUpdate.Text;

            

           
            //productMenu.UpdatingProductName(originalName, updatedName);
        }

        private void butUpdatePrice_Click(object sender, EventArgs e)
        {
            string originalName = textUpdate.Text;
            string updatedPrice = textPriceUpdate.Text;

            ProductMenu productMenu = new ProductMenu();
            //productMenu.UpdatingProductName(originalName, updatedPrice);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();

            try
            {
                var oldLines = System.IO.File.ReadAllLines(productMenu.updatedDisplayProductPath);
                var newLines = oldLines.Where(line => !line.Contains(textUpdate.Text));
                System.IO.File.WriteAllLines(productMenu.updatedDisplayProductPath, newLines);
                FileStream obj = new FileStream(productMenu.updatedDisplayProductPath, FileMode.Append);
                obj.Close();


            }
            catch 
            {
                MessageBox.Show("Item not found", "ERROR");
            }
            


            butUpdateName.Enabled = true;
        }
    }
}
