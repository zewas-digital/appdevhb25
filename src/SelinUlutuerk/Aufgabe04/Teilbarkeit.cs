using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe04
{
    class Teilbarkeit
    {
        public static void Start()
        {
            int teiler = 3;
            int intervallStart = 8;
            int intervallEnde = 14;

            Console.WriteLine($"Teiler: {teiler}");
            Console.WriteLine($"Intervallstart: {intervallStart}");
            Console.WriteLine($"Intervallende: {intervallEnde}");

            for (int i = intervallStart; i <= intervallEnde; i++)
            {
                //Bedingung muss erfüllt, TRUE sein
                if (i % teiler == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}