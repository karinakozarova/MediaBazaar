using MySql.Data.MySqlClient;
using System;

namespace WindowsFormsApp1
{
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string street;
        private string postcode;
        private string region;
        private string country;
        private long phoneNumber;
        private string email;


        public string FirstName {get { return firstName; }}
        public string LastName { get { return lastName; } }
        public DateTime DateOFBirth { get { return dateOfBirth; } }
        public string Street
        {
            get { return street; }
           private set{ street = value; } 
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Postcode 
        { 
            get { return postcode; }
            private set { postcode = value; }
        }
        public string Region 
        { 
            get { return region; }
            private set { region = value; }
        }
        public string Country 
        { 
            get { return country; }
           private set { country = value; }
        }
        public long PhoneNumber 
        { 
            get { return phoneNumber; }
            private set { phoneNumber = value; }
        }
        public string Email 
        { 
            get { return email; }
           private set { email = value; }
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.street = street;
            this.postcode = postcode;
            this.region = region;
            this.country = country;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.email = email;
            AddPerson();
        }

        private void AddPerson()
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string sql = "INSERT INTO person(first_name, last_name, date_of_birth, phone_number, email) VALUES (@first_name, @last_name, @date_of_birth, @phone_number, @email);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", FirstName);
                cmd.Parameters.AddWithValue("@last_name", LastName);
                cmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
                cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                cmd.Parameters.AddWithValue("@email", Email);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                this.id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally
            {
                conn.Close();
            }

        }
        //private void AddWorker()
        //{
        //    MySqlConnection conn = Utils.GetConnection();

        //    try
        //    {
        //        string sql = "INSERT INTO person(username, first_name, last_name, date_of_birth, street, postcode, region, country, phone_number, email) VALUES (@username, @first_name, @last_name, @date_of_birth,@street, @postcode, @region, @country, @phone_number, @email);";
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@username", username);
        //        cmd.Parameters.AddWithValue("@first_name", FirstName);
        //        cmd.Parameters.AddWithValue("@last_name", LastName);
        //        cmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
        //        cmd.Parameters.AddWithValue("@street", street);
        //        cmd.Parameters.AddWithValue("@postcode", Postcode);
        //        cmd.Parameters.AddWithValue("@region", region);
        //        cmd.Parameters.AddWithValue("@country", country);
        //        cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
        //        cmd.Parameters.AddWithValue("@email", Email);
        //        conn.Open();
        //        int effectedRows = cmd.ExecuteNonQuery();
        //        this.id = (int)cmd.LastInsertedId;
        //    }
        //    catch (Exception ex)
        //    {
        //        String e = ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}
        public string GetName()
        {
            return firstName + " " + lastName;
        }
        public string GetAddress()
        {
            return street + ", "+ postcode + ", "+region + ", "+ country;
        }
        public virtual string ToString()
        {
            return id+ ": " + firstName + "  " + lastName + " - " + dateOfBirth + " - " + phoneNumber + " - " + email;
        }



    }
}