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
        private List<Delivery> _Delivery;

        //Konstruktor
        public Customer(string customerName, string address)
        {
            _customerName = customerName;
            _address = address;
            _Delivery = new List<Delivery>();
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
            _Delivery.Add(delivery);
        }
    }
}

