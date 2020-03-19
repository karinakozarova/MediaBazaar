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
        AddOtherContacts adc;
        List<int> workdays = new List<int>();
        List<int> workshifts = new List<int>();
        
        string username;

        public CreateAccount()
        {
            InitializeComponent();
            pc = new PeopleController();
            adc = new AddOtherContacts( );
            
        }
        string contactFirstName;
        string contactLastName;
        DateTime contactDateOFBirth;
        string contactEmail;
        long contactPhone;
        public CreateAccount(string contactFirstName, string contactLastName, DateTime contactDateOFBirth, string contactEmail, long contactPhone)
        {
            this.contactFirstName = contactFirstName;
            this.contactLastName = contactLastName;
            this.contactDateOFBirth = contactDateOFBirth;
            this.contactEmail = contactEmail;
            this.contactPhone = contactPhone;
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                this.username = tbUsername.Text;
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                DateTime dateOfBirth = dtpBirthdate.Value;
                string street = tbStreet.Text;
                string postcode = tbPostcode.Text;
                string region = tbRegion.Text;
                string country = tbCountry.Text;
                string email = tbEmail.Text;
                decimal hourlyWage = nHourlyWage.Value;
                long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
                pc.CreateWorker(firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, username, hourlyWage);//adds worker to people

                string workdaysQuery = "INSERT into employee_working_days (employee_id, week_day_id) VALUE(@userId,@weekDayId)";
                MySqlCommand workdaysCmd = new MySqlCommand(workdaysQuery, conn);
                conn.Open();
                //workdaysCmd.Parameters.AddWithValue("@userId", user_id);
                foreach (int d in workdays)
                {
                    workdaysCmd.Parameters.AddWithValue("@weekDayId", d);

                    workdaysCmd.ExecuteNonQuery();
                }
                conn.Close();

                string shiftQuery = "INSERT into employee_working_days (employee_id, shifts) VALUE(@userId,@shifts)";
                MySqlCommand shiftQueryCmd = new MySqlCommand(shiftQuery, conn);
                conn.Open();
               // shiftQueryCmd.Parameters.AddWithValue("@userId", user_id);
                foreach (int s in workshifts)
                {
                    shiftQueryCmd.Parameters.AddWithValue("@shifts", s);

                    shiftQueryCmd.ExecuteNonQuery();
                }

                ////selecting id by username
                //string userIdQuery = "SELECT id FROM person where username=@username";
                //MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);

                //userIdCmd.Parameters.AddWithValue("@username", username);
                //Object userIdResult = userIdCmd.ExecuteScalar();

                //if (userIdResult != null)
                //{
                //    user_id = Convert.ToInt32(userIdResult);
                //}
                ////string otherContactIdQuery = "SELECT id FROM person where id=@contactId";
                ////MySqlCommand otherContactIdCmd = new MySqlCommand(otherContactIdQuery, conn);

                ////userIdCmd.Parameters.AddWithValue("@ContactId", adc.OtherContactId());
                ////Object otherContactIdResult = userIdCmd.ExecuteScalar();
                ////int contact_id = 0;
                ////if (userIdResult != null)
                ////{
                ////    contact_id = Convert.ToInt32(userIdResult);
                ////}

                //string contactIdQuery = "INSERT into contact_person(employee_id, contact_person_id) VALUES( @userId, @contactId);";
                //MySqlCommand contactIdCmd = new MySqlCommand(contactIdQuery, conn);
                //contactIdCmd.Parameters.AddWithValue("@userId", user_id);
                //contactIdCmd.Parameters.AddWithValue("@contactId", adc.OtherContactId());

                //string findContactIdQuery = "SELECT p.contact_person_id FROM Person AS p INNER JOIN contact_person AS c ON p.id=c.contact_person_id";
                //MySqlCommand findContactIdCmd = new MySqlCommand(findContactIdQuery, conn);
                //MySqlDataReader dr = findContactIdCmd.ExecuteReader();   ///not sure
                //List<Person> contactPeople = new List<Person>();
                //while (dr.Read())
                //{
                //    contactPeople.Add();
                //}
                //conn.Close();




                if (cbAdmin.Checked)
                {
                    ProfileRoles role = ProfileRoles.ADMINISTRATOR;
                }
                else if (cbManager.Checked)
                {
                    ProfileRoles role = ProfileRoles.MANAGER;         //how to store in db
                }
                else if (cbEmployee.Checked)
                {
                    ProfileRoles role = ProfileRoles.EMPLOYEE;
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
            string username = tbUsername.Text;
            int user_id = 0;
            int ContactId=0;
            int count = -1;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string userIdQuery = "SELECT id FROM person where username=@username;";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object userIdResult = userIdCmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    user_id = Convert.ToInt32(userIdResult);
                }

                

                string selectContactIdQuery = "SELECT id FROM person where first_name=@firstName AND last_name=@lastName AND date_of_birth=@dateOfBirth AND email=@email AND phone_number=@phoneN";
                    MySqlCommand selectContactIdCmd = new MySqlCommand(selectContactIdQuery, conn);
                    selectContactIdCmd.Parameters.AddWithValue("@firstName", contactFirstName);
                    selectContactIdCmd.Parameters.AddWithValue("@lastName", contactLastName);
                    selectContactIdCmd.Parameters.AddWithValue("@dateOfBirth", contactDateOFBirth);
                    selectContactIdCmd.Parameters.AddWithValue("@email", contactEmail);
                    selectContactIdCmd.Parameters.AddWithValue("@phoneN", contactPhone);
                    Object contactIdResult = selectContactIdCmd.ExecuteScalar();

                    if (contactIdResult != null)
                    {
                        ContactId = Convert.ToInt32(contactIdResult);
                    }

                    //string otherContactIdQuery = "SELECT id FROM person where id=@contactId";
                    //MySqlCommand otherContactIdCmd = new MySqlCommand(otherContactIdQuery, conn);

                    //userIdCmd.Parameters.AddWithValue("@ContactId", adc.OtherContactId());
                    //Object otherContactIdResult = userIdCmd.ExecuteScalar();
                    //int contact_id = 0;
                    //if (userIdResult != null)
                    //{
                    //    contact_id = Convert.ToInt32(userIdResult);
                    //}

                    string contactIdQuery = "INSERT INTO contact_person (employee_id, contact_person_id) VALUES (@userId, @contactId);";
                    MySqlCommand contactIdCmd = new MySqlCommand(contactIdQuery, conn);

                    contactIdCmd.Parameters.AddWithValue("@userId", user_id);
                    contactIdCmd.Parameters.AddWithValue("@contactId", ContactId);

                    //string findContactIdQuery = "SELECT p.contact_person_id FROM Person AS p INNER JOIN contact_person AS c ON p.id=c.contact_person_id";
                    //MySqlCommand findContactIdCmd = new MySqlCommand(findContactIdQuery, conn);
                    //MySqlDataReader dr = findContactIdCmd.ExecuteReader();   ///not sure
                    //List<Person> contactPeople = new List<Person>();
                    //while (dr.Read())
                    //{
                    //    contactPeople.Add();
                    //}
                    //conn.Close();
                
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

        private void btnOpenContact_Click(object sender, EventArgs e)
        {
            AddOtherContacts aoc = new AddOtherContacts();
            aoc.Show();
        }
    }
}
