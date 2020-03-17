using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Worker
    {
        public enum ProfileRoles
        {
            Administratior,
            Manager,
            Employee
        }

        private decimal hourlyWage = 0;
        private string username;

        public bool IsLoggedIn
        {
            get;
            private set;
        }

        public decimal GetWage()
        {
            return this.hourlyWage;
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
                    this.username = username;

                    string userIdQuery = "SELECT id FROM user where username=@username";
                    MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                    userIdCmd.Parameters.AddWithValue("@username", username);
                    Object userIdResult = userIdCmd.ExecuteScalar();
                    int user_id = 0;
                    if (userIdResult != null) { user_id = Convert.ToInt32(userIdResult); }

                    string wageQuery = "SELECT hourly_wage FROM employee_details where person_id=@user_id";

                    MySqlCommand wageCmd = new MySqlCommand(wageQuery, conn);
                    wageCmd.Parameters.AddWithValue("@user_id", user_id);

                    Object wageResult = wageCmd.ExecuteScalar();
                    decimal wage = 0;
                    if (wageResult != null) { wage = Convert.ToDecimal(wageResult); }
                    this.hourlyWage = wage;
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
