using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project_PRG281
{


    public partial class DisplaySales : Form
    {

        //Publicly declared variable and array 
        //Variable contains the filepath to the textfile
        public string salesPath = @"C:\Project PRG281\TextFiles\AllSales.txt";
        //Array will contain contents from textfile
        public string[] textFileSales;

        public DisplaySales()
        {
            InitializeComponent();

            //When the form initializes 2 variables are declared
            int textFileLength;
            int splitLength;


            //Rich edit shows all the text in the textfile as soon as the form is initialized
            textFileSales = File.ReadAllLines(salesPath);
            textFileLength = textFileSales.Length;

            string[] splitProductFile = new string[textFileSales.Length * 2];
            splitLength = splitProductFile.Length;

            if (textFileLength != 0)
            {
                for (int i = 0; i < textFileLength; i++)
                {
                    //The file gets split at the comma so that we can amke use of product names and prices apart from each other
                    splitProductFile = textFileSales[i].Split(',');

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes the current form and goed back to menu form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DisplaySales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //on click event that displays all the sales that have taken place
            //iterates through text file
            for (int i = 0; i < textFileSales.Length; i++)
            {
                this.richTextBox1.AppendText(Environment.NewLine + textFileSales[i]);
            }
        }
    }
}
