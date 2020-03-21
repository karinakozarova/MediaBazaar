using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DepartmentActions : Form
    {
        static Color greenColor = Color.LightGreen;
        static Color redColor = Color.Crimson;

        public DepartmentActions()
        {
            InitializeComponent();
            PopulateDepartments(Department.GetAllDepartments());
        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                departmentsCmbbxAddingStock.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void departmentsCmbbxAddingStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxAddingStock.SelectedItem).Id;
            int neededPeople = Department.GetNeededPeopleCount(departmentId);
            MessageBox.Show(neededPeople.ToString());
        }
    }
}
