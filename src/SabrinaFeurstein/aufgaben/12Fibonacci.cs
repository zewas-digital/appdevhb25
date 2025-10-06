
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class FibonacciFolge
    {
        public static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            if (n >= 1)
            {
                Console.Write($"{a}, ");
            }

            if (n >= 2)
            {
                Console.Write($"{b}");
            }

            for (int i = 2; i < n; i++)
            {
                int neu = a + b;
                Console.Write($", {neu}");
                a = b;
                b = neu;
            }
        }
    }
}