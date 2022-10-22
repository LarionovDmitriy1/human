﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    internal class CollectionPeople
    {
        private List<Human> humans = new List<Human>();
        public void CreateHuman()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int human1 = rnd.Next(1, 4);
                if (human1 == 1)
                {
                    Random rnd1 = new Random();
                    int humandriver = rnd1.Next(1, 6);
                    if (humandriver == 1)
                    {
                        Driver driver = new Driver("Анатолий", "Лифтенштейн");
                        driver.Work();
                        humans.Add(driver);

                    }
                    else if (humandriver == 2)
                    {
                        Driver driver = new Driver("Махмед", "Сифоров");
                        driver.Work();
                        humans.Add(driver);
                    }
                    else if (humandriver == 3)
                    {
                        Driver driver = new Driver("Генадий", "Таксист");
                        driver.Work();
                        humans.Add(driver);
                    }
                    else if (humandriver == 4)
                    {
                        Driver driver = new Driver("Григорий", "Уберов");
                        driver.Work();
                        humans.Add(driver);
                    }
                    else if (humandriver == 5)
                    {
                        Driver driver = new Driver("Шекспир", "Петров");
                        driver.Work();
                        humans.Add(driver);
                    }
                }
                else if (human1 == 2)
                {
                    Random rnd2 = new Random();
                    int humanteacher = rnd2.Next(1, 6);
                    if (humanteacher == 1)
                    {
                        Teacher teacher = new Teacher("Клавдия", "Исаева");
                        teacher.Work();
                        humans.Add(teacher);
                    }
                    else if (humanteacher == 2)
                    {
                        Teacher teacher = new Teacher("Виктор", "Лукашев");
                        teacher.Work();
                        humans.Add(teacher);
                    }
                    else if (humanteacher == 3)
                    {
                        Teacher teacher = new Teacher("Акакий", "Паравозов");
                        teacher.Work();
                        humans.Add(teacher);
                    }
                    else if (humanteacher == 4)
                    {
                        Teacher teacher = new Teacher("Tomas", "Shelby");
                        teacher.Work();
                        humans.Add(teacher);
                    }
                    else if (humanteacher == 5)
                    {
                        Teacher teacher = new Teacher("Билли", "Харингтон");
                        teacher.Work();
                        humans.Add(teacher);
                    }

                }
                else if (human1 == 3)
                {
                    Random rnd3 = new Random();
                    int humanstudent = rnd3.Next(1, 6);
                    if (humanstudent == 1)
                    {
                        Student student = new Student("Данил", "Казарян");
                        student.Work();
                        humans.Add(student);
                    }
                    else if (humanstudent == 2)
                    {
                        Student student = new Student("Дмитрий", "Ларионов");
                        student.Work();
                        humans.Add(student);
                    }
                    else if (humanstudent == 3)
                    {
                        Student student = new Student("Олег", "Сивягин");
                        student.Work();
                        humans.Add(student);
                    }
                    else if (humanstudent == 4)
                    {
                        Student student = new Student("Марат", "Залилов");
                        student.Work();
                        humans.Add(student);
                    }
                    else if (humanstudent == 5)
                    {
                        Student student = new Student("Никита", "Зюзин");
                        student.Work();
                        humans.Add(student);
                    }
                }
            }
        }
        public void GetInfo()
        {
            foreach (Human human in humans)
            {
                if (human is Student student)
                {
                    student.GetInfo();
                }
                else if (human is Teacher teacher)
                {
                    teacher.GetInfo();
                }
                else if (human is Driver driver)
                {
                    driver.GetInfo();
                }
            }
        }
        public void ChangeWork()
        {

            Console.WriteLine("1. Перевести студента");
            Console.WriteLine("2. Изменить работу учителю");
            Console.WriteLine("3. Изменить работу водителю");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            foreach (Human human in humans)
            {

                if (b == 1)
                {
                    List<Student> students = new List<Student>();
                    foreach (Human hum in humans)
                    {
                        if (hum is Student student)
                        {
                            students.Add(student);
                        }
                    }
                    Console.WriteLine("Выберите студента которого хотите перевести");
                    foreach (Student item in students)
                    {
                        item.GetInfo();
                    }
                    string select = Console.ReadLine();
                    foreach (Student item in students)
                    {
                        if (item.GetName() == select)
                        {
                            item.ChangeWork();
                        }
                    }
                }

                if (b == 2 && human is Teacher teacher)
                {
                    teacher.GetInfo();
                    teacher.ChangeWork();
                }
                else if (b == 3 && human is Driver drive)
                {
                    drive.GetInfo();
                    drive.ChangeWork();
                }

            }
        }
        private void ChangePeopleWork(Student student)
        {
            student.ChangeWork();
        }
        private void ChangePeopleWork(Driver driver)
        {
            driver.ChangeWork();
        }
        private void ChangePeopleWork(Teacher teacher)
        {
            teacher.ChangeWork();
        }
    }
}
