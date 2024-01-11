using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Employee
{
    public class Employee :IAddress
    {
        //Membervariablen
        private string _name;
        private string _address;
        private string _accountNumber;
        private decimal _salary;

        //Konstruktor
        public Employee(string name, string address, string accountNumber, decimal salary)
        {
            _name = name;
            _address = address;
            _accountNumber = accountNumber;
            _salary = salary;
        }

        //Methoden
        public string getName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }

        public string getAddress()
        {
            return _address;
        }

        public void setAddress(string address)
        {
            _address = address;
        }

        public string getAccountNumber()
        {
            return _accountNumber;
        }

        public void setAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public virtual decimal getSalary()
        {
            return _salary;
        }

        public void setSalary(decimal salary)
        {
            _salary = salary;
        }
    }
}
