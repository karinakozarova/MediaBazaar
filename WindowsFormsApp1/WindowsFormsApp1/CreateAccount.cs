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
    public partial class CreateAccount : Form
    {
        PeopleController pc;
        List<int> workdays = new List<int>();
        List<int> workshifts = new List<int>();
        string username;
        decimal hourlyWage;



        AddOtherContacts aoc;


         string  contactFirstName;
           string contactLastName;
           DateTime contactDateOFBirth;
            string contactEmail;
           long contactPhone;
        string displayContact;
        public CreateAccount()
        {
            InitializeComponent();
            pc = new PeopleController();
            PopulateDepartments(Department.GetAllDepartments());
            if (!string.IsNullOrEmpty(displayContact))
            {
                lbContacts.Items.Add(displayContact);
            }
        }

        public CreateAccount(string contactFirstName, string contactLastName, DateTime contactDateOFBirth, string contactEmail, long contactPhone,string displayContact, AddOtherContacts aoc=null)
        {
            this.contactFirstName = contactFirstName;
            this.contactLastName = contactLastName;
            this.contactDateOFBirth = contactDateOFBirth;
            this.contactEmail = contactEmail;
            this.contactPhone = contactPhone;
            this.aoc = aoc;
            this.displayContact = displayContact;
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
                pc.CreateWorker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, hourlyWage);//adds worker to person table


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
                employeDetailsCmd.Parameters.AddWithValue("@department_id", 1);//department ID department class
                employeDetailsCmd.Parameters.AddWithValue("@is_approved", 1);
                employeDetailsCmd.ExecuteNonQuery();


                string workdaysQuery = "INSERT into employee_working_days (employee_id, week_day_id) VALUE(@userId,@weekDayId)";
                MySqlCommand workdaysCmd = new MySqlCommand(workdaysQuery, conn);
                workdaysCmd.Parameters.AddWithValue("@userId", GetIdByUsername());
                foreach (int d in workdays)
                {
                    workdaysCmd.Parameters.AddWithValue("@weekDayId", d);

                    workdaysCmd.ExecuteNonQuery();
                }
                

                string shiftsQuery = "INSERT into employee_working_days (employee_id, shifts) VALUE(@userId,@shifts)";
                MySqlCommand shiftsQueryCmd = new MySqlCommand(shiftsQuery, conn);
                
                // shiftQueryCmd.Parameters.AddWithValue("@userId", user_id);
                foreach (int s in workshifts)
                {
                    shiftsQueryCmd.Parameters.AddWithValue("@shifts", s);

                    shiftsQueryCmd.ExecuteNonQuery();
                }


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
                    workshifts.Add(0);
                }
                if (cbAfternoonShift.Checked)
                {
                    workshifts.Add(1);
                }
                if (cbEveningShift.Checked)
                {
                    workshifts.Add(2);
                }
            }
            catch(Exception ex) 
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
            
            int ContactId=0;
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

        
        public static List<Department> GetAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT name, description, needed_people, id FROM departments";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    departments.Add(new Department(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2]), Convert.ToInt32(row[3])));
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
            return departments;
        }
        public  List<Person> GetOtherContacts()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Person> contacts = new List<Person>();
            try
            {
                string sql = "SELECT first_name, last_name,date_of_birth, phone_number,email FROM person;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    contacts.Add(new Person(row[0].ToString(), row[1].ToString(), Convert.ToDateTime(row[2]), Convert.ToInt64(row[3]), (row[4]).ToString()));
                }
                foreach (Person p in contacts)
                {
                    lbContacts.Items.Add(p.ToString());
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
            return contacts;
        }
      

            public void PopulateListBox(int user_id)
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string ShowContactsQuery = "SELECT p.first_name, p.last_name, p.date_of_birth, p.phone_number, p.email  FROM person AS p INNER JOIN contact_person AS cp ON p.id = cp.contact_person_id where employee_id=@userId;";
                MySqlCommand ShowContactsCmd = new MySqlCommand(ShowContactsQuery, conn);
                ShowContactsCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                MySqlDataReader row = ShowContactsCmd.ExecuteReader();

                while (row.Read())
                {
                    lbContacts.Items.Add(row["first_name"] +" " + row["last_name"] +" "+ "date of birth: "+row["date_of_birth"] +" "+ "tel: " + row["phone_number"] + " " + "email: " + row["email"].ToString());
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

        private int GetIdByUsername()
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
          PopulateListBox(GetIdByUsername());
        }
    }
}
