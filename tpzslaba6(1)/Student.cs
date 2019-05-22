using System;
using System.Collections.Generic;
using System.Text;

namespace tpzslaba6_1_
{
    class Student:Person
    {
        int kourse;
        public int Kourse
        {
            get { return kourse; }
            set { if (kourse > 0 && kourse < 7) kourse = value; }
        }

        public Student(string name, int year, string faculty, int kourse)
            : base(name, year, faculty)
        {
            this.kourse = kourse;
        }

        public override void CoutInf()
        {
            Console.WriteLine("\t\tИнформаия о студенте");
            base.CoutInf();
            Console.WriteLine("Курс: {0}", kourse);
        }
    }
}
