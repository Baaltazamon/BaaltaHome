using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class Program
    {

        /*
         * Написать метод, возвращающий минимальное из трех чисел.
         * 
         * Палатов Илья
         */
        public static double MinMax(double a, double b, double c)
        {
            if (a < b && a < c)
                return a;
            else if (c < b && c < a)
                return c;
            else
                return b;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(MinMax(a, b, c));
            Console.ReadKey();
        }
    }
}
