using M320_Projektarbeit.Produkte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit
{
    public class Supplier : IAddress
    {
        //Membervariable
        private List<Product> _products;
        private List<Order> _orders;
        private string _supplierName;
        private string _address;

        //Konstruktor
        public Supplier(string supplierName, string address)
        {
            _products = new List<Product>();
            _orders = new List<Order>();
            _supplierName = supplierName;
            _address = address;
        }

        //Methoden
        public void setSupplierName(string supplierName)
        {
            _supplierName = supplierName;
        }
        public string getSupplierName() 
        {
            return _supplierName;
        }
        public List<Product> getProducts()
        {
            return _products;
        }

        public void addProduct(Product product)
        {
            _products.Add(product);
        }

        public void removeProduct(Product product)
        {
            _products.Remove(product);
        }
        public void setAddress(string address)
        {
            _address = address;
        }
        public string getAddress()
        {
            return _address;
        }
        public void addOrder(Order order)
        {
            _orders.Add(order);
        }
    }
}
