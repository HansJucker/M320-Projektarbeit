using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Employee
{
    public class Driver : Employee
    {
        //Membervariable
        private List<Customer> _Customers;

        //Konstruktor
        public Driver(string name, string address, string accountNumber, decimal salary) : base(name, address, accountNumber, salary)
        {
            _Customers = new List<Customer>();
        }

        //Methoden
        public List<Customer> getCustomers()
        {
            return _Customers;
        }

        public void addCustomer(Customer customer)
        {
            _Customers.Add(customer);
        }

        public void removeCustomer(Customer customer)
        {
            _Customers.Remove(customer);
        }
    }
}
