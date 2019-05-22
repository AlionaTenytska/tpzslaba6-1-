using System;
using System.Collections.Generic;
using System.Text;

namespace tpzslaba6_1_
{
    class Teacher:Person
    {
        string post;
        int experience;
        public int Experience
        {
            get { return experience; }
            set { if (experience > 0 && experience < 70) experience = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        public Teacher(string name, int year, string faculty, string post, int experience)
            : base(name, year, faculty)
        {
            this.post = post;
            this.experience = experience;
        }

        public override void CoutInf()
        {
            Console.WriteLine("\t\tИнформация о преподавателе");
            base.CoutInf();
            Console.WriteLine("Должность: {0}\nСтаж: {1}", post, experience);
        }
    }
}
