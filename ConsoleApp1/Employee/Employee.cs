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
        private string _Name;
        private string _Address;
        private string _AccountNumber;
        private decimal _Salary;

        //Konstruktor
        public Employee(string name, string address, string accountNumber, decimal salary)
        {
            _Name = name;
            _Address = address;
            _AccountNumber = accountNumber;
            _Salary = salary;
        }

        //Methoden
        public string getName()
        {
            return _Name;
        }

        public void setName(string name)
        {
            _Name = name;
        }

        public string getAddress()
        {
            return _Address;
        }

        public void setAddress(string address)
        {
            _Address = address;
        }

        public string getAccountNumber()
        {
            return _AccountNumber;
        }

        public void setAccountNumber(string accountNumber)
        {
            _AccountNumber = accountNumber;
        }

        public virtual decimal getSalary()
        {
            return _Salary;
        }

        public void setSalary(decimal salary)
        {
            _Salary = salary;
        }
    }
}
