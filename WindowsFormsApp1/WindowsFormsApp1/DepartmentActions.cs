using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DepartmentActions : Form
    {
        static string morning = "morning";
        static string afternoon = "afternoon";
        static string evening = "evening";

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
            int[] morningPeople = Department.GetWorkersCountFor(departmentId, morning);
            int[] afternoonPeople = Department.GetWorkersCountFor(departmentId, afternoon);
            int[] eveningPeople = Department.GetWorkersCountFor(departmentId, evening);
            int neededPeople = Department.GetNeededPeopleCount(departmentId);

            List<WordaysControl> controls = new List<WordaysControl>();
            controls.Clear();
            controls.Add(new WordaysControl(morningPeople, neededPeople, morning));
            controls.Add(new WordaysControl(afternoonPeople, neededPeople, afternoon));
            controls.Add(new WordaysControl(eveningPeople, neededPeople, evening));

            flpDays.Controls.Clear();
            foreach (WordaysControl day in controls)
            {
                flpDays.Controls.Add(day);
            }
            neededWorkersCount.Text = neededPeople.ToString();
        }
    }
}
