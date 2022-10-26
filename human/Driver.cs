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
            Console.WriteLine("В какую компанию вы хотите устроить водителя?");
            Console.WriteLine("1. Uber");
            Console.WriteLine("2. Yandex");
            Console.WriteLine("3. Pilot");
            Console.WriteLine("4. Red");
            Console.WriteLine("5. Careem");
            Console.WriteLine("6. Выйти");
            string change1 = Console.ReadLine();
            bool changeplace3 = int.TryParse(change1, out var change);
            if (change == 1)
            {
                if (_workplace != "Uber")
                {
                    _workplace = "Yandex";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 2)
            {
                if (_workplace != "Yandex")
                {
                    _workplace = "Yandex";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 3)
            {
                if (_workplace != "Pilot")
                {
                    _workplace = "Pilot";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 4)
            {
                if (_workplace != "Red")
                {
                    _workplace = "Red";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 5)
            {
                if (_workplace != "Careem")
                {
                    _workplace = "Careem";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 6)
            {
                return;
            }
            else
            {
                Console.WriteLine("Выберите учреждение из списка");
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Таксист - {_name} {_surname}. Место работы - {_workplace}. Стаж работы - {_workexp}");
            Console.WriteLine();
        }
        public string GetName()
        {
            return _name;
        }
        public void Dismiss()
        {   
            if (_workplace == "Безработный(ая)")
            {
                Console.WriteLine();
                Console.WriteLine("Он(а) и так безработный(ая) куда ещё больше");
                Console.WriteLine();
                return;
            }
            else if (_workplace != "Безработный(ая)")
            {
                _workplace = "Безработный(ая)";
                
            }
        }
    }
}
