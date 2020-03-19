using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        Worker worker;
        public LoginForm()
        {
            InitializeComponent();
            mediaBazarLogoLogin.BorderStyle = BorderStyle.None;
            //worker = new Worker();
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrWhiteSpace(usernameLoginInput.Text))
            {
                MessageBox.Show("Enter username");
                return;
            }
            
            if(String.IsNullOrWhiteSpace(passwordLoginInput.Text))
            {
                MessageBox.Show("enter password");
                return;
            }

            string username = usernameLoginInput.Text;
            string psswd = passwordLoginInput.Text;
            bool isLoggedIn = worker.Login(username,psswd);
            if (!isLoggedIn)
            {
                MessageBox.Show("Wrong credentials");
                return;
            }
            (new MainForm(username)).Show();
            this.Hide();
        }
    }
}
