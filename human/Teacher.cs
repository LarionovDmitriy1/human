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

        }
        public override void GetInfo()
        {          
            Console.WriteLine($"Учитель - {_name} {_surname}. Место работы - {_workplace}. Стаж работы - {_workexp}");
            Console.WriteLine();
        }
    }
}
