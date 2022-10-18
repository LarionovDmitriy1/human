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
            
        }
        public override void GetInfo()
        {           
            Console.WriteLine($"Студент - {_name} {_surname}. Место учёбы - {_placestudy}. Курс - {_course}");
            Console.WriteLine();
        }
    }
}

