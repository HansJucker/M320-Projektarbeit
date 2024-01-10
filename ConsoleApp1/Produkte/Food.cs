using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Produkte
{
    public class Food : Product, IExpirationDate
    {
        private DateTime _expirationDate;
        
        public Food (string productName, Supplier supplier, DateTime expirationDate) : base(productName, supplier)
        {
            _expirationDate = expirationDate;
        }

        public Food(string productName, Supplier supplier, double buyPrice, double sellPrice, DateTime expirationDate) :base(productName, supplier, buyPrice, sellPrice)
        {
            _expirationDate = expirationDate;
        }

        public Food(string productName, Supplier supplier, int amountInStock, double buyPrice, double sellPrice,  DateTime expirationDate) 
            : base (productName, supplier, amountInStock, buyPrice, sellPrice)
        {
            _expirationDate = expirationDate;
        }

        public void setExpirationDate(DateTime expirationDate)
        {
            _expirationDate = expirationDate;
        }
        public DateTime getExpirationDate()
        {
            return _expirationDate;
        }
    }
}
