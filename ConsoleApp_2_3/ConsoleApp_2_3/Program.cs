using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод всех трехзначных числел, которые начинаются и заканчиваются на одну и ту же цифру\n");
            for (int n = 101; n <= 999; n ++)
            {
                if (n % 10 == n / 100)
                {
                    Console.WriteLine(n);
                }
            }

            Console.WriteLine("\nВывод всех трехзначных числел, которые начинаются и заканчиваются на одну и ту же цифру\n");
            int i = 101;
            while (i < 1000)
            {
                if (i % 10 == i / 100)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.WriteLine("\nВывод всех трехзначных числел, которые начинаются и заканчиваются на одну и ту же цифру\n");
            i = 101;
            do
            {
                if (i % 10 == i / 100)
                {
                    Console.WriteLine(i);
                }
                i++;
            } 
            while (i < 1000);
            Console.WriteLine();
        }
    }
}
