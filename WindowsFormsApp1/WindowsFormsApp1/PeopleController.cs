using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class PeopleController
    {
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
        public void CreatePerson(string firstName, string lastName, DateTime dateOfBirth, long phoneNumber, string email)
        {
          Person person = new Person(firstName, lastName, dateOfBirth, phoneNumber, email);
        }
        public void CreateWorker(int accountType,string username, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, decimal hourlyWage)
        {
            Worker worker = new Worker(accountType,username,password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneNumber, email, hourlyWage);

        }
    }
}
