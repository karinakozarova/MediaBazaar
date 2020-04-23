using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace MediaBazar
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string EmployeeFirstName { get; private set; }
        public string EmployeeLastName { get; private set; }
        public string EmployeeUsername { get; private set; }
        public Employee(int employeeId, string firstName, string lastName, string username)
        {
            this.EmployeeId = employeeId;
            this.EmployeeFirstName = firstName;
            this.EmployeeLastName = lastName;
            this.EmployeeUsername = username;
        }

        public static List<Employee> GetAllEmployees()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = "SELECT p.id, p.first_name, p.last_name, u.username FROM person AS p INNER JOIN user AS u ON p.id = u.account_id INNER JOIN employee_details AS ep ON p.id = ep.person_id WHERE u.account_type = 2 AND ep.is_approved = 2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    employees.Add(new Employee(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString()));
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
            return employees;
        }
        public override string ToString()
        {
            return "Employee";
        }

        internal static List<Employee> GetAllEmployeesByDepartment(int departmentId)
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = "SELECT p.id, p.first_name, p.last_name, u.username FROM person AS p INNER JOIN user AS u ON p.id = u.account_id INNER JOIN employee_details AS ep ON p.id = ep.person_id WHERE u.account_type = 2 AND ep.is_approved = 2 AND ep.department_id=@department_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", departmentId);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    employees.Add(new Employee(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString()));
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
            return employees;
        }

        public static List<int> GetEmployeeWorkingDays(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            List<int> workingDays = new List<int>();

            DateTime startOfWeek = DateTime.Today.AddDays(
            (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
            (int)DateTime.Today.DayOfWeek);

            string result = string.Join("," + Environment.NewLine, Enumerable
              .Range(0, 7)
              .Select(i => startOfWeek
                 .AddDays(i)
                 .ToString("yyyy/MMMM/dd")));
            var arrayCurrentWeek = result.Split(',');
            try
            {
                string sql = "SELECT week_day_id, assigned_date FROM employee_working_days WHERE employee_id=@employee_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employee_id", id);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    DateTime date = (DateTime)row[1];
                    string returnedDate = date.ToString("yyyy/MMMM/dd");
                    foreach (string s in arrayCurrentWeek)
                    {
                        string trimmedDate = s;
                        if (s.Contains("\r\n"))
                        {
                            trimmedDate = s.Replace("\r\n", "");
                        }
                        if(returnedDate == trimmedDate)
                        {
                            workingDays.Add(Convert.ToInt32(row[0]));
                        }
                    }
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
            return workingDays;
        }
        public static List<string> GetEmployeeWorkingShifts(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            List<string> workingShifts = new List<string>();

            DateTime startOfWeek = DateTime.Today.AddDays(
            (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
            (int)DateTime.Today.DayOfWeek);

            string result = string.Join("," + Environment.NewLine, Enumerable
              .Range(0, 7)
              .Select(i => startOfWeek
                 .AddDays(i)
                 .ToString("yyyy/MMMM/dd")));
            var arrayCurrentWeek = result.Split(',');
            try
            {
                string sql = "SELECT shift, assigned_date FROM employee_working_days WHERE employee_id=@employee_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employee_id", id);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    DateTime date = (DateTime)row[1];
                    string returnedDate = date.ToString("yyyy/MMMM/dd");
                    foreach(string s in arrayCurrentWeek)
                    {
                        string trimmedDate = s;
                        if (s.Contains("\r\n"))
                        {
                            trimmedDate = s.Replace("\r\n", "");
                        }
                        if (returnedDate == trimmedDate)
                        {
                            workingShifts.Add(row[0].ToString());
                        }
                    }
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
            return workingShifts;
        }

        public static void ChangeEmployeeShift(int employeeId, List<int> workingDays, List<int> workingShifts)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sqlDeleteSchedule = "DELETE FROM employee_working_days WHERE employee_id=@employee_id";
                MySqlCommand cmdDeleteSchedule = new MySqlCommand(sqlDeleteSchedule, conn);
                cmdDeleteSchedule.Parameters.AddWithValue("@employee_id", employeeId);
                conn.Open();
                cmdDeleteSchedule.ExecuteNonQuery();


                foreach (int shift in workingShifts)
                {
                    foreach (int day in workingDays)
                    {
                        string shiftsQuery = "INSERT into employee_working_days (employee_id,week_day_id, shift) VALUE(@userId,@week_day_id, @shift)";
                        MySqlCommand shiftsQueryCmd = new MySqlCommand(shiftsQuery, conn);
                        shiftsQueryCmd.Parameters.AddWithValue("@shift", shift);
                        shiftsQueryCmd.Parameters.AddWithValue("@userId", employeeId);
                        shiftsQueryCmd.Parameters.AddWithValue("@week_day_id", day);
                        shiftsQueryCmd.ExecuteNonQuery();
                    }
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
    }
}
