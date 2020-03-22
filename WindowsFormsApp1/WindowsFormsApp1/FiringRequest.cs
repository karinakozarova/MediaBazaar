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
        private int workerRole;
        public FiringRequest(int user_id, int workerRole)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbxFirstName.Enabled = false;
            tbxLastName.Enabled = false;
            PopulateDepartments(Department.GetAllDepartments());
            PopulateManagers(Manager.GetAllManagers());
            this.loggedUserId = user_id;
            this.workerRole = workerRole;
            if (workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                btnSendFiringRequest.Visible = false;
                this.Text = "Remove manager!";
            }
            else if (workerRole == (int)ProfileRoles.MANAGER)
            {
                btnRemoveManager.Visible = false;
            }
        }

        public FiringRequest(bool flag, int departmentId, string username, string firstName, string lastName, string description)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (flag)
            {
                this.Enabled = false;
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
                }
            }
        }

        public DateTime GetDateTime()
        {
            DateTime date = DateTime.Now;
            return date;
        }
        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }
        private void PopulateManagers(List<Manager> managers)
        {
            foreach(Manager m in managers)
            {
                cmbManagers.Items.Add(new ManagerComboBoxItems(m));
            }
        }

        private void BtnSendFiringRequest_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            
            string description = rtbReason.Text;
            string username = tbxUsername.Text;
            try
            {
                int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
                {
                    MessageBox.Show("Please select a department from the menu!");
                }
                else if (tbxUsername.Text == "Username" || rtbReason.Text == "Reason for firing")
                {
                    MessageBox.Show("Please change the initial information in the fields!");
                }
                else if (tbxUsername.Text == "" || rtbReason.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields in the table!");
                }
                else
                {
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

                        string accountTypeQuery = "SELECT account_type FROM user where account_id=@user_id";
                        MySqlCommand accountTypeCmd = new MySqlCommand(accountTypeQuery, conn);
                        accountTypeCmd.Parameters.AddWithValue("@user_id", user_id);
                        Object accountTypeResult = accountTypeCmd.ExecuteScalar();
                        int accountType = 0;
                        if (accountTypeResult != null) { accountType = Convert.ToInt32(accountTypeResult); }
                        if (accountType == (int)ProfileRoles.ADMINISTRATOR || accountType == (int)ProfileRoles.MANAGER)
                        {
                            MessageBox.Show("Sorry you can't send firing request for administrator or manager account!");
                        }
                        else
                        {
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
                            }
                            else
                            {
                                tbxFirstName.Text = firstName;
                                tbxLastName.Text = lastName;
                                MessageBox.Show("Request sent successfully!");
                            }
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
            catch
            {
                MessageBox.Show("Please select a department from the menu!");
            }
                
        }

        private void BtnRemoveManager_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            string description = rtbReason.Text;
            string username = tbxUsername.Text;
            List<int> contactIds = new List<int>();
            try
            {
                int managerId = ((ManagerComboBoxItems)cmbManagers.SelectedItem).Id;
                if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
                {
                    MessageBox.Show("Please select a department from the menu!");
                }
                else if (rtbReason.Text == "Reason for firing")
                {
                    MessageBox.Show("Please change the initial information in the fields!");
                }
                else if (cmbManagers.Text == "Managers" || cmbManagers.Text == "")
                {
                    MessageBox.Show("Please select a manager from the menu!");
                }
                else if (tbxUsername.Text == "" || rtbReason.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields in the table!");
                }
                else
                {
                    try
                    {
                        string userRemoveQuery = "DELETE From user WHERE account_id = @manager_Id";
                        MySqlCommand userRemoveCmd = new MySqlCommand(userRemoveQuery, conn);
                        conn.Open();
                        userRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        userRemoveCmd.ExecuteNonQuery();

                        string employeeRemoveQuery = "DELETE From employee_details WHERE person_id = @manager_Id";
                        MySqlCommand employeeRemoveCmd = new MySqlCommand(employeeRemoveQuery, conn);
                        employeeRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        employeeRemoveCmd.ExecuteNonQuery();

                        string employeeDaysRemoveQuery = "DELETE From employee_working_days WHERE employee_id = @manager_Id";
                        MySqlCommand employeeDaysRemoveCmd = new MySqlCommand(employeeDaysRemoveQuery, conn);
                        employeeDaysRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        employeeDaysRemoveCmd.ExecuteNonQuery();

                        string sql = "SELECT contact_person_id FROM contact_person WHERE employee_id = @manager_Id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@manager_Id", managerId);
                        MySqlDataReader row = cmd.ExecuteReader();
                        while (row.Read())
                        {
                            contactIds.Add(Convert.ToInt32(row[0]));
                        }
                        conn.Close();

                        string employeeContactRemoveQuery = "DELETE From contact_person WHERE employee_id = @manager_Id";
                        MySqlCommand employeeContactRemoveCmd = new MySqlCommand(employeeContactRemoveQuery, conn);
                        conn.Open();
                        employeeContactRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        employeeContactRemoveCmd.ExecuteNonQuery();

                        foreach (int id in contactIds)
                        {
                            string contactRemoveQuery = "DELETE FROM person WHERE id=@contact_Id";
                            MySqlCommand contactRemoveCmd = new MySqlCommand(contactRemoveQuery, conn);
                            contactRemoveCmd.Parameters.AddWithValue("@contact_id", id);
                            contactRemoveCmd.ExecuteNonQuery();
                        }

                        string contractUpdateQuery = "UPDATE contract SET contract_end = @end_date, reason_for_leaving = @description WHERE person_id = @manager_Id";
                        MySqlCommand contractUpdateCmd = new MySqlCommand(contractUpdateQuery, conn);
                        contractUpdateCmd.Parameters.AddWithValue("@end_date", GetDateTime());
                        contractUpdateCmd.Parameters.AddWithValue("@description", rtbReason.Text);
                        contractUpdateCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        contractUpdateCmd.ExecuteNonQuery();
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
            catch
            {
                MessageBox.Show("Please select a department from the menu!");
            }
        }
    }
}
