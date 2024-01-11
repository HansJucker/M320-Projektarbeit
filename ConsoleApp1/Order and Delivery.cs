using M320_Projektarbeit.Employee;
using M320_Projektarbeit.Produkte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit
{    
    public class Delivery
    {

        
        private Product _product;
        private Driver _driver;
        private Customer _customer;
        private int _amount;

        public Delivery(Product product, Driver driver, Customer customer, int amount) 
        {            
            _product = product;
            _driver = driver;
            _customer = customer;
            _amount = amount;
            _customer.addDelivery(this);
            _driver.addDelivery(this);
            _product.removeUnitsFromStock(amount);
        }
        public void getDeliveryDetails()
        {
            Console.WriteLine( $"{this._amount} {this._product.getProductName()} were delivered to {this._customer.getCustomerName()} by driver {this._driver.getName()}");
        }

    }

    public class Order
    {
        private Product _product;
        private Supplier _supplier;
        private int _amount;
        public Order(Product product, Supplier supplier, int amount)
        {
            _product = product;
            _supplier = supplier;
            _amount = amount;
            _product.addUnitsToStock(amount);
            _supplier.addOrder(this);
        }
        public void getOrderDetails()
        {
            Console.WriteLine($"{this._amount} {this._product.getProductName()} were ordered from {this._supplier.getSupplierName()}");
        }
    }

    
}
  
