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
        int workerRole;
        private string username;
        public MainForm(string username, int workerRole)
        {
            InitializeComponent();
            List<DepartmentUserControl> controls = new List<DepartmentUserControl>();
            List<Department> departments = Department.GetAllDepartments();
            this.workerRole = workerRole;

            foreach(Department d in departments)
            {
                controls.Add(new DepartmentUserControl(d.Name, d.Description));
            }

            foreach (DepartmentUserControl department in controls)
            {
                flpDepartments.Controls.Add(department);
            }

            this.username = username;

            if(workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                btnFireEmployeeRequest.Visible = false;
                btnHireEmployeeRequest.Visible = false;
            }
            else if(workerRole == (int)ProfileRoles.MANAGER)
            {
                btnFireManager.Visible = false;
                btnCreateAdminManager.Visible = false;
                btnAddDepartment.Visible = false;
            }
            else if(workerRole == (int)ProfileRoles.EMPLOYEE)
            {
                tabControl1.TabPages.Remove(employeesTab);
                tabControl1.TabPages.Remove(departmentsTab);
                requestStockBttn.Visible = false;
                createStockBttn.Visible = false;
            }
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

        private void viewUpcomingShelfRestocksBttn_Click(object sender, EventArgs e)
        {
            (new ShelfRestockRequests()).Show();
        }

        private void requestStockBttn_Click(object sender, EventArgs e)
        {
            (new RequestStock()).Show();
        }

        private void viewStocksBttn_Click(object sender, EventArgs e)
        {
             (new StockView(workerRole)).Show();
        }
    }
}
