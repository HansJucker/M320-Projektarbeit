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
        private bool _canDriveForklift;

        //Konstruktor
        public Logistician(string name, string address, string accountNumber, decimal salary, bool canDriveForklift) : base(name, address, accountNumber, salary)
        {
            _canDriveForklift = canDriveForklift;
        }

        //Methoden
        public void setCanDriveForklift(bool canDriveForklift)
        {
            _canDriveForklift = canDriveForklift;
        }

        public bool getCanDriveForklift()
        {
            return _canDriveForklift;
        }
    }
}
