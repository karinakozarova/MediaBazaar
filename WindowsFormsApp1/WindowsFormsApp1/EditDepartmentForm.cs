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
    public partial class EditDepartmentForm : Form
    {
        Department department;
        int depId;
        MainForm previousForm;

        public EditDepartmentForm(int id, string name, string description, int neededpeople, MainForm form)
        {
            InitializeComponent();
            this.depId = id;
            tbxName.Text = name;
            rtbDescription.Text = description;
            numPeople.Value = neededpeople;
            this.previousForm = form;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string description = rtbDescription.Text;
            int neededpeople = Convert.ToInt32(numPeople.Value);
            foreach (Department dep in Department.GetAllDepartments())
            {
                if (dep.DepartmentId == depId)
                {
                    dep.EditDepartment(name, description, neededpeople);
                }
            }
            this.Close();
            previousForm.UpdateGUI();
        }
    }
}
