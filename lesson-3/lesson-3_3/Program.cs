using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_3
{
    class Program
    {
        class Rational
        {
            public Rational(double a, double b)
            {
                this.numerator = a;
                this.denominator = b;
            }
            double denominator;
            double numerator;
            public static void Print(Rational r)
            {
                if (r.numerator != 0)
                {
                    if (r.numerator > r.denominator)
                    {
                        double d = Math.Truncate(r.numerator / r.denominator);
                        if (r.numerator - d * r.denominator != 0)
                            Console.WriteLine($"{d} + ({r.numerator - d * r.denominator}/{r.denominator})");
                        else
                            Console.WriteLine(d);
                    }
                    else
                        Console.WriteLine($"{r.numerator}/{r.denominator}");
                }
                else
                    Console.WriteLine(0);

            }
            public static Rational Amount(Rational one, Rational two)
            {
                double c;
                if (two.denominator > one.denominator)
                {
                    c = two.denominator / one.denominator;
                    one.denominator = Math.Round(one.denominator * c,2);
                    one.numerator = Math.Round(one.numerator * c,2);
                }
                else
                {
                    c = one.denominator / two.denominator;
                    two.denominator = Math.Round(two.denominator * c, 2);
                    two.numerator = Math.Round(two.numerator * c, 2);
                }
                return new Rational(one.numerator + two.numerator, one.denominator);

            }
            public static Rational Residual(Rational one, Rational two)
            {
                double c;
                if (two.denominator > one.denominator)
                {
                    c = two.denominator / one.denominator;
                    one.denominator = Math.Round(one.denominator * c, 2);
                    one.numerator = Math.Round(one.numerator * c, 2);
                }
                else
                {
                    c = one.denominator / two.denominator;
                    two.denominator = Math.Round(two.denominator * c, 2);
                    two.numerator = Math.Round(two.numerator * c, 2);
                }
                return new Rational(one.numerator - two.numerator, one.denominator);
            }
            public static Rational Multiply(Rational one, Rational two)
            {
                return new Rational(one.numerator * two.numerator, one.denominator * two.denominator);
            }
            public static Rational Division(Rational one, Rational two)
            {
                return new Rational(one.numerator * two.denominator, one.denominator * two.numerator);
            }
        }
        public static double CheckZero()
        {
            double c = GetNum();
            while (c == 0)
            {
                c = GetNum();
            }
            return c;
        }
        public static double GetNum()
        {
            Console.WriteLine("Введите Число");
            return CheckNumber();
        }
        public static double CheckNumber()
        {
            double c = 0, d = 0;
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
            Rational r1 = new Rational(GetNum(), CheckZero());
            Rational r2 = new Rational(GetNum(), CheckZero());
            Console.Clear();
            Rational.Print(r1);
            Rational.Print(r2);
            Console.WriteLine("Выберите операцию\n1 — Сумма\n2 — Разность\n3 — Умножение\n4 — Деление");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Rational r3 = Rational.Amount(r1, r2);
                        Rational.Print(r3);
                        break;
                    }
                case 2:
                    {
                        Rational r4 = Rational.Residual(r1, r2);
                        Rational.Print(r4);
                        break;
                    }
                case 3:
                    {
                        Rational r5 = Rational.Multiply(r1, r2);
                        Rational.Print(r5);
                        break;
                    }
                case 4:
                    {
                        Rational r6 = Rational.Division(r1, r2);
                        Rational.Print(r6);
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
