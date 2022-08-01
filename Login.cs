using Project_PRG281.DataService;
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
      
        private void butLogIn_Click(object sender, EventArgs e)
        {

            // string[] Password = { "123", "ackley246", "mypassword", "donotknow" };          
            // string[] Username =  { "Admin", "Ackley", "John", "Rian" };

            string usernameText = usernameTextBox.Text;
            string passwordText = passwordTextBox.Text;

            if (usernameText == "Admin" && passwordText == "123")
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or password is wrong.");
            }



        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogIn_Click_1(object sender, EventArgs e)
        {
            int attempt = 0;

            string[,] Logins = new string[,]
                  {
                   {"Admin","123"},
                   {"Ackley","ackley246"},
                   {"John","mypassword"},
                   {"Rian","donotknow"}
                   };

            string usernameText = usernameTextBox.Text;
            string passwordText = passwordTextBox.Text;

            bool Login = false;
            while (Login == false)
            {
                for (int r = 0; r <= Logins.GetLength(0); r++)
                {
                    if (usernameText == Logins[r, 0] && passwordText == Logins[r, 1])
                    {
                        Menu menu = new Menu();
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                        Login = true;
                        break;
                    }
                    else
                    {


                        MessageBox.Show("Username or password is wrong.", "IMPORTANT MESSAGE!");
                        attempt++;
                        MessageBox.Show("Attempt: " + attempt.ToString());

                        if (attempt == 3)
                        {
                            Application.Exit();
                        }
                        break;
                    }                  
                }         
                break;
            }
        }
    }
}
