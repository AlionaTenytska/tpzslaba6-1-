using System;

namespace tpzslaba6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Введите количество человек: ");
                int n = int.Parse(Console.ReadLine());
                var persons = new Person[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("\nВыберите номер человека за критерием (1-абитуриент,2-студент,3-преподаватель): ");
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            {
                                Console.Write("--------АБИТУРИЕНТ--------\n");
                                Console.Write("Введите имя абируиента: ");
                                string name = Console.ReadLine();
                                Console.Write("Введите год рождение абируиента: ");
                                int year = int.Parse(Console.ReadLine());
                                Console.Write("Введите факультет абируиента: ");
                                string faculty = Console.ReadLine();
                                persons[i] = new Entant(name, year, faculty);
                                break;
                            }
                        case 2:
                            {
                                Console.Write("-------- СТУДЕНТ--------\n");
                                Console.Write("Введите имя студента: ");
                                string name = Console.ReadLine();
                                Console.Write("Введите год рождение студента: ");
                                int year = int.Parse(Console.ReadLine());
                                Console.Write("Введите факультет студента: ");
                                string faculty = Console.ReadLine();
                                Console.Write("Введите курс студента: ");
                                int kourse = int.Parse(Console.ReadLine());
                                persons[i] = new Student(name, year, faculty, kourse);
                                break;
                            }
                        case 3:
                            {
                                Console.Write("-------- ПРЕПОДАВАТЕЛЬ--------\n");
                                Console.Write("Введите имя преподователя: ");
                                string name = Console.ReadLine();
                                Console.Write("Введите год рождение преподователя: ");
                                int year = int.Parse(Console.ReadLine());
                                Console.Write("Введите факультет преподователя: ");
                                string faculty = Console.ReadLine();
                                Console.Write("Введите должность преподователя: ");
                                string post = Console.ReadLine();
                                Console.Write("Введите стаж преподователя: ");
                                int experience = int.Parse(Console.ReadLine());
                                persons[i] = new Teacher(name, year, faculty, post, experience);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("----------------------------------ERROR-----------------------------------");
                                break;
                            }
                    }
                }
                Console.Write("\n");
                for (int i = 0; i < n; i++)
                    persons[i].CoutInf();
                Console.ReadKey();
        }
    }
}
