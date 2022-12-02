using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите координату x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Введите координату y: ");
                    y = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }

            if (x * x + y * y < 100 && y < Math.Abs(x))
                Console.WriteLine("\n\nТочка находится внутри окружности");
            else if (x * x + y * y > 100 || y > Math.Abs(x))
                Console.WriteLine("\n\nТочка находится вне окружности");
            else
                Console.WriteLine("\n\nТочка находится на границе окружности");
        }
    }
}
