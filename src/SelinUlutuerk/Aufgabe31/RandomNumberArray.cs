using System;
using Appdevhb25.SelinUlutuerk.Aufgabe19;

namespace Appdevhb25.SelinUlutuerk.Aufgabe31
{
    class RandomNumberArray
    {
        public static void Start()
        {
            Console.Write("Anzahl der Elemente: ");
            int anzahl = Convert.ToInt16(Console.ReadLine());

            int[] zahlen = new int[anzahl];


            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine($"größter Wert: {zahlen.Max()}");
            Console.WriteLine($"kleinster Wert: {zahlen.Min()}");
            Console.WriteLine($"Durchschnitt aller Werte: {zahlen.Average()}");
            Console.WriteLine($"Summe aller Werte: {zahlen.Sum()}");
            Console.WriteLine();


            // Berrechnungen
            int summe = 0;
            int kleinste = zahlen[0];
            int groesste = zahlen[0];

            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] < kleinste)
                {
                    kleinste = zahlen[i];
                }

                if (zahlen[i] > groesste)
                {
                    groesste = zahlen[i];
                }

                summe += zahlen[i];
            }

            double durchschnitt = (double)summe / zahlen.Length;

            Console.WriteLine($"größter Wert: {groesste}");
            Console.WriteLine($"kleinster Wert: {kleinste}");
            Console.WriteLine($"Durchschnitt aller Werte: {durchschnitt}");
            Console.WriteLine($"Summe aller Werte: {summe}");
            Console.WriteLine();
        }
    }
}