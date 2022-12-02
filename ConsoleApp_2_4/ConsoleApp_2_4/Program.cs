using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; ++i)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(" 2");
                }
                Console.WriteLine(" 3");
                for (int j = 10 - i; j <= 10; ++j)
                    Console.Write(" " + (j % 10));
            }
        }
    }
}
