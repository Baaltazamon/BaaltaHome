using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_2
{
    class Program
    {
        /*
         * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. 
         * Сами числа и сумму вывести на экран, используя tryParse;
           б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
           При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

            Палатов Илья
         */
        public static double Amount(double sum)
        {
            double c;
            //bool d = double.TryParse(Console.ReadLine(), out c);
            //Console.Write(d ? "" : "\nВводите числа\n");
            c = CheckNumber();
            if (c == 0)
                return sum;
            else
            {
                sum += c;
                return Amount(sum);
            }
            
        }
        public static double CheckNumber()
        {
            double c = 0,d = 0;
            while (d == 0)
                try
                {
                    c = double.Parse(Console.ReadLine());
                    d = 1;
                }
                catch (FormatException)
                {
                    d = 0;
                    Console.WriteLine("Вводите числа");
                }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Сумма = { Amount(0)}");
            Console.ReadKey();
        }
    }
}
