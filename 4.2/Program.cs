using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, minuses, pluses, counter;

            pluses = 0;
            minuses = 0;
            counter = 0;

            do
            {
                Console.WriteLine("Введите число");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    minuses++;
                }
                else if (num > 0)
                {
                    pluses++;
                }
            } while (num != 0);

            if (minuses > pluses)
            {
                Console.WriteLine("Отрицательных больше");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            
            else if (minuses < pluses)
            {
                Console.WriteLine("Положительных больше");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }

            else if (minuses == pluses && minuses != 0)
            {
                Console.WriteLine("Поровну");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы не ввели последовательность");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
    }
}
