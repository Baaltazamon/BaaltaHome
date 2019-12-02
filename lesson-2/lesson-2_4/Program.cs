using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_4
{
    class Program
    {

        /*
         * Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
         * (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
         * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
         * 
         * Палатов Илья
         */
        public static bool Check(string log, string pass)
        {
            if (log == "root" && pass == "GeekBrains")
                return true;
            else
                return false;
        }
        public static string Readln(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int c = 3;
            bool d;
            do
            {
                Console.Clear();
                if (c != 3)
                    Console.WriteLine($"Неверная комбинация login/password\nОсталось попыток: {c}");

                d = Check(Readln("Введите login"), Readln("Введите password"));
                c--;
            } while (c > 0 && d == false);
            if (d == false)
                Console.WriteLine("Вы использовали все попытки для входа");
            else
                Console.WriteLine("Добро пожаловать!");
            Console.ReadKey();
        }
    }
}
