using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQ_fac_fib.Classes;

namespace LINQ_fac_fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Enter number of elements in sequence you want to display  ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 47 || num < 0) throw new Exception("Число должно быть положительным и меньше 47");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
            foreach (int n in Fibonacci.Fib(num))
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Enter number of factorial you want to display  ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 47 || num < 0) throw new Exception("Число должно быть положительным и меньше 47");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
            Factorial fact = new Factorial(num);
            Console.WriteLine(fact.fact());
            Console.ReadKey();

            University KHAI = new University();
            KHAI.group.Add(new Students("Vania", 20,335));
            KHAI.group.Add(new Students("Kolia", 19,325));
            KHAI.group.Add(new Students("Petia", 21,334));
            KHAI.group.Add(new Students("Jenia", 23,335));
            KHAI.group.Add(new Students("Oleg", 18,325));
            KHAI.group.Add(new Students("Sveta", 22,334));

            var selectedGroups = from t in KHAI.@group
                                 orderby t.age  // упорядочиваем по возрастанию
                                 select t; // выбираем объект

            foreach (var student in selectedGroups)
            {
                Console.WriteLine(student.age);
                Console.WriteLine(student.name);
            }
            var selectedGroups2 = from t in KHAI.@group
                              group t by t.groupNum;

            foreach (IGrouping<int, Students> g in selectedGroups2)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.name);
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();

            Console.Write("Enter qty of numbers you want to display  ");
            num = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[num];
            for (int i = 0; i < num; i++)
            {
                numbers[i] = i;
            }

            var selectedNums = from t in numbers
                              where t%2==0
                             select t; // выбираем объект
            Console.WriteLine("Четные");
            foreach (int i in selectedNums)
                Console.WriteLine(i);
            var selectedNums2 = from t in numbers
                               where t % 2 == 1
                               select t; // выбираем объект
            Console.WriteLine("Нечетные");
            foreach (int i in selectedNums2)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}


