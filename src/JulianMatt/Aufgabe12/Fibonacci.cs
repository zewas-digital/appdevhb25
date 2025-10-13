using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe12
{
    public class Fibonacci
    {

        public static void Start12()
        {
            Console.WriteLine("Geben sie an wie viele Fibonacci zahlen angezeigt werden sollen");
            long menge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hier sind ihre Zahlen");
            long fib0 = 0;
            long fib1 = 1;
            long fib2 = fib0 + fib1;

            Console.WriteLine(fib0);
            Console.WriteLine(fib1);
            for (long i = 1; i <= menge - 2; i++)
            {
                fib2 = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib2;
                Console.WriteLine(fib2);
            }



        }
    }
}
