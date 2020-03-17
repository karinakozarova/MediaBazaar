using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Department
    {
        private const string tableName = "departments";
        public int DepartmentId
        {
            get;
            private set;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int NeededPeople { get; set; }

        public Department(string name, string description, int neededPeople)
        {
            this.Name = name;
            this.Description = description;
            this.NeededPeople = neededPeople;
        }
        public Department(string name, string description, int neededPeople, int id)
        {
            this.Name = name;
            this.Description = description;
            this.NeededPeople = neededPeople;
            this.DepartmentId = id;
        }

        public Department(string name, int neededPeople)
        {
            this.Name = name;
            this.NeededPeople = neededPeople;
            AddDepartment();
        }

        public List<Employee> GetDepartmentEmployees()
        {
            throw new NotImplementedException();
        }

        public static List<Employee> GetDepartmentEmployees(Department d)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetDepartmentManagers()
        {
            throw new NotImplementedException();
        }

        public static List<Manager> GetDepartmentManagers(Department d)
        {
            throw new NotImplementedException();
        }

        private Department AddDepartment()
        {
            // add this object to the database
            throw new NotImplementedException();
        }

        public static Department AddDepartment(Department d)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDepartment()
        {
            throw new NotImplementedException();
        }

        public static bool RemoveDepartment(Department d)
        {
            throw new NotImplementedException();
        }

        public static List<Department> GetAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT name, description, needed_people, id FROM " + tableName; 
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

        public override string ToString()
        {
            return this.Name;
        }
    }
}