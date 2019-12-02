using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_2
{
    class Program
    {
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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(LengthN(a));
            Console.ReadKey();
        }
    }
}
