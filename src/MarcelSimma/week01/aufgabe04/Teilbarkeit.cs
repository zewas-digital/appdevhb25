using System;

namespace Appdevhb25.MarcelSimma.Aufgabe04
{
    public class Teilbarkeit
    {

        public static void Start()
        {

            int intervallstart = 8, intervallende = 14, teiler = 3;

            for (int i = intervallstart; i <= intervallende; i++)
            {
                // if (Bedingung)
                // Bedingung muss erfüllt, also TRUE sein
                if (i % teiler == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}