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
        private decimal hourlyWage;
        private DateTime contractStartDate;
        private long phoneNumber;
        private string email = null;

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

        public RequestControl(int personId, int createdById, string username, string firstName, string lastName, decimal hourlyWage, int departmentId, DateTime contractStartDate, long phoneNumber, string email, ApproveManagerRequests form = null)
        {
            InitializeComponent();
            lblRequest.Text = $"Hiring!";
            lblRequestDescription.Text = $"Hiring of {firstName} {lastName}!";
            this.personId = personId;
            this.createdById = createdById;
            this.departmentId = departmentId;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.hourlyWage = hourlyWage;
            this.contractStartDate = contractStartDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.form = form;
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(this.email != null)
            {
                HiringRequest hrForm = new HiringRequest(this.username, this.firstName, this.lastName, this.hourlyWage, this.departmentId, this.contractStartDate, this.phoneNumber, this.email);
                hrForm.Show();
            }else
            {
                FiringRequest frForm = new FiringRequest(flag, this.departmentId, this.username, this.firstName, this.lastName, this.description);
                frForm.Show();
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if(this.email != null)
            {
                foreach (HiringRequests hr in HiringRequests.GetAllHiringRequests())
                {
                    if (hr.PersonId == personId)
                    {
                        hr.ApproveHiringRequest();
                    }
                }
                form.UpdateGUI();
            }else
            {
                foreach (FiringRequests fr in FiringRequests.GetAllFiringRequests())
                {
                    if (fr.PersonId == personId)
                    {
                        fr.ApproveFiringRequest();
                    }
                }
                form.UpdateGUI();
            }
            
        }

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            if(this.email != null)
            {
                foreach (HiringRequests hr in HiringRequests.GetAllHiringRequests())
                {
                    if (hr.PersonId == personId)
                    {
                        hr.DeclineHiringRequest();
                    }
                }
                form.UpdateGUI();
            }
            else
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
}
