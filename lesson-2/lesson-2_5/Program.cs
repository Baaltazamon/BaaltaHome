using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_5
{
    class Program
    {
        public static double BMI(double mas, double height)
        {
            return (mas / Math.Pow(height, 2));
        }
        public static string ReadN(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }

        public static void CheckBMI(double ind, double mas, double height)
        {
            if (ind <= 16)
            {
                Console.WriteLine($"У вас выраженный дефицит массы тела\nВам нужно набрать {IndexNoordena(mas, height)} кг.");
            }
            else if (ind > 16 && ind <= 18.5)
            {
                Console.WriteLine($"У вас дефицит массы тела\nВам нужно набрать {IndexNoordena(mas, height)} кг.");
            }
            else if (ind > 18.5 && ind < 25)
            {
                Console.WriteLine($"У вас нормальная масса тела\nТак держать!");
            }
            else if (ind > 25 && ind < 30)
            {
                Console.WriteLine($"У вас избыточная масса тела\nВам нужно похудеть на {IndexNoordena(mas, height)} кг.");
            }
            else if (ind > 30 && ind < 35)
            {
                Console.WriteLine($"У вас ожирение\nВам нужно похудеть на {IndexNoordena(mas, height)} кг.");
            }
            else if (ind > 35 && ind < 40)
            {
                Console.WriteLine($"У вас резкое ожирение\nВам нужно похудеть на {IndexNoordena(mas, height)} кг.");
            }
            else if (ind > 40)
            {
                Console.WriteLine($"У вас очень резкое ожирение\nВам нужно похудеть на {IndexNoordena(mas, height)} кг.");
            }
        }

        public static double IndexNoordena(double mas, double height)
        {
            double iNoor = height* 100 * 0.42;
            return Math.Abs(mas - iNoor);
        }
        static void Main(string[] args)
        {
            double mas = double.Parse(ReadN("Введите массу своего тела"));
            double height = double.Parse(ReadN("Введите свой рост"))/100;
            double bmi = BMI(mas, height);
            CheckBMI(bmi, mas, height);
            Console.ReadKey();
        }
    }
}
