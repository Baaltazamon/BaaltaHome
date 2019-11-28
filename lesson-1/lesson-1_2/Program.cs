using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_2
{
    class Program
    {
        /*Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) 
         по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
         Палатов Илья
             */
        public static string ReadWrite(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            double heigth = double.Parse(ReadWrite("Введите ваш рост (cм):"));
            double weight = double.Parse(ReadWrite("Введите ваш рост (кг):"));
            Console.WriteLine($"Ваш ИМТ = {weight / (Math.Pow((heigth / 100), 2))}");
            Console.ReadKey();
        }
    }
}
