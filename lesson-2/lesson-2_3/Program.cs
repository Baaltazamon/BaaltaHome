using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 1;
            while (b != 0)
            {
                Console.Clear();
                Console.WriteLine("Вводите числа для суммирования. 0 - для завершения ввода");
                b = double.Parse(Console.ReadLine());
                a += b;
            }
            Console.WriteLine($"Сумма чисел ровна {a}");
            Console.ReadKey();
        }
    }
}
