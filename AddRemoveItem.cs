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
            //creates a connection between the class that contains all our methods (ProductMenu)
            ProductMenu productMenu = new ProductMenu();

            //Creates a list that the text file gets stored in when accessed through file path
            List<string> menuProducts = File.ReadLines(productMenu.productDisplayFilePath).ToList();

           for (int i = 0; i < menuProducts.Count; i++)
            {
                //shows the output in the richTextBox
                //Environment.NewLine writes each of the elements on a new line instead of next to each other
                this.richTextBox1.AppendText(Environment.NewLine + menuProducts[i]);
            }

            //Creates a list that the text file gets stored in when accessed through file path
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
            //Clears the rich text box in order to show new outputs
            richTextBox2.Clear();

            //establish connection to another class
            ProductMenu productMenu = new ProductMenu();

            //variables that stores a string that it gets from user input
            string nameOfProduct = itemAddTextBox.Text;
            string priceOfProduct = priceTextBox.Text;
            //Method that gets called from the class that adds the products to textfile
            productMenu.AddingProduct(nameOfProduct, priceOfProduct);
            //Method that gets called to export text file
            productMenu.ExportText();

            //Reads from the textfile via file path
            string content = File.ReadAllText(productMenu.addedfilePath);
            //Writes to the textfile
            File.AppendAllText(productMenu.updatedDisplayProductPath, content);


            //list that stores elemets from textfile that stores the updated menu
            List<string> updatedMenu = File.ReadAllLines(productMenu.updatedDisplayProductPath).ToList();

            for (int i = 0; i < updatedMenu.Count; i++)
            {
                this.richTextBox2.AppendText(Environment.NewLine + updatedMenu[i]);
            }


            //Clears the textboxes so the user doesn't have to clear them by themselves
            itemAddTextBox.Clear();
            priceTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes the current form and shows the previous menu form
            this.Close();
        }
        //Once the product have been searched for that needs to be removed the button will then execute 
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
        //The updated product name is inserted and updated price it is validated
        private void butUpdateName_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            //If one or more fields is left empty a will be displayede mess
            if (textNameUpdate == null || textPriceUpdate == null)
            {
                MessageBox.Show("One or more fields have not been filled in", "ERROR");
            }
            //If all fields have been completed it will append the new poductname/price
            else
            {
                FileInfo file = new FileInfo(productMenu.updatedDisplayProductPath);
                using (StreamWriter writer = file.AppendText())
                {
                    writer.WriteLine(textNameUpdate.Text + ", " + textPriceUpdate.Text);
                }

                MessageBox.Show("Product has succesfully been updated", "SUCCESS");
            }

        }
        //Once the Update button is clicked it will update the name and/or price of the product
        private void butUpdatePrice_Click(object sender, EventArgs e)
        {
            string originalName = textUpdate.Text;
            string updatedPrice = textPriceUpdate.Text;

            ProductMenu productMenu = new ProductMenu();

        }
        //Product is searched through the text file
        private void butSearch_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            //The try statements tries to execute the search
            try
            {
                var oldLines = System.IO.File.ReadAllLines(productMenu.updatedDisplayProductPath);
                var newLines = oldLines.Where(line => !line.Contains(textUpdate.Text));
                System.IO.File.WriteAllLines(productMenu.updatedDisplayProductPath, newLines);
                FileStream obj = new FileStream(productMenu.updatedDisplayProductPath, FileMode.Append);
                obj.Close();

            }
            //If product is not found the catch statements is then employed and displays the relevant message
            catch 
            {
                MessageBox.Show("Item not found", "ERROR");
            }
            


            butUpdateName.Enabled = true;
        }
    }
}
