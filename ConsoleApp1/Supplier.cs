using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit
{
    public class Supplier
    {
        //Membervariable
        private List<Product> _Products;

        //Konstruktor
        public Supplier()
        {
            _Products = new List<Product>();
        }

        //Methoden
        public List<Product> getProducts()
        {
            return _Products;
        }

        public void addProduct(Product product)
        {
            _Products.Add(product);
        }

        public void removeProduct(Product product)
        {
            _Products.Remove(product);
        }
    }
}
