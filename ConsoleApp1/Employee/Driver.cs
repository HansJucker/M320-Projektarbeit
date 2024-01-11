using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Employee
{
    public class Driver : Employee
    {
        // Membervariable
        private List<Customer> _customers;
        private List<Delivery> _deliveries;

        // Konstruktor
        public Driver(string name, string address, string accountNumber, decimal salary) : base(name, address, accountNumber, salary)
        {
            _customers = new List<Customer>();
            _deliveries = new List<Delivery>();
        }

        // Methoden
        public List<Customer> getCustomers()
        {
            return _customers;
        }

        public void addCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void removeCustomer(Customer customer)
        {
            _customers.Remove(customer);
        }
        public void addDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }       
            
    }
}
