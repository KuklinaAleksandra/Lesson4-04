using System;

namespace Lesson4_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число  ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначи " + Fib(n));
            Console.WriteLine();
        }
        static int Fib(int n)
        {
            return Fib(n, out _);
        }
        static int Fib(int n, out int f)
        {
            f = 0;
            if (n == 0)
            {
                return 0;
            }
            else
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    int f1;
                    f = Fib(n - 1, out f1);
                    return f + f1;
                }
            }
        }
    }
}
