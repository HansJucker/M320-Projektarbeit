using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Employee
{
    public class Manager : Employee
    {
        //Membervariable
        private decimal _bonus;

        //Konstruktor
        public Manager(string name, string address, string accountNumber, decimal salary, decimal bonus) : base(name, address, accountNumber, salary)
        {
            _bonus = bonus;
        }

        //Methoden
        public decimal getBonus()
        {
            return _bonus;
        }

        public void setBonus(decimal bonus)
        {
            _bonus = bonus;
        }

        public override decimal getSalary()
        {            
            return base.getSalary() + _bonus;
        }
    }
}
