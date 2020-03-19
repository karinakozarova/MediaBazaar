using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class DepartmentUserControl : UserControl
    {
        Department dep;
        int depId;
        int neededPeople;
        public DepartmentUserControl(int departmentid, string name, string department, int neededpeople)
        {
            InitializeComponent();
            lblDepartmentName.Text = name;
            lblDepartmentDescription.Text = department;
            neededPeople = neededpeople;
            depId = departmentid;
        }

        private void BtnEditDepartment_Click(object sender, EventArgs e)
        {
            string name = lblDepartmentName.Text;
            string description = lblDepartmentDescription.Text;
            EditDepartmentForm editDepartment = new EditDepartmentForm(depId, name, description, neededPeople);
            editDepartment.Show();
        }

        private void BtnRemoveDepartment_Click(object sender, EventArgs e)
        {
            foreach (Department dep in Department.GetAllDepartments())
            {
                if (dep.DepartmentId == depId)
                {
                    dep.RemoveDepartment();
                }
            }
        }
    }
}
