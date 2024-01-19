using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, amountA, amountB;

            amountA = 0;
            amountB = 0;

            Console.WriteLine("Введите А");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите C");
            C = Convert.ToInt32(Console.ReadLine());

            while (A >= C | B >= C)
            {   
                if (A >= C)
                {
                    amountA++;
                    A -= C;
                }

                if (B >= C)
                {
                    amountB++;
                    B -= C;
                }
                

            }
            Console.WriteLine("Поместится {0} квадратов", amountA * amountB);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
