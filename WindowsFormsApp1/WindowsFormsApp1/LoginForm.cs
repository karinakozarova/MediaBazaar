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
            (new AdministratorShiftsOverview()).Show();

            (new AddStock()).Show();
            (new SearchForEmployee()).Show();
            (new RemoveEmployee()).Show();
            (new ShelfRestockRequests()).Show();
            (new MainForm()).Show();
            (new CreateAccount()).Show();
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
