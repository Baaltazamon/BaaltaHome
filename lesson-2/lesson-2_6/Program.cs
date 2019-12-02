using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_6
{
    class Program
    {

        /*
         * *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
         * Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
         * 
         * Палатов Илья
         */
        public static int GoodNumberCount(int min, int max)
        {
            int a = 0;
            for (int i = min; i < max; i++)
            {
                if (GoodNumber(i))
                {
                    a++;
                }
            }
            return a;
        }
        public static bool GoodNumber(int num)
        {
            int sum = 0;
            int c = num;
            for (int i = 0; i < LengthN(num);i++)
            {
                sum += c % 10;
                c /= 10;
            }
            return num % sum == 0;
        }
        public static int LengthN(int a)
        {
            int c = 0;
            if (a == 0) return 1;
            while (a > 0)
            {
                a /= 10;
                c++;
            }
            return c;
        }
        static void Main(string[] args)
        {
            DateTime c = DateTime.Now;
            Console.WriteLine(GoodNumberCount(1, 1000000000));
            Console.WriteLine((DateTime.Now - c).TotalSeconds);
            Console.ReadKey();
            
        }
    }
}
