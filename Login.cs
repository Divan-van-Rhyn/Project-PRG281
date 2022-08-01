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
           

            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
