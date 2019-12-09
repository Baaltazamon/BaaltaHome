using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson_4_3
{
    class Program
    {
        /*
         * 
         * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами 
         * от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, 
         * возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, 
         * умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
           б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки

            Палатов Илья

         */
        static void Main(string[] args)
        {
            ArrayLibrary mas = new ArrayLibrary(5, 10, 4);
            mas.PrintArray(mas.mas, "Первый массив");
            Console.WriteLine("\nСумма элементов ровна " + mas.Sum);
            int[] inverseMas = mas.Inverse(mas.mas);
            mas.PrintArray(inverseMas, "Инверсия массива");
            int c = 6;
            mas.Multi(ref inverseMas, c);
            mas.PrintArray(inverseMas, $"Инверсия массива * {c}");
            mas.Length = 12;
            mas.mas = new int[] { 4, 2, 6, 4, 3, 2, 6, 5, 3, 4, 5, 6 };
            mas.PrintArray(mas.mas, "Новый массив");
            mas.MaxCount = mas.Max(mas.mas);
            Console.WriteLine($"Количество максимальных элементов в массива: {mas.MaxCount}");
            Console.ReadKey();
        }
    }
}
