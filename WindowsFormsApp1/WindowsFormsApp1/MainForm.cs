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
        private string username;
        public MainForm(string username)
        {
            InitializeComponent();
            List<DepartmentUserControl> controls = new List<DepartmentUserControl>();
            List<Department> departments = Department.GetAllDepartments();

            foreach(Department d in departments)
            {
                controls.Add(new DepartmentUserControl(d.Name, d.Description));
            }

            foreach (DepartmentUserControl department in controls)
            {
                flpDepartments.Controls.Add(department);
            }

            this.username = username;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void createStockBttn_Click(object sender, EventArgs e)
        {
            (new AddStock()).Show();
        }
    }
}
