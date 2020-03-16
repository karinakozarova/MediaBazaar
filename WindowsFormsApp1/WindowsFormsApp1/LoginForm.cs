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
            
            MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi425113;Database=dbi425113;Pwd=bropro12;");
            string sql = "SELECT count(id) FROM user;"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            // Send the query to the database and do something awesome with it

            Object result = cmd.ExecuteScalar();
            int count = -1; if (result != null) { count = Convert.ToInt32(result); }
            MessageBox.Show(count.ToString());

            conn.Close();


        }
    }
}
