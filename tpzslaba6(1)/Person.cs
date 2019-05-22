using System;
using System.Collections.Generic;
using System.Text;

namespace tpzslaba6_1_
{
    abstract class Person
    {
        string name;
        int year;
        string faculty;

        public int Year
        {
            get { return year; }
            set { if (year > 1920 && year < 2019) year = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Person(string name, int year, string faculty)
        {
            this.name = name;
            this.year = year;
            this.faculty = faculty;
        }

        public virtual void CoutInf()
        {
            Console.WriteLine("Имя: {0}\nВозраст: {1} лет\nФакультет: {2}", name, 2019 - year, faculty);
        }
    }
}
