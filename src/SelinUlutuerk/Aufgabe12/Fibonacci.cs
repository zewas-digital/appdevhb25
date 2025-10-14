using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe12
{
    class Fibonacci
    {
        public static void StartFibonacci(int anzahl)
        {
            Console.WriteLine($"Die ersten {anzahl} Folgegliederr lauten:");

            int a1 = 0;
            int a2 = 1;

            Console.Write($"{a1}, {a2}");

            for (int i = 2; i < anzahl; i++)
            {
                int a = a1 + a2;
                Console.Write(", " + a);
                a1 = a2;
                a2 = a;
            }
        }
    }
}