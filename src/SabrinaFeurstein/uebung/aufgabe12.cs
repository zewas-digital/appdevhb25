using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe12
    {
        public static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            Console.Write("0, ");
            Console.Write('1');
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

