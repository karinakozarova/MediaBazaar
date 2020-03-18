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
   
    public partial class AddOtherContacts : Form
    {
        public AddOtherContacts()
        {
            InitializeComponent();
        }
        Person person;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            DateTime dateOfBirth = dtpBirthdate.Value;        //adds other contacts to people
            string email = tbEmail.Text;
            long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
           person =  new Person(firstName, lastName, dateOfBirth, phoneN, email);
            this.Close();
        }

        public Person OtherContact() //how to store it in db
        {
            return person;
        }
    }
}
