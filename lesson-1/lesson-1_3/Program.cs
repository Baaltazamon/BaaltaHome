using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_3
{
    class Program
    {
        /*
        а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            Палатов Илья
        */
        public static string ReadWrite(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        public static double solut(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(ReadWrite("Введите х1"));
            double y1 = double.Parse(ReadWrite("Введите y1"));
            double x2 = double.Parse(ReadWrite("Введите х2"));
            double y2 = double.Parse(ReadWrite("Введите y2"));
            double r = solut(x1, y1, x2, y2);
            Console.WriteLine("{0:F2}",r);
            Console.ReadKey();
        }
    }
}
