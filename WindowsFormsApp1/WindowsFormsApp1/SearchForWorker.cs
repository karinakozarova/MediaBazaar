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
    public partial class SearchForEmployee : Form
    {
        public SearchForEmployee()
        {
            InitializeComponent();
            PopulateDepartments(Department.GetAllDepartments());
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }
        private void Populateemployees(List<Worker> employees)
        {
            foreach (Worker w in employees)
            {
                if (cbDepartment.SelectedIndex == -1)
                {
                    if (tbFname.Text == "" && tbLname.Text == "")
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvWokerView.Items.Add(item);

                    }
                    
                    else
                    {
                        if (tbFname.Text == w.FirstName && tbLname.Text == w.LastName)
                        {
                            ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                            lvWokerView.Items.Add(item);
                        }
                    }
                }
                else
                {
                    int departmentId = ((DepartmentComboBoxItem)cbDepartment.SelectedItem).Id;
                    if (w.DepartmentId == departmentId)
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvWokerView.Items.Add(item);
                    }
                }
            }
        }

        private void PopulateManagers(List<Worker> managers)
        {

            foreach (Worker w in managers)
            {

                if (cbDepartment.SelectedIndex == -1)
                {
                    if (tbFname.Text == "" && tbLname.Text == "")
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvWokerView.Items.Add(item);
                 
                    }
                    else
                    {
                        if(tbFname.Text == w.FirstName && tbLname.Text == w.LastName)
                        {
                            ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                            lvWokerView.Items.Add(item);
                        }
                    }
                }
                else
                {
                    int departmentId = ((DepartmentComboBoxItem)cbDepartment.SelectedItem).Id;
                    if (w.DepartmentId == departmentId)
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvWokerView.Items.Add(item);
                    }
                }
            }
        }

        private void bttnSearchworker_Click(object sender, EventArgs e)
        {
            lvWokerView.Items.Clear();
            tbLname.Clear();
            tbFname.Clear();
            if (rbEmployee.Checked)
            {
                Populateemployees(Worker.GetAllEmployees());
            }
            else if (rbManager.Checked)
            {
                PopulateManagers(Worker.GetAllManagers());
            }
            else if (rbAll.Checked)
            {
                PopulateManagers(Worker.GetAllManagers());
                Populateemployees(Worker.GetAllEmployees());
            }
        }
    }
}
