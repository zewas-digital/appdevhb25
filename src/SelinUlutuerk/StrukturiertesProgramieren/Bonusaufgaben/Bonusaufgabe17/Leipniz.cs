using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe17
{
    class Leipniz
    {
        public static void Start()
        {
            int anzahl = 500000;
            double pi = 0.0;

            for(int i = 0; i < anzahl; i++)
            {
                double term = 4.0 / (2 * i + 1);

                if( i % 2 == 0)
                {
                    pi += term;
                }
                else
                {
                    pi -= term;
                }
            }
            
            Console.Write($"{pi}");
        }
    }
}