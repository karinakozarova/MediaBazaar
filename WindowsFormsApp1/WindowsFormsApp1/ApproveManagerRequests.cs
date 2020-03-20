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
    public partial class ApproveManagerRequests : Form
    {
        List<RequestControl> controls;
        List<FiringRequests> firingRequests;
        public ApproveManagerRequests()
        {
            InitializeComponent();
            controls = new List<RequestControl>();
            UpdateGUI();
        }

        public void UpdateGUI()
        {
            firingRequests = null;
            controls.Clear();
            flpRequests.Controls.Clear();
            firingRequests = FiringRequests.GetAllFiringRequests();

            foreach (FiringRequests fr in firingRequests)
            {
                controls.Add(new RequestControl(fr.PersonId, fr.CreatedById, fr.DepartmentId, fr.Description, fr.FirstName, fr.LastName, fr.Username, this));
            }

            foreach (RequestControl request in controls)
            {
                flpRequests.Controls.Add(request);
            }
        }
    }
}
