using Project_PRG281;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG281
{
    public partial class Login : Form
    {
        string[,] LoginDet =
        {
                { "Admin","123"},
                {"Ackley", "Ackley456"},
                {"John","myPassword" },
                {"Rian","donotknow" }
        };


        bool proceed = false;
        string usernameText;
        string passwordText;
        int attempts = 0;

        public Login()
        {
            InitializeComponent();
            
        }
      


        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogIn_Click_1(object sender, EventArgs e)
        {


       

            usernameText = usernameTextBox.Text;
            passwordText = passwordTextBox.Text;

            if (attempts <= 2)
            {
                for (int r = 0; r < LoginDet.GetLength(0); r++)
                {
                    if (usernameText == LoginDet[r, 0] && passwordText == LoginDet[r, 1])
                    {
                        proceed = true;
                       // MessageBox.Show("Welcome " + LoginDet[r, 0], "SUCCESSFUL"  );
                        Menu MainMenuForm = new Menu();
                        this.Hide();

                        MainMenuForm.ShowDialog();
                        this.Show();
                        attempts = 0;
                        break;
                    }
                    else
                    {
                        proceed = false;
                    }


                }
                if (proceed == false)
                {
                    MessageBox.Show("Try again...");
                    attempts++;
                }
            }
            else
            {
                MessageBox.Show("Incorrect credentials");
                attempts = 0;
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
 
        }
    }
}
