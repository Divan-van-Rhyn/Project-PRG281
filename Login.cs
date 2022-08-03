using Project_PRG281;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG281
{
    public partial class Login : Form
    {
        //Username and password 2D array
        string[,] LoginDet =
        {
                { "Admin","123"},
                {"Ackley", "Ackley456"},
                {"John","myPassword" },
                {"Rian","donotknow" }
        };


        bool proceed = false;
        //Variable that stores text from textbox
        string usernameText;
        //Variable that stores text from textbox
        string passwordText;
        int attempts = 0;

        public Login()
        {
            InitializeComponent();
            
        }
      

        //Exits the application from Login Screen
        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogIn_Click_1(object sender, EventArgs e)
        {


       
            //gets the text from textbox and adds it to publicly declared variable
            usernameText = usernameTextBox.Text;
            passwordText = passwordTextBox.Text;
            //Iterates through login array to validate username and password
            if (attempts <= 2)
            {
                for (int r = 0; r < LoginDet.GetLength(0); r++)
                {
                    if (usernameText == LoginDet[r, 0] && passwordText == LoginDet[r, 1])
                    {
                        proceed = true;
                        //adds a wait time of 1 second before switching between forms
                        Thread.Sleep(1000);
                        //opens menu form 
                        Menu MainMenuForm = new Menu();
                        //Hides current form
                        this.Hide();

                        MainMenuForm.ShowDialog();
                        this.Show();
                        attempts = 0;
                        //breaks the if
                        break;
                    }
                    else
                    {
                        //declares Login as unsuccesful 
                        proceed = false;
                    }


                }
                //If Username or Password is incorrect message is shown
                if (proceed == false)
                {
                    Thread.Sleep(1000);
                    MessageBox.Show("Try again...");
                    attempts++;
                }
            }
            //After 3 attempts user are returned to Login screen
            else
            {
                Thread.Sleep(1000);
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
