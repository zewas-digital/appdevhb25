using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Summe
    {
        public static void Sum(int min, int max)
        {
            int summe = min;
            int summealt;

            Console.WriteLine($"Summe von {min} bis {max} addiert");

            for (int i = min + 1; i <= max; i++)
            {
                summealt = summe;
                summe = summe + i;

                Console.WriteLine($"rechenweg {summealt} + {i} = {summe}");
            }
        }

    }
}