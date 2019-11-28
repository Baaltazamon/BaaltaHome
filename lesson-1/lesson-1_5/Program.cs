using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_5
{
    class Program
    {
        /*
         а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         б) *Сделать задание, только вывод организовать в центре экрана.
         в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y). 

            Палатов Илья
         */


        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
        public static void Print(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
        public static string ReadWrite(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        public static void Pause()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string firstName = "Илья";
            string lastName = "Палатов";
            string city = "Москва";
            string words = $"{firstName} {lastName} из города {city}";
            Print(words);
            Pause();
            Console.Clear();
            Print(words, 48, 15);
            Pause();
        }
    }
}
