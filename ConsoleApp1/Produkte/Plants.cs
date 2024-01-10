using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Produkte
{
    public class Plants : Product, IExpirationDate
    {
        private DateTime _expirationDate;

        public Plants(string productName, Supplier supplier, DateTime expirationDate) : base(productName, supplier)
        {
            _expirationDate = expirationDate;
        }

        public Plants(string productName, Supplier supplier, double buyPrice, double sellPrice, DateTime expirationDate) : base(productName, supplier, buyPrice, sellPrice)
        {
            _expirationDate = expirationDate;
        }
        public Plants(string productName, Supplier supplier, int unitsInStock, double buyPrice, double sellPrice, DateTime expirationDate) : base(productName, supplier, unitsInStock, buyPrice, sellPrice)
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
