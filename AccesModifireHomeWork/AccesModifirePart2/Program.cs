using AccesModifirePart2.Class;
using System;

namespace AccesModifirePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter the surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter the age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter the point: ");
            int point = int.Parse(Console.ReadLine());

            Student stu1 =new Student(point,name,age);
            stu1.Surname = surname;
            stu1.Info();

        }


    }
}
