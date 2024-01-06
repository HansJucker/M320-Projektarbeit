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
        private string _Adress;

        //Konstruktor
        public Customer(string adress)
        {
            _Adress = adress;
        }

        //Methoden
        public string getAddress()
        {
            return _Adress;
        }

        public void setAddress(string address)
        {
            _Adress = address;
        }
    }
}
