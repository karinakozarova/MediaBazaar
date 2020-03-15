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
        public DepartmentUserControl(string name, string description)
        {
            InitializeComponent();
            lblDepartmentName.Text = name;
            lblDepartmentDescription.Text = description;
        }

        private void BtnEditDepartment_Click(object sender, EventArgs e)
        {
            string name = lblDepartmentName.Text;
            string description = lblDepartmentDescription.Text;
            EditDepartmentForm editDepartment = new EditDepartmentForm(name, description);
            editDepartment.Show();
        }

        private void BtnRemoveDepartment_Click(object sender, EventArgs e)
        {

        }
    }
}
