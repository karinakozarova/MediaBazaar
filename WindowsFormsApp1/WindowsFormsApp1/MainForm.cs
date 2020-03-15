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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DepartmentUserControl newDepartment = new DepartmentUserControl("Electric", "Every electronic on the world!");
            DepartmentUserControl newDepartment1 = new DepartmentUserControl("Kitchen", "Kitchen supplies");
            DepartmentUserControl newDepartment2 = new DepartmentUserControl("Bathroom", "Bathroom supplies");
            flpDepartments.Controls.Add(newDepartment);
            flpDepartments.Controls.Add(newDepartment1);
            flpDepartments.Controls.Add(newDepartment2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
