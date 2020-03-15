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
        public EditDepartmentForm(string name, string description)
        {
            InitializeComponent();
            tbxName.Text = name;
            rtbDescription.Text = description;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
