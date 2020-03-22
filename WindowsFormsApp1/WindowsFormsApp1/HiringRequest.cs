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
    public partial class HiringRequest : Form
    {
        public HiringRequest(string username, string firstName, string lastName, decimal hourlyWage, int departmentId, DateTime contractStartDate, long phoneNumber, string email)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Enabled = false;
            tbUsername.Text = username;
            tbFirstName.Text = firstName;
            tbLastName.Text = lastName;
            nHourlyWage.Value = hourlyWage;
            dtbContractStartDate.Value = contractStartDate;
            tbPhoneNumber.Text = phoneNumber.ToString();
            tbEmail.Text = email;
            List<Department> departments = new List<Department>();
            departments = Department.GetAllDepartments();
            foreach (Department d in departments)
            {
                if (d.DepartmentId == departmentId)
                {
                    cmbDepartment.Text = d.Name;
                }
            };
        }
    }
}
