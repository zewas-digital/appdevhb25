using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe18
{
    class Nilakantha
    {
        public static void Start()
        {
            int anzahl = 650;
            double pi = 3.0;

            for(int i = 1; i < anzahl; i++)
            {
                double term = 4.0 / ((2 * i)*(2 * i + 1)*(2 * i + 2));

                if( i % 2 == 0)
                {
                    pi -= term;
                }
                else
                {
                    pi += term;
                }
            }
            Console.WriteLine();
            Console.Write($"{pi}");
        }
    }
}