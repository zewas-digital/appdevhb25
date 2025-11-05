using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe03
{
    class SummeUeberBereich
    {
        public static void Start()
        {
            int intervallstart = 8;
            int intervallende = 10;
            int summe = 0;

            Console.WriteLine($"intervallstart: {intervallstart}");
            Console.WriteLine($"intervallende: {intervallende}");

            for (int i = intervallstart; i <= intervallende; i++)
            {
               summe=summe + i;
            }

            Console.Write($"Summe über Intervall: {summe}");
        }
    }
}