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
        int loggedInUser;
        public CreateAccount(int user_id)
        {
            InitializeComponent();
            pc = new PeopleController();
            PopulateDepartments(Department.GetAllDepartments());
            this.loggedInUser = user_id;
        }

        public CreateAccount(AddOtherContacts aoc = null)
        {
            this.aoc = aoc;
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                int accountType = 0;
                if (cbAdmin.Checked)
                {
                    accountType = (int)ProfileRoles.ADMINISTRATOR;
                }
                else if (cbManager.Checked)
                {
                    accountType = (int)ProfileRoles.MANAGER;
                }
                else if (cbEmployee.Checked)
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

        private void btnAddOtherContact_Click(object sender, EventArgs e)
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

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void btnOpenContact_Click(object sender, EventArgs e)
        {
            aoc = new AddOtherContacts();
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
        private void btnShowContacts_Click(object sender, EventArgs e)
        {
            PopulateListBoxOtherContacts();
        }
        public void AddToListBox(List<Person> contacts)
        {
            foreach (Person p in contacts)
            {
                lbContacts.Items.Add(p.ToString());
            }
        }
        public void PopulateListBoxOtherContacts()
        {
            lbContacts.Items.Clear();
            foreach (string s in pc.PopulateListBox(GetIdByUsername()))
            {
                lbContacts.Items.Add(s);
            }

        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                int accountType = 0;
                if (cbAdmin.Checked)
                {

                    accountType = (int)ProfileRoles.ADMINISTRATOR;

                }
                else if (cbManager.Checked)
                {
                    accountType = (int)ProfileRoles.MANAGER;
                }
                else if (cbEmployee.Checked)
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
    }
}
