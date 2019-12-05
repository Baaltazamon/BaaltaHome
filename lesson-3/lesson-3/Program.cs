using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {


        /*
         * 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
              б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
            
            Палатов Илья
         */
        class Complex
        {
            public double a;
            public double b;
            public static void Print(Complex z)
            {
                char c = '+';
                if (z.b < 0)
                {
                    c = '-';
                    z.b = Math.Abs(z.b);
                }
                if (z.a != 0 && z.b != 0)
                    Console.WriteLine($"{z.a} {c} {z.b}i");
                else if (z.a == 0 && z.b != 0)
                    Console.WriteLine($"{z.b}i");
                else if (z.a != 0 && z.b == 0)
                    Console.WriteLine($"{z.a}");
                else
                    Console.WriteLine(0);
            }
            public Complex(double a, double b)
            {
                this.a = a;
                this.b = b;
            }
            public static Complex Amount(Complex one, Complex two)
            {
                return new Complex(one.a + two.a, one.b + two.b);
            }
            public static Complex Residual(Complex one, Complex two)
            {
                return new Complex(one.a - two.a, one.b - two.b);
            }
            public static Complex Multiply(Complex one, Complex two)
            {
                return new Complex(one.a * two.a - one.b - two.b, one.a * two.b + one.b * two.a);
            }
            public static Complex Division(Complex one, Complex two)
            {
                return new Complex(Math.Round((one.a * two.a + one.b * two.b)/(Math.Pow(two.a,2)+Math.Pow(two.b,2)),2),
                    Math.Round((one.b * two.a - one.a * two.b)/ (Math.Pow(two.a, 2) + Math.Pow(two.b, 2)),2));
            }
        }
        static void Main(string[] args)
        {
            Complex z1 = new Complex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Complex z2 = new Complex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.Clear();
            Complex.Print(z1);
            Complex.Print(z2);
            Console.WriteLine("Выберите операцию\n1 — Сумма\n2 — Разность\n3 — Умножение\n4 — Деление");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Complex z3 = Complex.Amount(z1, z2);
                        Complex.Print(z3);
                        break;
                    }
                case 2:
                    {
                        Complex z4 = Complex.Residual(z1, z2);
                        Complex.Print(z4);
                        break;
                    }
                case 3:
                    {
                        Complex z5 = Complex.Multiply(z1, z2);
                        Complex.Print(z5);
                        break;
                    }
                case 4:
                    {
                        Complex z6 = Complex.Division(z1, z2);
                        Complex.Print(z6);
                        break;
                    }
                default:
                    Console.WriteLine("Такого варианта нет");
                    break;
            }
            
            
            
            Console.ReadKey();
        }
    }
}
