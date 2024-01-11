using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Produkte
{
    public class Product
    {
        private  string _productName;
        private  Supplier _supplier;
        private int _unitsInStock;
        private double _buyPrice;
        private double _sellPrice;


        public Product (string productName, Supplier supplier)
        {
            _productName = productName;
            _supplier = supplier;
            _supplier.addProduct(this);
        }
        public Product (string productName, Supplier supplier, double buyPrice, double sellPrice)
        {
            _productName = productName;
            _supplier = supplier;
            _buyPrice = buyPrice;
            _sellPrice = sellPrice;
            _supplier.addProduct(this);
        }
        public Product(string productName, Supplier supplier, int unitsInStock, double buyPrice, double sellPrice)
        {
            _productName = productName;
            _supplier = supplier;
            _unitsInStock = unitsInStock;
            _buyPrice = buyPrice;
            _sellPrice = sellPrice;
            _supplier.addProduct(this);
        }
        
        public void setProductName(string productname)
        {
            _productName = productname;
        }
        public string getProductName()
        {
            return _productName;
        }
        public void setSupplier(Supplier supplier)
        {
            _supplier = supplier;
        }
        public Supplier getSupplier()
        {
            return _supplier;
        }
        public void setUnitsInStock(int unitsInStock)
        {
            _unitsInStock = unitsInStock;
        }
        public int getUnitsInStock()
        {
            return _unitsInStock;
        }
        public void setBuyPrice(double buyPrice)
        {
            if (buyPrice >0)
            {
                _buyPrice = buyPrice;
            }
            else
            {
                Console.WriteLine("Buy Price must be > 0");
            }
            
        }
        public double getBuyPrice()
        {
            return _buyPrice;
        }
        public void setSellPrice(double sellPrice)
        {
            if (sellPrice > 0)
            {
                _sellPrice = sellPrice;
            }
            else
            {
                Console.WriteLine($"Sell Price for {this._productName} must be > 0");
            }
        }
        public double getSellPrice()
        {
            return _sellPrice;
        }

        public void addUnitsToStock(int unitsToStock)
        {
            if (unitsToStock > 0)
            {
                _unitsInStock += unitsToStock;
            }
            else
            {
                Console.WriteLine("Must add at least 1 unit to stock");
            }
        }
        public void removeUnitsFromStock(int unitsFromStock)
        {
            if (unitsFromStock <= 0)
            {
                Console.WriteLine("Remove at least 1 unit from stock");
            }
            
            else if (unitsFromStock <= _unitsInStock)
            {
                _unitsInStock -= unitsFromStock;
            }
            else
            {
                Console.WriteLine($"Not enough units of {this._productName} in stock");
            }
            
            
        }
    }
}
