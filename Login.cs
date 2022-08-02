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
        

        public Login()
        {
            InitializeComponent();
            
        }
      
        //private void butLogIn_Click(object sender, EventArgs e)
        //{

        //    // string[] Password = { "123", "ackley246", "mypassword", "donotknow" };          
        //    // string[] Username =  { "Admin", "Ackley", "John", "Rian" };

        //    string usernameText = usernameTextBox.Text;
        //    string passwordText = passwordTextBox.Text;
        //    bool login = false;
        //    while (login == false)
        //    {
        //        if ((usernameText == "Admin" && passwordText == "123") || (usernameText == "John" && passwordText == "321"))
        //        {
        //            Menu menu = new Menu();
        //            this.Hide();
        //            menu.ShowDialog();
        //            login = true;
        //            this.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Username or password is wrong.");
        //        }
        //        break;
        //    }

            



        //}

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogIn_Click_1(object sender, EventArgs e)
        {
            

            string[,] Logins = new string[,]
                  {
                   {"Admin","123"},
                   {"Ackley","ackley246"},
                   {"John","mypassword"},
                   {"Rian","donotknow"}
                   };

            string usernameText = usernameTextBox.Text;
            string passwordText = passwordTextBox.Text;

            
           
                for (int r = 0; r <= Logins.GetLength(0); r++)
                {
                    if (usernameText == Logins[r, 0] && passwordText == Logins[r, 1])
                    {
                        Menu menu = new Menu();
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {

                        MessageBox.Show("Username or password is wrong.", "IMPORTANT MESSAGE!");                      
                        break;
                    }                  
                }         
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
 
        }
    }
}
