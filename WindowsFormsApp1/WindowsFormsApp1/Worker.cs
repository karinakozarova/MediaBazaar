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
        private decimal hourlyWage;

        public bool IsLoggedIn
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
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi425113;Database=dbi425113;Pwd=bropro12;");

                string sql = "SELECT count(id) FROM user;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                // Send the query to the database and do something awesome with it

                Object result = cmd.ExecuteScalar();
                int count = -1; if (result != null) { count = Convert.ToInt32(result); }

                conn.Close();
                IsLoggedIn = true;
            }   
            catch (Exception)
            {
                IsLoggedIn = false;
            }
            return IsLoggedIn;
        }

    }
}
