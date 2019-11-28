using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        /*Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
	        в) используя вывод со знаком $.

            Палатов Илья
    */
        public static string ReadWrite(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string firstName = ReadWrite("Введите ваше имя:");
            string lastName = ReadWrite("Введите вашу фамилию:");
            byte age = byte.Parse(ReadWrite("Введите ваш возраст:"));
            ushort height = ushort.Parse(ReadWrite("Введите ваш рост:"));
            ushort weight = ushort.Parse(ReadWrite("Введите ваш вес:"));
            Console.Clear();
            Console.WriteLine("Используя метод склеивания");
            Console.WriteLine("'Имя:' + firstName + 'Фамилия: ' + lastName + 'Возраст: ' + age + 'Рост: ' + height + 'Вес: ' + weight");
            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("\n\n\nИспользуя форматированный вывод");
            Console.WriteLine("'Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}', firstName, lastName, age, height, weight");
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", firstName, lastName, age, height, weight);
            Console.WriteLine("\n\n\nИспользуя вывод со знаком $");
            Console.WriteLine("$'Имя: {firstName} Фамилия: {lastName} Возраст: {age} Рост: {height} Вес: {weight}'");
            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName} Возраст: {age} Рост: {height} Вес: {weight}");
            Console.ReadKey();
        }
    }
}
