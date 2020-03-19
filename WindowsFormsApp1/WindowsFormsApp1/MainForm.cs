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
        List<DepartmentUserControl> controls;
        List<Department> departments;
        private string username;
        public MainForm(string username, int workerRole)
        {
            InitializeComponent();
            controls = new List<DepartmentUserControl>();
            UpdateGUI();
         
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
            }
            else if(workerRole == (int)ProfileRoles.EMPLOYEE)
            {
                employeesTab.Hide();
                tabControl1.TabPages.Remove(employeesTab);
            }
        }

        public void UpdateGUI()
        {
            departments = null;
            controls.Clear();
            flpDepartments.Controls.Clear();
            departments = Department.GetAllDepartments();

            foreach (Department d in departments)
            {
                controls.Add(new DepartmentUserControl(d.DepartmentId, d.Name, d.Description, d.NeededPeople, this));
            }

            foreach (DepartmentUserControl department in controls)
            {
                flpDepartments.Controls.Add(department);
            }
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
             (new StockView()).Show();
        }

        private void addNewDepartmentBttn_Click(object sender, EventArgs e)
        {
            (new AddDepartment(this)).Show();
            UpdateGUI();
        }
    }
}