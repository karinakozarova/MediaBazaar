using MySql.Data.MySqlClient;
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
        Person p;
        CreateAccount ca;
        PeopleController pc;
        string firstName;
        string lastName;
        DateTime dateOfBirth;        //adds other contacts to people
        string email;
        long phoneN;
        public string FirstName { get { return firstName; }private set { firstName = tbFirstName.Text; } }
        public string LastName { get { return lastName; } private set { lastName = tbLastName.Text; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } private set { dateOfBirth = dtpBirthdate.Value; } }
        
        public long PhoneNumber
        {
            get { return phoneN; }
            private set { phoneN = Convert.ToInt64(tbPhoneNumber.Text); }
        }
        public string Email
        {
            get { return email; }
            private set { email = tbEmail.Text; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
             FirstName = tbFirstName.Text;
             LastName = tbLastName.Text;
             DateOfBirth = dtpBirthdate.Value;        //adds other contacts to people
             Email = tbEmail.Text;
            PhoneNumber = Convert.ToInt64(tbPhoneNumber.Text);
            p = new Person(FirstName, LastName, DateOfBirth, PhoneNumber, Email);
            string display = FirstName + " " + LastName + " date of birth: " + DateOfBirth + " tel: " + PhoneNumber + " email: " + Email;
            ca = new CreateAccount(FirstName, LastName, DateOfBirth, Email, PhoneNumber, this);
        }

    }
}
