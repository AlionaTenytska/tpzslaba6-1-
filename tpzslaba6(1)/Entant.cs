using System;
using System.Collections.Generic;
using System.Text;

namespace tpzslaba6_1_
{
    class Entant:Person
    {
        public Entant(string name, int year, string faculty)
            : base(name, year, faculty)
        { }
        public override void CoutInf()
        {
            Console.WriteLine("\t\tИнформация о абитуриенте");
            base.CoutInf();
        }
    }
}
