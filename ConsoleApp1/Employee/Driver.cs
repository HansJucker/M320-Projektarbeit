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
        private List<Delivery> _delivery;

        // Konstruktor
        public Driver(string name, string address, string accountNumber, decimal salary) : base(name, address, accountNumber, salary)
        {
            _customers = new List<Customer>();
            _delivery = new List<Delivery>();
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
            _delivery.Add(delivery);
        }

        public List<Delivery> getDeliveries()
        {
            return _delivery;
        }

        public void printDeliveries()
        {
            foreach (Delivery delivery in _delivery)
            {
                Console.WriteLine(delivery.ToString());
            }
        }
    }
}
