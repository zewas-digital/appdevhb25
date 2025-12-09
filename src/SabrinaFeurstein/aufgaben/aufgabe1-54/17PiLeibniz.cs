using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PiLeibniz
    {
        public static void Pi()
        {
            double pi = 0;
            double nenner = 1;

            for (int i = 0; i < int.MaxValue; i++)
            {
                pi = pi + 4 / nenner;
                nenner = nenner + 2;
                pi = pi - 4 / nenner;
                nenner = nenner + 2;
            }
            Console.WriteLine($"Berechnung von Pi mit der Leibniz Reihe: {pi}");
        }
    }
}