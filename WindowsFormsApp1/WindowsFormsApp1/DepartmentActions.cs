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

        private string GetDataForLabel(int having, int total)
        {
            return $"{having} out of {total}";
        }
        private void departmentsCmbbxAddingStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxAddingStock.SelectedItem).Id;
            int[] morningPeople = Department.GetWorkersCountFor(departmentId, "morning");
            int[] afternoonPeople = Department.GetWorkersCountFor(departmentId, "afternoon");
            int[] eveningPeople = Department.GetWorkersCountFor(departmentId, "evening");

            List<WordaysControl> controls = new List<WordaysControl>();
            controls.Clear();
            controls.Add(new WordaysControl(morningPeople, "morning"));
            controls.Add(new WordaysControl(afternoonPeople, "afternoon"));
            controls.Add(new WordaysControl(eveningPeople, "evening"));

            flpDays.Controls.Clear();
            foreach (WordaysControl day in controls)
            {
                flpDays.Controls.Add(day);
            }
            neededWorkersCount.Text = Department.GetNeededPeopleCount(departmentId).ToString();

        }
    }
}
