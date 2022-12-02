using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_2
{
    internal class Program
    {
        static void Main()
        {
            int n;
            while (true)
            {
                try
                {
                    Console.Write("Введите номер телевизионного канала (1-10): ");
                    n = int.Parse(Console.ReadLine());

                    if (n < 0) throw new Exception("Номер телевизионного канала не может быть отрицательным");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }

            Console.Write("\nНАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:\n");

            switch (n)
            {
                case 1: Console.WriteLine("\nВести\nЧто? Где? Когда?\nВремя покажет\n"); break;
                case 2: Console.WriteLine("\n60 минут\nКто против?\nВечер с Владимиром Соловьевым\n"); break;
                case 3: Console.WriteLine("\nЧрезвычайное происшествие\nСегодня\nМесто встречи\n"); break;
                case 4: Console.WriteLine("\nНовости культуры\nИскусственный отбор\nЗабытое ремесло\n"); break;
                case 5: Console.WriteLine("\nИзвестия\nСлед\nДетективы\n"); break;
                case 6: Console.WriteLine("\nСпокойной ночи, малыши!\nЧто в тарелке?\nИгра с умом\n"); break;
                case 7: Console.WriteLine("\nЗа Дело!\nКалендарь\nНовости\n"); break;
                case 8: Console.WriteLine("\nТерритория заблуждений\nЗасекреченные списки\nТайны Чапман\n"); break;
                case 9: Console.WriteLine("\nСпециальный репортаж\nОткрытый эфир\nМежду тем\n"); break;
                case 10: Console.WriteLine("\nВечер во Владимире\nВечерний зефир\nТелефорум\n"); break;
                default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
            }
        }
    }
}
