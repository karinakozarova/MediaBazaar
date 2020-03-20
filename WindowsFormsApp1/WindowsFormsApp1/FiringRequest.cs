using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FiringRequest : Form
    {
        private int loggedUserId;
        public FiringRequest(int user_id)
        {
            InitializeComponent();
            tbxFirstName.Enabled = false;
            tbxLastName.Enabled = false;
            PopulateDepartments(Department.GetAllDepartments());
            this.loggedUserId = user_id;
        }

        public FiringRequest(bool flag, int departmentId, string username, string firstName, string lastName, string description)
        {
            InitializeComponent();
            if (flag)
            {
                tbxFirstName.Enabled = false;
                tbxLastName.Enabled = false;
                tbxUsername.Enabled = false;
                cmbDepartment.Enabled = false;
                rtbReason.Enabled = false;
                btnSendFiringRequest.Visible = false;
                tbxFirstName.Text = firstName;
                tbxLastName.Text = lastName;
                tbxUsername.Text = username;
                rtbReason.Text = description;
                List<Department> departments = new List<Department>();
                departments = Department.GetAllDepartments();
                foreach (Department d in departments)
                {
                    if(d.DepartmentId == departmentId)
                    {
                        cmbDepartment.Text = d.Name;
                    }
                };
            }
        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void BtnSendFiringRequest_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            
            string description = rtbReason.Text;
            string username = tbxUsername.Text;
            int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
            try
            {
                string userIdQuery = "SELECT account_id FROM user where username=@username";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object userIdResult = userIdCmd.ExecuteScalar();
                int user_id = 0;
                if (userIdResult != null) { user_id = Convert.ToInt32(userIdResult); }
                else { MessageBox.Show("Wrong username!"); return; }

                string userFirstNameQuery = "SELECT first_name FROM person WHERE id=@user_id";
                MySqlCommand userFirstNameCmd = new MySqlCommand(userFirstNameQuery, conn);
                userFirstNameCmd.Parameters.AddWithValue("@user_id", user_id);
                Object userFirstNameResult = userFirstNameCmd.ExecuteScalar();
                string firstName = "";
                if (userFirstNameResult != null) { firstName = userFirstNameResult.ToString(); }

                string userLastNameQuery = "SELECT last_name FROM person WHERE id=@user_id";
                MySqlCommand userLastNameCmd = new MySqlCommand(userLastNameQuery, conn);
                userLastNameCmd.Parameters.AddWithValue("@user_id", user_id);
                Object userLastNameResult = userLastNameCmd.ExecuteScalar();
                string lastName = "";
                if (userLastNameResult != null) { lastName = userLastNameResult.ToString(); }
                FiringRequests fr = new FiringRequests(user_id, this.loggedUserId, username, description, firstName, lastName, departmentId);
                FiringRequests fr1 = new FiringRequests(user_id, this.loggedUserId, description);
                if (!fr1.FrExists)
                {
                    MessageBox.Show("Firing request already exists!");
                }else
                {
                    tbxFirstName.Text = firstName;
                    tbxLastName.Text = lastName;
                    MessageBox.Show("Request sent successfully!");
                }
            }
            catch (Exception ex)
            {
                string epra = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
