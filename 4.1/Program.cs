using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum;
            Console.WriteLine("Введите целое положительное число");
            num = Convert.ToInt32(Console.ReadLine());
            sum = 0;

            for (int i = 1; i <= (2 * num) - 1; i += 2)
            {
                sum += i;
                Console.WriteLine(sum);     
            }
            Console.ReadKey();

        }
    }
}
