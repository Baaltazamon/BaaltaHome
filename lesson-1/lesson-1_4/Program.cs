using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_4
{
    class Program
    {
        /*
             Написать программу обмена значениями двух переменных:
             а) с использованием третьей переменной;
	         б) *без использования третьей переменной.
            Палатов Илья
         */
        public static double ReadWrite(string str)
        {
            Console.WriteLine(str);
            return double.Parse(Console.ReadLine());
        }
        public static void Print(string str, double a, double b)
        {
            Console.WriteLine($"{str}а = {a}\nb = {b}");
        }
        public static void Replace3 (double a, double b)
        {
            Print("Было:\n", a, b);
            double c = a;
            a = b;
            b = c;
            Print("Стало:\n", a, b);

        }
        public static void Replace2(double a, double b)
        {
            Print("Было:\n", a, b);
            a += b;
            b = a - b;
            a = a - b;
            Print("Стало:\n", a, b);

        }
        static void Main(string[] args)
        {
            double a = ReadWrite("Введите первое число");
            double b = ReadWrite("Введите первое число");
            Replace3(a, b);
            Replace2(a, b);

            Console.ReadKey();
        }
    }
}
