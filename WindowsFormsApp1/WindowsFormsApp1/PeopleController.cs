using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{

    class PeopleController
    {
        CreateAccount ca;
        public void ApproveFire()
        {

        }
        public void RemoveManager()
        {

        }
        public void GetAllFireRequests()
        {

        }

        public void GetAllHiringRequests()
        {

        }
        public void ApproveHire()
        {

        }
        public void AddManager()
        {

        }
        public void CreatePerson(string firstName, string lastName, DateTime dateOfBirth, long phoneNumber, string email)
        {
            Person person = new Person(firstName, lastName, dateOfBirth, phoneNumber, email);
        }
        public void CreateWorker(int accountType, string username, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, decimal hourlyWage, DateTime contractStartDate, int departmentId)
        {
            Worker worker = new Worker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneNumber, email, hourlyWage, contractStartDate, departmentId);


        }
        public List<Person> GetOtherContacts()
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
        public List<string> PopulateListBox(int user_id)
        {
            MySqlConnection conn = Utils.GetConnection();
            List<string> listContacts = new List<string>();
            try
            {

                string ShowContactsQuery = "SELECT p.first_name, p.last_name, p.date_of_birth, p.phone_number, p.email  FROM person AS p INNER JOIN contact_person AS cp ON p.id = cp.contact_person_id where employee_id=@userId;";
                MySqlCommand ShowContactsCmd = new MySqlCommand(ShowContactsQuery, conn);
                ShowContactsCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                MySqlDataReader row = ShowContactsCmd.ExecuteReader();

                while (row.Read())
                {
                    listContacts.Add(row["first_name"] + " " + row["last_name"] + " " + "date of birth: " + row["date_of_birth"] + " " + "tel: " + row["phone_number"] + " " + "email: " + row["email"].ToString());
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
            return listContacts;
        }
        
    }
}
