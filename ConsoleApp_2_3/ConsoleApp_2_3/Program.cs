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
            while (true)
            {
                try
                {
                    Console.Write("Введите количество строк, которых нужно вывести: ");
                    int q = int.Parse(Console.ReadLine());

                    if (q >= 1 && q <= 100) { }
                    else
                    {
                        Console.WriteLine("Число введено не корректно");
                        return;
                    }

                    Console.WriteLine("\nТрехзначные числа, которые начинаются и заканчиваются на одну и ту же цифру:\n");
                    int count = 0;
                    for (int n = 101; n <= 999; n++)
                    {
                        if (n % 10 == n / 100)
                        {
                            Console.WriteLine(n);
                            count++;
                        }
                        if (count == q)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("\nТрехзначные числа, которые начинаются и заканчиваются на одну и ту же цифру:\n");
                    count = 0;
                    int i = 101;
                    while (i <= 999)
                    {
                        if (i % 10 == i / 100)
                        {
                            Console.WriteLine(i);
                            count++;
                        }
                        i++;
                        if (count == q)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("\nТрехзначные числа, которые начинаются и заканчиваются на одну и ту же цифру:\n");
                    count = 0;
                    i = 101;
                    do
                    {
                        if (i % 10 == i / 100)
                        {
                            Console.WriteLine(i);
                            count++;
                        }
                        i++;
                        if (count == q)
                        {
                            break;
                        }
                    }
                    while (i <= 999);
                    Console.WriteLine();

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
        }
    }
}
