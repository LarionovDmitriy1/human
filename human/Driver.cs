using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    internal class Driver : Human
    {
        public Driver(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        private string _workplace;
        private string _workexp;
        public override void Work()
        {
            Random rnd = new Random();
            int driver = rnd.Next(1, 6);
            if (driver == 1)
            {
                _workplace = "Uber";
            }
            else if (driver == 2)
            {
                _workplace = "Yandex";
            }
            else if (driver == 3)
            {
                _workplace = "Pilot";
            }
            else if (driver == 4)
            {
                _workplace = "Red";
            }
            else if (driver == 5)
            {
                _workplace = "Careem";
            }

            Random rnd1 = new Random();
            int driverexp = rnd1.Next(1, 6);
            if (driverexp == 1)
            {
                _workexp = "1";
            }
            else if (driverexp == 2)
            {
                _workexp = "2";
            }
            else if (driverexp == 3)
            {
                _workexp = "3";
            }
            else if (driverexp == 4)
            {
                _workexp = "4";
            }
            else if (driverexp == 5)
            {
                _workexp = "5";
            }
        }
        public override void ChangeWork()
        {
            Console.WriteLine();
            Console.WriteLine("");
        }
        public void GetInfo()
        {
            Console.WriteLine($"Таксист - {_name} {_surname}. Место работы - {_workplace}. Стаж работы - {_workexp}");
            Console.WriteLine();
        }
    }
}
