using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manager : Worker
    {
        public override string ToString()
        {
            return "Manager";
        }

        public List<Tuple<Employee, string>> SendFiringRequest(Employee e, string reason = null)
        {
            throw new NotImplementedException();
        }

        public List<Tuple<Employee, Department>> SendHiringRequest(Employee e, Department d)
        {
            throw new NotImplementedException();
        }

        public bool CreateEmployee(string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, List<Person> contactPeople = null)
        {
            throw new NotImplementedException();
        }

        public bool MakeStockRequest(StockRequest s)
        {
            throw new NotImplementedException();
        }

        public Employee SearchForEmployee(String firstName, String LastName)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetDepartmentStocks(Department d)
        {
            throw new NotImplementedException();
        }

        public bool AddStock(Stock s)
        {
            throw new NotImplementedException();
        }
    }
}
