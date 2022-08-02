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
    public partial class AddOrder : Form
    {

        public int finalPrice;
        public List<string> receipt = new List<string>();
        public string salesFilePath = @"C:\Project PRG281\TextFiles\Sales.txt";

        public AddOrder()
        {
            InitializeComponent();
            finalPrice = 0;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void butCheckout_Click(object sender, EventArgs e)
        {
            File.WriteAllText(salesFilePath, string.Empty);
            using (StreamWriter writer = File.AppendText(salesFilePath))
            {
                writer.WriteLine("------------------------------------------------------");
                for (int i = 0; i < receipt.Count; i++)
                {
                    string theProducts = (receipt[i]);
                    writer.WriteLine(theProducts);
                }
                writer.WriteLine("------------------------------------------------------");
            }
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                finalPrice = (int)(finalPrice + (40 * numericUpDown54.Value));
                numericUpDown54.Value++;
                receipt.Add(checkBox1.Text + " " + label54.Text);
            }
            else if (checkBox9.Checked == false)
            {
                receipt.Remove(checkBox9.Text + " " + label74.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                finalPrice = (int)(finalPrice + (11 * numericUpDown40.Value));
                numericUpDown40.Value++;
                receipt.Add(checkBox2.Text + " " + label40.Text);
            }
            else if (checkBox1.Checked == false)
            {
                receipt.Remove(checkBox1.Text + " " + label74.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                finalPrice = (int)(finalPrice + (18 * numericUpDown39.Value));
                numericUpDown39.Value++;
                receipt.Add(checkBox2.Text + " " + label39.Text);
            }
            else if (checkBox2.Checked == false)
            {
                receipt.Remove(checkBox2.Text + " " + label74.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                finalPrice = (int)(finalPrice + (13 * numericUpDown49.Value));
                numericUpDown49.Value++;
                receipt.Add(checkBox3.Text + " " + label49.Text);
            }
            else if (checkBox3.Checked == false)
            {
                receipt.Remove(checkBox3.Text + " " + label74.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                finalPrice = (int)(finalPrice + (18 * numericUpDown48.Value));
                numericUpDown48.Value++;
                receipt.Add(checkBox4.Text + " " + label48.Text);
            }
            else if (checkBox4.Checked == false)
            {
                receipt.Remove(checkBox4.Text + " " + label74.Text);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                finalPrice = (int)(finalPrice + (22 * numericUpDown47.Value));
                numericUpDown47.Value++;
                receipt.Add(checkBox5.Text + " " + label47.Text);
            }
            else if (checkBox5.Checked == false)
            {
                receipt.Remove(checkBox5.Text + " " + label74.Text);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                finalPrice = (int)(finalPrice + (20 * numericUpDown45.Value));
                numericUpDown45.Value++;
                receipt.Add(checkBox6.Text + " " + label45.Text);
            }
            else if (checkBox6.Checked == false)
            {
                receipt.Remove(checkBox6.Text + " " + label74.Text);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                finalPrice = (int)(finalPrice + (26 * numericUpDown44.Value));
                numericUpDown44.Value++;
                receipt.Add(checkBox7.Text + " " + label44.Text);
            }
            else if (checkBox7.Checked == false)
            {
                receipt.Remove(checkBox7.Text + " " + label74.Text);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                finalPrice = (int)(finalPrice + (30 * numericUpDown55.Value));
                numericUpDown55.Value++;
                receipt.Add(checkBox8.Text + " " + label55.Text);
            }
            else if (checkBox8.Checked == false)
            {
                receipt.Remove(checkBox8.Text + " " + label74.Text);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                finalPrice = (int)(finalPrice + (47 * numericUpDown53.Value));
                numericUpDown53.Value++;
                receipt.Add(checkBox10.Text + " " + label53.Text);
            }
            else if (checkBox10.Checked == false)
            {
                receipt.Remove(checkBox10.Text + " " + label74.Text);
            }
        }

        private void numericUpDown62_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                finalPrice = (int)(finalPrice + (28 * numericUpDown62.Value));
                numericUpDown62.Value++;
                receipt.Add(checkBox11.Text + " " + label62.Text);
            }
            else if (checkBox11.Checked == false)
            {
                receipt.Remove(checkBox11.Text + " " + label74.Text);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                finalPrice = (int)(finalPrice + (38 * numericUpDown61.Value));
                numericUpDown61.Value++;
                receipt.Add(checkBox12.Text + " " + label61.Text);
            }
            else if (checkBox12.Checked == false)
            {
                receipt.Remove(checkBox12.Text + " " + label74.Text);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                finalPrice = (int)(finalPrice + (45 * numericUpDown60.Value));
                numericUpDown60.Value++;
                receipt.Add(checkBox13.Text + " " + label60.Text);
            }
            else if (checkBox13.Checked == false)
            {
                receipt.Remove(checkBox13.Text + " " + label74.Text);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                finalPrice = (int)(finalPrice + (6 * numericUpDown65.Value));
                numericUpDown65.Value++;
                receipt.Add(checkBox14.Text + " " + label65.Text);
            }
            else if (checkBox14.Checked == false)
            {
                receipt.Remove(checkBox14.Text + " " + label74.Text);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                finalPrice = (int)(finalPrice + (17 * numericUpDown64.Value));
                numericUpDown64.Value++;
                receipt.Add(checkBox15.Text + " " + label64.Text);
            }
            else if (checkBox15.Checked == false)
            {
                receipt.Remove(checkBox15.Text + " " + label74.Text);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                finalPrice = (int)(finalPrice + (8 * numericUpDown63.Value));
                numericUpDown63.Value++;
                receipt.Add(checkBox16.Text + " " + label63.Text);
            }
            else if (checkBox16.Checked == false)
            {
                receipt.Remove(checkBox16.Text + " " + label74.Text);
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                finalPrice = (int)(finalPrice + (16 * numericUpDown73.Value));
                numericUpDown73.Value++;
                receipt.Add(checkBox17.Text + " " + label73.Text);
            }
            else if (checkBox17.Checked == false)
            {
                receipt.Remove(checkBox17.Text + " " + label74.Text);
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                finalPrice = (int)(finalPrice + (8 * numericUpDown72.Value));
                numericUpDown72.Value++;
                receipt.Add(checkBox18.Text + " " + label72.Text);
            }
            else if (checkBox18.Checked == false)
            {
                receipt.Remove(checkBox18.Text + " " + label74.Text);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                finalPrice = (int)(finalPrice + (15 * numericUpDown71.Value));
                numericUpDown71.Value++;
                receipt.Add(checkBox19.Text + " " + label71.Text);
            }
            else if (checkBox19.Checked == false)
            {
                receipt.Remove(checkBox19.Text + " " + label74.Text);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                finalPrice = (int)(finalPrice + (17 * numericUpDown76.Value));
                numericUpDown76.Value++;
                receipt.Add(checkBox20.Text + " " + label76.Text);
            }
            else if (checkBox20.Checked == false)
            {
                receipt.Remove(checkBox20.Text + " " + label74.Text);
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                finalPrice = (int)(finalPrice + (17 * numericUpDown75.Value));
                numericUpDown75.Value++;
                receipt.Add(checkBox21.Text + " " + label75.Text);
            }
            else if (checkBox21.Checked == false)
            {
                receipt.Remove(checkBox21.Text + " " + label74.Text);
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                finalPrice = (int)(finalPrice + (17 * numericUpDown74.Value));
                numericUpDown74.Value++;
                receipt.Add(checkBox22.Text + " " + label74.Text);
            }
            else if (checkBox22.Checked == false)
            {
                receipt.Remove(checkBox22.Text + " " + label74.Text);
            } 

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < receipt.Count; i++)
            {
                this.richTextBox1.AppendText(Environment.NewLine + receipt[i]);
            }
            this.richTextBox1.AppendText(Environment.NewLine + "R" + finalPrice.ToString());
        }
    }
}
