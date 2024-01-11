using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit
{
    public class Customer : IAddress
    {
        //Membervariable
        private string _address;
        private string _customerName;
        public List<Delivery> _delivery;

        //Konstruktor
        public Customer(string customerName, string address)
        {
            _customerName = customerName;
            _address = address;
            _delivery = new List<Delivery>();
        }

        //Methoden

        public string getCustomerName() 
        { 
            return _customerName;
        }
        public void setCustomerName(string customerName)
        {
            _customerName = customerName;
        }
        public string getAddress()
        {
            return _address;
        }

        public void setAddress(string address)
        {
            _address = address;
        }

        public void addDelivery(Delivery delivery)
        {
            _delivery.Add(delivery);
        }        
        public void printDeliveryDetails()
        {
            foreach (Delivery delivery in _delivery){
                delivery.getDeliveryDetails();
            }
        }
        
    }
}

