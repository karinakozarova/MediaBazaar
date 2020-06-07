using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MediaBazar
{
    public partial class ViewWorkersWorkingToday : Form
    {

        public ViewWorkersWorkingToday()
        {
            InitializeComponent();
            PopulateDepartments(Department.GetAllDepartments());
        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
            {
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
            }
        }

        private void PopulateEmployees()
        {
            DayOfWeek todayWeekday = DateTime.Today.DayOfWeek;
            int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
            foreach (Worker e in Worker.GettAllWorkers(departmentId, "morning"))
            {
                lbWorkers.Items.Add(e.Id + " - " + e.FirstName + " " + e.LastName + " - " + "SHIFT : MORNINIG");
            }
            foreach (Worker e in Worker.GettAllWorkers(departmentId, "afternoon"))
            {
                lbWorkers.Items.Add(e.Id + " - " + e.FirstName + " " + e.LastName + " - " + "SHIFT : AFTERNOON");
            }
            foreach (Worker e in Worker.GettAllWorkers(departmentId, "evening"))
            {
                lbWorkers.Items.Add(e.Id + " - " + e.FirstName + " " + e.LastName + " - " + "SHIFT : EVENING");
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbWorkers.Items.Clear();
            PopulateEmployees();
        }

    }
}
