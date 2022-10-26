using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    internal class Student : Human
    {
        private string _placestudy;
        private string _course;
        private decimal _grant;
        public Student(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _grant = 712;
        }
        public Student()
        {
            _grant = 712;
        }
        public override void Work()
        {
            Random rnd = new Random();
            int student = rnd.Next(1, 6);
            if (student == 1)
            {
                _placestudy = "НТТ";
            }
            else if (student == 2)
            {
                _placestudy = "Горная шарага";
            }
            else if (student == 3)
            {
                _placestudy = "НТТ";
            }
            else if (student == 4)
            {
                _placestudy = "Автомобильная шарага";
            }
            else if (student == 5)
            {
                _placestudy = "МГУ";
            }
            Random rnd1 = new Random();
            int studentcourse = rnd1.Next(1, 6);
            if (studentcourse == 1)
            {
                _course = "1";
            }
            else if (studentcourse == 2)
            {
                _course = "2";
            }
            else if (studentcourse == 3)
            {
                _course = "3";
            }
            else if (studentcourse == 4)
            {
                _course = "3";
            }
            else if (studentcourse == 5)
            {
                _course = "4";
            }

        }
        public override void ChangeWork()
        {
            Console.WriteLine("Куда вы хотите перевестись");
            Console.WriteLine("1. НТТ");
            Console.WriteLine("2. Горная шарага");
            Console.WriteLine("3. Автомобильная шарага");
            Console.WriteLine("4. МГУ");
            Console.WriteLine("5. Выйти.");
            string change1 = Console.ReadLine();
            bool changeplace3 = int.TryParse(change1, out var change);
            if (change == 1)
            {
                if (_placestudy != "НТТ")
                {
                    _placestudy = "НТТ";
                }
                else
                {
                    Console.WriteLine("Этот человек уже учится здесь");
                }
            }
            else if (change == 2)
            {
                if (_placestudy != "Горная шарага")
                {
                    _placestudy = "Горная шарага";
                }
                else
                {
                    Console.WriteLine("Этот человек уже учится здесь");
                }
            }
            else if (change == 3)
            {
                if (_placestudy != "Автомобильная шарага")
                {
                    _placestudy = "Автомобильная шарага";
                }
                else
                {
                    Console.WriteLine("Этот человек уже учится здесь");
                }
            }
            else if (change == 4)
            {
                if (_placestudy != "МГУ")
                {
                    _placestudy = "МГУ";
                }
                else
                {
                    Console.WriteLine("Этот человек уже учится здесь");
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
            Console.WriteLine($"Студент - {_name} {_surname}. Место учёбы - {_placestudy}. Курс - {_course}");
            Console.WriteLine();
        }
        public string GetName()
        {
            return _name;
        }
        public void Grant()
        {
            Console.WriteLine($"Степендия на данный момент - {_grant} рублей");
            Console.WriteLine("На сколько вы хотите повысить степендию студентам?");
            Console.WriteLine();
            Console.WriteLine("Напишите отмена, если не хотите повышать степендию");
            Console.WriteLine();
            string grant1 = Console.ReadLine();
            bool a = int.TryParse(grant1, out var grant);
            _grant = _grant + grant;
            if (grant1 == "Отмена")
            {
                return;
            }
            else if (grant1 == "отмена")
            {
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Введите коректную команду");
                Console.WriteLine();
                Grant();
            }
            return;
        }
        public void Dismiss()
        {
            if (_placestudy == "Отчисленный(ая)")
            {
                Console.WriteLine();
                Console.WriteLine("Он(а) и так отчисленный(ая) куда ещё больше");
                Console.WriteLine();
            }
            else if (_placestudy != "Отчисленный(ая)")
            {
                _placestudy = "Отчисленный(ая)";
                Console.WriteLine();
                Console.WriteLine("Вы отчислили студента");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Введите корректную команду");
            }
        }
    }
}

