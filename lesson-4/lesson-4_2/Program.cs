using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_2
{
    class Program
    {

        /*
         * Реализуйте задачу 1 в виде статического класса StaticClass;
            а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            в)**Добавьте обработку ситуации отсутствия файла на диске.

            Палатов Илья
         */
        static class StaticClass
        {
            public static void Print(int[] mas)
            {
                int len = mas.Length;
                for (int i = 0; i < len; i++)
                {
                    Console.Write($"{mas[i]} ");
                }
            }

            public static int CountCouple(int[] mas)
            {
                int count = 0;
                int len = mas.Length;
                for (int i = 1; i < len; i++)
                {
                    if (mas[i] % 3 == 0 && mas[i - 1] % 3 != 0 || mas[i] % 3 != 0 && mas[i - 1] % 3 == 0)
                        count++;
                }
                return count;

            }
            public static int[] GetArray(string path)
            {
                int[] masInt = {0};
                try
                {
                    string[] mas = File.ReadAllLines(path);
                    int len = mas.Length;
                    masInt = new int[len];
                    for (int i = 0; i < len; i++)
                    {
                        masInt[i] = int.Parse(mas[i]);
                    }
                }
                catch (FileNotFoundException)
                {

                    Console.WriteLine("Проверьте наличие файла");
                }
                
                return masInt;
            }

        }

        public static void CreateArray(int n, int min, int max)
        {
            string[] mas = new string[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(min, max).ToString();
            }
            File.WriteAllLines("mas.txt", mas);
        }
        static void Main(string[] args)
        {
            const int n = 20;
            int min = -20000;
            int max = 20000;
            int[] mas = new int[n];
            Random rnd = new Random();
            /*for (int i = 0; i < n; i++) Генерит массив
            {
                mas[i] = rnd.Next(min, max);
            }*/
            CreateArray(n, min, max); //Создает файл со сгенерированным массивом
            mas = StaticClass.GetArray("mas.txt"); //из файла
            StaticClass.Print(mas);
            int count = StaticClass.CountCouple(mas);
            Console.WriteLine($"\n{count}");
            Console.ReadKey();
        }
    }
}
