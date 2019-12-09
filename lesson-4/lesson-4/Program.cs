using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Program
    {

        /*
         * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
         * Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
         * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

            Палатов Илья
         */
        static void Main(string[] args)
        {
            const int n = 20;
            int count = 0;
            int min = -20000;
            int max = 20000;
            int[] mas = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(min, max);
                Console.Write($"{mas[i]} ");
            }
            for (int i = 1; i < n; i++)
            {
                if (mas[i] % 3 == 0 && mas[i - 1] % 3 != 0 || mas[i] % 3 != 0 && mas[i - 1] % 3 == 0)
                    count++;
            }
            Console.WriteLine($"\nКоличество пар = {count}");
            Console.ReadKey();
        }
    }
}
