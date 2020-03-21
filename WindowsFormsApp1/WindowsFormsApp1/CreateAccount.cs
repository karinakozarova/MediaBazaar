using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreateAccount : Form
    {
        AddOtherContacts aoc;
        PeopleController pc;
        string username;
        decimal hourlyWage;
        List<int> workdays = new List<int>();
        List<int> workshifts = new List<int>();
        List<String> displayContacts;
        int loggedInUser;
        int workerRole;
        int contactCounter;

        public CreateAccount(int user_id, int workerRole)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pc = new PeopleController();
            PopulateDepartments(Department.GetAllDepartments());
            this.loggedInUser = user_id;
            displayContacts = new List<String>();
            dtbContractStartDate.MinDate = System.DateTime.Now;
            dtbContractStartDate.Value = System.DateTime.Now;
            dtpBirthdate.Value = System.DateTime.Now;
            dtpBirthdate.MaxDate = System.DateTime.Now;
            contactCounter = 0;

            this.workerRole = workerRole;
            if (workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                btnEdit.Visible = true;
                btnSendRequest.Visible = false;
                rbEmployee.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.MANAGER)
            {
                btnEdit.Visible = false;
                btnCreateAccount.Visible = false;
                rbAdmin.Visible = false;
                rbManager.Visible = false;
                this.Text = "Hiring Request";
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            decimal minHourlyWage = 7;
            if (tbUsername.Text == "Username" || tbFirstName.Text == "First name" || tbLastName.Text == "Last name" || tbCountry.Text == "Country" || tbRegion.Text == "region" || tbPostcode.Text == "postcode" || tbStreet.Text == "street" || tbPhoneNumber.Text == "Phone number" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Please change the initial information in the fields!");
            }
            else if (tbUsername.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbCountry.Text == "Country" || tbRegion.Text == "" || tbPostcode.Text == "" || tbStreet.Text == "" || tbPhoneNumber.Text == "" || tbPassword.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (!cbMonday.Checked && !cbTuesday.Checked && !cbWednesday.Checked && !cbThursday.Checked && !cbFriday.Checked && !cbSaturday.Checked && !cbSunday.Checked)
            {
                MessageBox.Show("Please select available working days!");
            }
            else if (!cbMorningShift.Checked && !cbAfternoonShift.Checked && !cbEveningShift.Checked)
            {
                MessageBox.Show("Please select a prefered workshift!");
            }
            else if (nHourlyWage.Value < minHourlyWage)
            {
                MessageBox.Show("Employee hourly wage must be above the minimum!");
            }
            else if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
            } else
            {
                if (UniqueUsername())
                {
                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        int accountType = 0;
                        if (rbAdmin.Checked)
                        {

                            accountType = (int)ProfileRoles.ADMINISTRATOR;

                        }
                        else if (rbManager.Checked)
                        {
                            accountType = (int)ProfileRoles.MANAGER;
                        }
                        else if (rbEmployee.Checked)
                        {
                            accountType = (int)ProfileRoles.EMPLOYEE;
                        }

                        int contract_id = 0;
                        this.username = tbUsername.Text;
                        string firstName = tbFirstName.Text;
                        string lastName = tbLastName.Text;
                        DateTime dateOfBirth = dtpBirthdate.Value;
                        string street = tbStreet.Text;
                        string postcode = tbPostcode.Text;
                        string region = tbRegion.Text;
                        string country = tbCountry.Text;
                        string email = tbEmail.Text;
                        hourlyWage = nHourlyWage.Value;
                        string password = tbPassword.Text;
                        long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
                        DateTime contractStartDate = dtbContractStartDate.Value;
                        int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                        pc.CreateWorker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, hourlyWage, contractStartDate, departmentId);//adds worker to person table

                        string contractQuery = "INSERT into contract (person_id, contract_start) VALUES (@person_id, @contract_start);";
                        MySqlCommand contractCmd = new MySqlCommand(contractQuery, conn);
                        contractCmd.Parameters.AddWithValue("@person_id", GetIdByUsername());
                        contractCmd.Parameters.AddWithValue("@contract_start", contractStartDate);
                        conn.Open();
                        contractCmd.ExecuteNonQuery();

                        string userIdQuery = "SELECT id FROM contract where person_id=@person_id;";
                        MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                        userIdCmd.Parameters.AddWithValue("@person_id", GetIdByUsername());
                        Object userIdResult = userIdCmd.ExecuteScalar();

                        if (userIdResult != null)
                        {
                            contract_id = Convert.ToInt32(userIdResult);
                        }

                        string employeDetailsQuery = "INSERT into employee_details(person_id, hourly_wage, contract_id, department_id, is_approved) VALUES (@person_id, @hourly_wage, @contract_id, @department_id, @is_approved);";
                        MySqlCommand employeDetailsCmd = new MySqlCommand(employeDetailsQuery, conn);
                        employeDetailsCmd.Parameters.AddWithValue("@person_id", GetIdByUsername());
                        employeDetailsCmd.Parameters.AddWithValue("@hourly_wage", hourlyWage);
                        employeDetailsCmd.Parameters.AddWithValue("@contract_id", contract_id);
                        employeDetailsCmd.Parameters.AddWithValue("@department_id", departmentId);//department ID department class
                        employeDetailsCmd.Parameters.AddWithValue("@is_approved", 1);
                        employeDetailsCmd.ExecuteNonQuery();

                        if (cbMonday.Checked)
                        {
                            workdays.Add(0);
                        }
                        if (cbTuesday.Checked)
                        {
                            workdays.Add(1);
                        }
                        if (cbWednesday.Checked)
                        {
                            workdays.Add(2);
                        }
                        if (cbThursday.Checked)
                        {
                            workdays.Add(3);
                        }
                        if (cbFriday.Checked)
                        {
                            workdays.Add(4);
                        }
                        if (cbSaturday.Checked)
                        {
                            workdays.Add(5);
                        }
                        if (cbSunday.Checked)
                        {
                            workdays.Add(6);
                        }

                        if (cbMorningShift.Checked)
                        {
                            workshifts.Add(1);
                        }
                        if (cbAfternoonShift.Checked)
                        {
                            workshifts.Add(2);
                        }
                        if (cbEveningShift.Checked)
                        {
                            workshifts.Add(3);
                        }

                        foreach (int shift in workshifts)
                        {
                            foreach (int day in workdays)
                            {
                                string shiftsQuery = "INSERT into employee_working_days (employee_id,week_day_id, shift) VALUE(@userId,@week_day_id, @shift)";
                                MySqlCommand shiftsQueryCmd = new MySqlCommand(shiftsQuery, conn);
                                shiftsQueryCmd.Parameters.AddWithValue("@shift", shift);
                                shiftsQueryCmd.Parameters.AddWithValue("@userId", GetIdByUsername());
                                shiftsQueryCmd.Parameters.AddWithValue("@week_day_id", day);
                                shiftsQueryCmd.ExecuteNonQuery();
                            }
                        }
                        HiringRequests hr = new HiringRequests(GetIdByUsername(), loggedInUser, this.username, firstName, lastName, this.hourlyWage, departmentId, contractStartDate, phoneN, email);
                        HiringRequests hr1 = new HiringRequests(GetIdByUsername(), loggedInUser);
                        if (!hr1.FrExists)
                        {
                            MessageBox.Show("Hiring request already exists!");
                        }
                        else
                        {
                            MessageBox.Show("Request sent successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                else { MessageBox.Show("User with that username already exists."); }
            }
            
        }

        private void btnAddOtherContact_Click(object sender, EventArgs e)
        {
            if(this.contactCounter == 2)
            {
                btnAddOtherContact.Enabled = false;
                MessageBox.Show("Sorry you have reached the limit of contacts per person!");
            }
            else
            {
                int ContactId = 0;
                MySqlConnection conn = Utils.GetConnection();
                try
                {
                    string selectContactIdQuery = "SELECT id FROM person where first_name=@firstName AND last_name=@lastName AND date_of_birth=@dateOfBirth AND email=@email AND phone_number=@phoneN";
                    MySqlCommand selectContactIdCmd = new MySqlCommand(selectContactIdQuery, conn);
                    selectContactIdCmd.Parameters.AddWithValue("@firstName", aoc.FirstName);
                    selectContactIdCmd.Parameters.AddWithValue("@lastName", aoc.LastName);
                    selectContactIdCmd.Parameters.AddWithValue("@dateOfBirth", aoc.DateOfBirth);
                    selectContactIdCmd.Parameters.AddWithValue("@email", aoc.Email);
                    selectContactIdCmd.Parameters.AddWithValue("@phoneN", aoc.PhoneNumber);
                    conn.Open();
                    Object contactIdResult = selectContactIdCmd.ExecuteScalar();

                    if (contactIdResult != null)
                    {
                        ContactId = Convert.ToInt32(contactIdResult);
                    }

                    string contactIdQuery = "INSERT INTO contact_person (employee_id, contact_person_id) VALUES (@userId, @contactId);";
                    MySqlCommand contactIdCmd = new MySqlCommand(contactIdQuery, conn);
                    contactIdCmd.Parameters.AddWithValue("@userId", GetIdByUsername());
                    contactIdCmd.Parameters.AddWithValue("@contactId", ContactId);
                    contactIdCmd.ExecuteNonQuery();

                    this.contactCounter++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                PopulateListBoxOtherContacts();
            }
            
        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void btnOpenContact_Click(object sender, EventArgs e)
        {
            aoc = new AddOtherContacts(this);
            aoc.Show();
        }

        public int GetIdByUsername()
        {
            string username = tbUsername.Text;
            int user_id = 0;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string userIdQuery = "SELECT account_id FROM user where username=@username;";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object userIdResult = userIdCmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    user_id = Convert.ToInt32(userIdResult);
                }
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return user_id;
        }
        public void PopulateListBoxOtherContacts()
        {
            lbContacts.Items.Clear();
            foreach (string s in pc.PopulateListBox(GetIdByUsername()))
            {
                lbContacts.Items.Add(s);
            }

        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            PopulateListBoxOtherContacts();
        }
        public bool UniqueUsername()
        {
            string username = tbUsername.Text;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string usernameQuery = "SELECT username FROM user where username=@username;";
                MySqlCommand usernameCmd = new MySqlCommand(usernameQuery, conn);
                usernameCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object userIdResult = usernameCmd.ExecuteScalar();

                if (userIdResult == null)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public void ShowContact(string contact)
        {
            this.displayContacts.Add(contact);
        }
        public void ShowListContacts()
        {
            lbContacts.Items.Clear();
            foreach(string s in displayContacts)
            {
                lbContacts.Items.Add(s);
            }
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            decimal minHourlyWage = 7;
            if (tbUsername.Text == "Username" || tbFirstName.Text == "First name" || tbLastName.Text == "Last name" || tbCountry.Text == "Country" || tbRegion.Text == "region" || tbPostcode.Text == "postcode" || tbStreet.Text == "street" || tbPhoneNumber.Text == "Phone number" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Please change the initial information in the fields!");
            }
            else if (tbUsername.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbCountry.Text == "Country" || tbRegion.Text == "" || tbPostcode.Text == "" || tbStreet.Text == "" || tbPhoneNumber.Text == "" || tbPassword.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (!rbAdmin.Checked && !rbManager.Checked)
            {
                MessageBox.Show("Please select an account type!");
            }
            else if (!cbMonday.Checked && !cbTuesday.Checked && !cbWednesday.Checked && !cbThursday.Checked && !cbFriday.Checked && !cbSaturday.Checked && !cbSunday.Checked)
            {
                MessageBox.Show("Please select available working days!");
            }
            else if (!cbMorningShift.Checked && !cbAfternoonShift.Checked && !cbEveningShift.Checked)
            {
                MessageBox.Show("Please select a prefered workshift!");
            }
            else if (nHourlyWage.Value < minHourlyWage)
            {
                MessageBox.Show("Employee hourly wage must be above the minimum!");
            }
            else if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
            }
            else
            {
                if (UniqueUsername())
                {
                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        int accountType = 0;
                        if (rbAdmin.Checked)
                        {

                            accountType = (int)ProfileRoles.ADMINISTRATOR;

                        }
                        else if (rbManager.Checked)
                        {
                            accountType = (int)ProfileRoles.MANAGER;
                        }
                        else if (rbEmployee.Checked)
                        {
                            accountType = (int)ProfileRoles.EMPLOYEE;
                        }
                        int contract_id = 0;
                        this.username = tbUsername.Text;
                        string firstName = tbFirstName.Text;
                        string lastName = tbLastName.Text;
                        DateTime dateOfBirth = dtpBirthdate.Value;
                        string street = tbStreet.Text;
                        string postcode = tbPostcode.Text;
                        string region = tbRegion.Text;
                        string country = tbCountry.Text;
                        string email = tbEmail.Text;
                        hourlyWage = nHourlyWage.Value;
                        string password = tbPassword.Text;
                        long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
                        DateTime contractStartDate = dtbContractStartDate.Value;
                        int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                        pc.CreateWorker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, hourlyWage, contractStartDate, departmentId);//adds worker to person table

                        string contractQuery = "INSERT into contract (person_id, contract_start) VALUES (@person_id, @contract_start);";
                        MySqlCommand contractCmd = new MySqlCommand(contractQuery, conn);
                        contractCmd.Parameters.AddWithValue("@person_id", GetIdByUsername());
                        contractCmd.Parameters.AddWithValue("@contract_start", contractStartDate);
                        conn.Open();
                        contractCmd.ExecuteNonQuery();

                        string userIdQuery = "SELECT id FROM contract where person_id=@person_id;";
                        MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                        userIdCmd.Parameters.AddWithValue("@person_id", GetIdByUsername());
                        Object userIdResult = userIdCmd.ExecuteScalar();

                        if (userIdResult != null)
                        {
                            contract_id = Convert.ToInt32(userIdResult);
                        }

                        string employeDetailsQuery = "INSERT into employee_details(person_id, hourly_wage, contract_id, department_id, is_approved) VALUES (@person_id, @hourly_wage, @contract_id, @department_id, @is_approved);";
                        MySqlCommand employeDetailsCmd = new MySqlCommand(employeDetailsQuery, conn);
                        employeDetailsCmd.Parameters.AddWithValue("@person_id", GetIdByUsername());
                        employeDetailsCmd.Parameters.AddWithValue("@hourly_wage", hourlyWage);
                        employeDetailsCmd.Parameters.AddWithValue("@contract_id", contract_id);
                        employeDetailsCmd.Parameters.AddWithValue("@department_id", departmentId);//department ID department class
                        employeDetailsCmd.Parameters.AddWithValue("@is_approved", 2);
                        employeDetailsCmd.ExecuteNonQuery();

                        if (cbMonday.Checked)
                        {
                            workdays.Add(0);
                        }
                        if (cbTuesday.Checked)
                        {
                            workdays.Add(1);
                        }
                        if (cbWednesday.Checked)
                        {
                            workdays.Add(2);
                        }
                        if (cbThursday.Checked)
                        {
                            workdays.Add(3);
                        }
                        if (cbFriday.Checked)
                        {
                            workdays.Add(4);
                        }
                        if (cbSaturday.Checked)
                        {
                            workdays.Add(5);
                        }
                        if (cbSunday.Checked)
                        {
                            workdays.Add(6);
                        }

                        if (cbMorningShift.Checked)
                        {
                            workshifts.Add(1);
                        }
                        if (cbAfternoonShift.Checked)
                        {
                            workshifts.Add(2);
                        }
                        if (cbEveningShift.Checked)
                        {
                            workshifts.Add(3);
                        }

                        foreach (int shift in workshifts)
                        {
                            foreach (int day in workdays)
                            {
                                string shiftsQuery = "INSERT into employee_working_days (employee_id,week_day_id, shift) VALUE(@userId,@week_day_id, @shift)";
                                MySqlCommand shiftsQueryCmd = new MySqlCommand(shiftsQuery, conn);
                                shiftsQueryCmd.Parameters.AddWithValue("@shift", shift);
                                shiftsQueryCmd.Parameters.AddWithValue("@userId", GetIdByUsername());
                                shiftsQueryCmd.Parameters.AddWithValue("@week_day_id", day);
                                shiftsQueryCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else { MessageBox.Show("User with that username already exists."); }
            }
            

        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var emailAddr = new System.Net.Mail.MailAddress(email);
                return emailAddr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
