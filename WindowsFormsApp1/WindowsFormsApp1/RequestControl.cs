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
    public partial class RequestControl : UserControl
    {
        private int personId;
        private int createdById;
        private int departmentId;
        private string username;
        private string firstName;
        private string lastName;
        private string description;
        ApproveManagerRequests form;
        public RequestControl(int personId, int createdById, int departmentId, string description, string firstName, string lastName, string username, ApproveManagerRequests form = null)
        {
            InitializeComponent();
            lblRequest.Text = $"{firstName} {lastName} firing!";
            lblRequestDescription.Text = description;
            this.personId = personId;
            this.createdById = createdById;
            this.departmentId = departmentId;
            this.username = username;
            this.description = description;
            this.firstName = firstName;
            this.lastName = lastName;
            this.form = form;
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            bool flag = true;
            FiringRequest frForm = new FiringRequest(flag, this.departmentId, this.username, this.firstName, this.lastName, this.description);
            frForm.Show();
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {

        }

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            foreach (FiringRequests fr in FiringRequests.GetAllFiringRequests())
            {
                if (fr.PersonId == personId)
                {
                    fr.DeclineFiringRequest();
                }
            }
            form.UpdateGUI();
        }
    }
}
