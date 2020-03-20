using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Worker: Person
    {
        private decimal hourlyWage = 0;

        public bool IsLoggedIn
        {
            get;
            private set;
        }

        public Worker(int accountType,string username, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, decimal hourlyWage, DateTime contractStartDate, int departmentId)
            :base(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneNumber, email, hourlyWage, contractStartDate, departmentId)
        {
            this.hourlyWage = hourlyWage;
            AddWorker();
        }
        public Worker()
        {

        }
        private void AddWorker()
        {
            int user_id = 0;
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string personSql = "INSERT INTO person(first_name, last_name, date_of_birth, street, postcode, region, country, phone_number, email) VALUES (@first_name, @last_name, @date_of_birth, @street, @postcode, @region, @country, @phone_number, @email);";
                MySqlCommand personCmd = new MySqlCommand(personSql, conn);
                personCmd.Parameters.AddWithValue("@first_name", FirstName);
                personCmd.Parameters.AddWithValue("@last_name", LastName);
                personCmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
                personCmd.Parameters.AddWithValue("@street", Street);
                personCmd.Parameters.AddWithValue("@postcode", Postcode);
                personCmd.Parameters.AddWithValue("@region", Region);
                personCmd.Parameters.AddWithValue("@country", Country);
                personCmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                personCmd.Parameters.AddWithValue("@email", Email);
                conn.Open();
                personCmd.ExecuteNonQuery();

                string userIdQuery = "SELECT id FROM person where first_name=@firstName AND last_name=@lastName AND date_of_birth=@date_of_birth AND street=@street AND postcode=@postcode AND region=@region AND country=@country AND phone_number=@phone_number AND email=@email;";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@firstName", FirstName);
                userIdCmd.Parameters.AddWithValue("@lastName", LastName);
                userIdCmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
                userIdCmd.Parameters.AddWithValue("@street", Street);
                userIdCmd.Parameters.AddWithValue("@postcode", Postcode);
                userIdCmd.Parameters.AddWithValue("@region", Region);
                userIdCmd.Parameters.AddWithValue("@country", Country);
                userIdCmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                userIdCmd.Parameters.AddWithValue("@email", Email);
                Object userIdResult = userIdCmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    user_id = Convert.ToInt32(userIdResult);
                }

                string userSql = "INSERT INTO user(username, password, account_id, account_type) VALUES (@username, @password, @account_id, @account_type);";
                MySqlCommand userCmd = new MySqlCommand(userSql, conn);
                userCmd.Parameters.AddWithValue("@username", Username);
                userCmd.Parameters.AddWithValue("@password", Password);
                userCmd.Parameters.AddWithValue("@account_id", (int)user_id);
                userCmd.Parameters.AddWithValue("@account_type", AccountType);
                userCmd.ExecuteNonQuery();
                this.Id = (int)userCmd.LastInsertedId;

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

        public int Id
        {
            get;
            private set;
        }
        public decimal GetWage()
        {
            return this.hourlyWage;
        }

        public int WorkerRole
        {
            get;
            private set;
        }

        public double TotalHoursWorked()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = -1;

            try
            {
                string sql = "SELECT count(id) FROM user where username=@username and password=@password;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();

                Object result = cmd.ExecuteScalar();
                if (result != null) { count = Convert.ToInt32(result); }
                if (count == 1)
                {
                    IsLoggedIn = true;
                   // this.username = username;

                    string userIdQuery = "SELECT id FROM user where username=@username";
                    MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                    userIdCmd.Parameters.AddWithValue("@username", username);
                    Object userIdResult = userIdCmd.ExecuteScalar();
                    int user_id = 0;
                    if (userIdResult != null) { user_id = Convert.ToInt32(userIdResult); }
                    this.Id = user_id;

                    string wageQuery = "SELECT hourly_wage FROM employee_details where person_id=@user_id";

                    MySqlCommand wageCmd = new MySqlCommand(wageQuery, conn);
                    wageCmd.Parameters.AddWithValue("@user_id", user_id);

                    Object wageResult = wageCmd.ExecuteScalar();
                    decimal wage = 0;
                    if (wageResult != null) { wage = Convert.ToDecimal(wageResult); }
                    this.hourlyWage = wage;

                    string userTypeQuery = "SELECT account_type FROM user where username=@username";
                    MySqlCommand userTypeCmd = new MySqlCommand(userTypeQuery, conn);
                    userTypeCmd.Parameters.AddWithValue("@username", username);
                    Object userTypeResult = userTypeCmd.ExecuteScalar();
                    int userType = 0;
                    if (userTypeResult != null) { userType = Convert.ToInt32(userTypeResult); }
                    WorkerRole = userType;
                }
            }
            catch (Exception)
            {
                IsLoggedIn = false;
            }
            finally
            {
                conn.Close();
            }
            return IsLoggedIn;
        }
        public override string ToString()
        {
            return "Worker";
        }
    }
}
