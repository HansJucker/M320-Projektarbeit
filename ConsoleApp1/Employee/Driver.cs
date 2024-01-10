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
        public List<Customer> _Customers;
        public List<Delivery> _Delivery;

        //Konstruktor
        public Driver(string name, string address, string accountNumber, decimal salary) : base(name, address, accountNumber, salary)
        {
            _Customers = new List<Customer>();
            _Delivery = new List<Delivery>();
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
        public void addDelivery(Delivery delivery)
        {
            _Delivery.Add(delivery);
        }
        public List<Delivery> getDeliveries()
        {
            return _Delivery;
        }

        public void printDeliveries()
        {
            foreach (Delivery delivery in _Delivery)
            {
                Console.WriteLine(delivery.ToString());
            }
        }
    }
}
