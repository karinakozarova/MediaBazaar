using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class PeopleController
    {
        private List<Person> people = new List<Person>();
        public void ApproveFire()
        {

        }
        public void RemoveManager()
        {

        }
        public void GetAllFireRequests()
        {

        }

        public void GetAllHiringRequests()
        {

        }
        public void ApproveHire()
        {

        }
        public void AddManager()
        {

        }
        public void CreateAccount(string username, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email)
        {
            people.Add(new Person(username, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneNumber, email));
        }

    }
}
