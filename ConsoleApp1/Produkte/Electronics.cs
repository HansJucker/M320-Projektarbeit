using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Produkte
{
    public class Electronics : Product
    {
        private string _manufaturer;

        public Electronics(string productName, Supplier supplier, string manufacturer) : base(productName, supplier)
        {
            _manufaturer = manufacturer;
        }

        public Electronics(string productName, Supplier supplier, double buyPrice, double sellPrice, string manufacturer) : base(productName, supplier, buyPrice, sellPrice)
        {
            _manufaturer = manufacturer;
        }
        public Electronics (string productName, Supplier supplier, int unitsInStock, double buyPrice, double sellPrice, string manufacturer) : base(productName, supplier, unitsInStock, buyPrice, sellPrice)
        {
            _manufaturer = manufacturer;
        }
        private void setManufacturer(string manufacturer)
        {
            _manufaturer = manufacturer;
        }
        private string getManufacturer()
        {
            return _manufaturer;
        }
    }
}
