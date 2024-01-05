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
        private decimal _Bonus;

        //Konstruktor
        public Manager(string name, string address, string accountNumber, decimal salary, decimal bonus) : base(name, address, accountNumber, salary)
        {
            _Bonus = bonus;
        }

        //Methoden
        public decimal getBonus()
        {
            return _Bonus;
        }

        public void setBonus(decimal bonus)
        {
            _Bonus = bonus;
        }

        public override decimal getSalary()
        {
            return base.GetSalary() + _Bonus;
        }
    }
}
