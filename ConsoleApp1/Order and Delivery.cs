using M320_Projektarbeit.Employee;
using M320_Projektarbeit.Produkte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                product.removeUnitsFromStock(amount);
                driver.addDelivery(this);
                customer.addDelivery(this);                
                         
        }       

    }

    public class Order
    {
        public Order(Product product, Supplier supplier, int amount)
        {
            product.addUnitsToStock(amount);
            supplier.addOrder(this);
        }
    }

    
}
  
