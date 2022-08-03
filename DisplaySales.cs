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

        public string salesPath = @"C:\Project PRG281\TextFiles\AllSales.txt";
        public string[] textFileSales;

        public DisplaySales()
        {
            InitializeComponent();
            int textFileLength;
            int splitLength;



            textFileSales = File.ReadAllLines(salesPath);
            textFileLength = textFileSales.Length;

            string[] splitProductFile = new string[textFileSales.Length * 2];
            splitLength = splitProductFile.Length;

            if (textFileLength != 0)
            {
                for (int i = 0; i < textFileLength; i++)
                {
                    splitProductFile = textFileSales[i].Split(',');

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DisplaySales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < textFileSales.Length; i++)
            {
                this.richTextBox1.AppendText(Environment.NewLine + textFileSales[i]);
            }
        }
    }
}
