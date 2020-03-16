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
        public LoginForm()
        {
            InitializeComponent();
            mediaBazarLogoLogin.BorderStyle = BorderStyle.None;

            // TODO: this is added for debugging now, remove later
            (new AddStock()).Show();
            (new SearchForEmployee()).Show();
            (new RemoveEmployee()).Show();
            (new ShelfRestockRequests()).Show();
            (new MainForm()).Show();
            (new CreateAccount()).Show();
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrWhiteSpace(usernameLoginInput.Text))
            {
                MessageBox.Show("enter username");
                return;
            }
            
            if(String.IsNullOrWhiteSpace(passwordLoginInput.Text))
            {
                MessageBox.Show("enter password");
                return;
            }

            string username = usernameLoginInput.Text;
            string psswd = passwordLoginInput.Text;
           
            
        }
    }
}
