using System;
using System.Data;

namespace Appdevhb25.SelinUlutuerk.Aufgabe19
{
    class Summe
    {
        public static void Start(int intervallstart, int intervallende)
        {
            int summe = intervallstart;

            Console.WriteLine($"Summe von {intervallstart} bis {intervallende} addiert");

            for (int i = intervallstart + 1; i <= intervallende; i++)
            {
                int altesumme = summe;
                summe = summe + i;
                
                Console.WriteLine($"rechenweg {altesumme} + {i} = {summe}");
            }
        }
    }
}
