using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class EmployeeComboBoxItem
    {
        private string firstName;
        private string lastName;
        private int id;
        private string username;

        public EmployeeComboBoxItem(Employee e)
        {
            this.id = e.EmployeeId;
            this.firstName = e.EmployeeFirstName;
            this.lastName = e.EmployeeLastName;
            this.username = e.EmployeeUsername;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string Username { get { return this.username; } }

        //Override ToString method
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
