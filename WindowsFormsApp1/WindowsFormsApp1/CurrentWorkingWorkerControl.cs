using System;
using System.Windows.Forms;
using System.Drawing;

namespace MediaBazar
{
    public partial class CurrentWorkingWorkerControl : UserControl
    {
        public CurrentWorkingWorkerControl(int workerId, string firstName, string lastName, int attendence)
        {
            InitializeComponent();
            lblFullName.Text = firstName + " " + lastName;

            if(attendence == 0)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Green;
            }

            
        }
    }
}
