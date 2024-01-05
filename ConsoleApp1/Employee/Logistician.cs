using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Projektarbeit.Employee
{
    public class Logistician : Employee
    {
        //Membervariable
        private bool _CanDriveForklift;

        //Konstruktor
        public Logistician(string name, string address, string accountNumber, decimal salary, bool canDriveForklift) : base(name, address, accountNumber, salary)
        {
            _CanDriveForklift = canDriveForklift;
        }

        //Methoden
        public void setCanDriveForklift(bool canDriveForklift)
        {
            _CanDriveForklift = canDriveForklift;
        }

        public bool getCanDriveForklift()
        {
            return _CanDriveForklift;
        }
    }
}
