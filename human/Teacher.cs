using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    internal class Teacher : Human
    {
        private string _workplace;
        private string _workexp;
        public Teacher(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public override void Work()
        {
            Random rnd = new Random();
            int teacher = rnd.Next(1, 6);
            if (teacher == 1)
            {
                _workplace = "НТТ";
            }
            else if (teacher == 2)
            {
                _workplace = "Горная шарага";
            }
            else if (teacher == 3)
            {
                _workplace = "НТТ";
            }
            else if (teacher == 4)
            {
                _workplace = "Автомобильная шарага";
            }
            else if (teacher == 5)
            {
                _workplace = "МГУ";
            }
            Random rnd1 = new Random();
            int teacherexp = rnd1.Next(1, 6);
            if (teacherexp == 1)
            {
                _workexp = "6";
            }
            else if (teacherexp == 2)
            {
                _workexp = "3";
            }
            else if (teacherexp == 3)
            {
                _workexp = "1";
            }
            else if (teacherexp == 4)
            {
                _workexp = "15";
            }
            else if (teacherexp == 5)
            {
                _workexp = "3";
            }
        }
        public override void ChangeWork()
        {
            Console.WriteLine("В какое учебное завидение вы хотите устроить учителя");
            Console.WriteLine("1. НТТ");
            Console.WriteLine("2. Горная шарага");
            Console.WriteLine("3. Автомобильная шарага");
            Console.WriteLine("4. МГУ");
            Console.WriteLine("5. Выйти.");
            string change1 = Console.ReadLine();
            bool changeplace3 = int.TryParse(change1, out var change);
            if (change == 1)
            {
                if (_workplace != "НТТ")
                {
                    _workplace = "НТТ";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 2)
            {
                if (_workplace != "Горная шарага")
                {
                    _workplace = "Горная шарага";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 3)
            {
                if (_workplace != "Автомобильная шарага")
                {
                    _workplace = "Автомобильная шарага";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 4)
            {
                if (_workplace != "МГУ")
                {
                    _workplace = "МГУ";
                }
                else
                {
                    Console.WriteLine("Этот человек уже работает здесь");
                }
            }
            else if (change == 5)
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
            Console.WriteLine($"Учитель - {_name} {_surname}. Место работы - {_workplace}. Стаж работы - {_workexp}");
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
            }
            else if (_workplace != "Безработный(ая)")
            {
                _workplace = "Безработный(ая)";
                return;
            }
        }
    }
}
