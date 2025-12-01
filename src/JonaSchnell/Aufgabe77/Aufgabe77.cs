using System;
using System.Linq;
using System.Collections.Generic;

namespace Appdevhb25.JonaSchnell.Aufgabe77
{
    public static class Serien
    {
        private static readonly Dictionary<string, double> nameAndRating = new()
        {
            ["Prison Break"] = 9,
            ["Breaking Bad"] = 7.5,
            ["The Walking Dead"] = 10,
            ["The Boys"] = 8,
            ["Vikings"] = 5,
        };

        public static void AlleSerienAusgeben()
        {
            Console.WriteLine();
            Console.WriteLine("Alle Serien:");
            Console.WriteLine();

            foreach (KeyValuePair<string, double> kv in nameAndRating)
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
        }


        public static void AlleSerienUeberAcht()
        {
            Console.WriteLine();
            Console.WriteLine("Gute Serien:");
            Console.WriteLine();

            foreach (KeyValuePair<string, double> kv in nameAndRating.Where(kv => kv.Value >= 8))
            //.Where durchsucht die Liste nach einer Bedingung Bsp. (x => x > 4) und gibt nur die Werte zurück die diese Bedingung erfüllen.
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
        }

        public static void BesteSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Beste Serie:");
            Console.WriteLine();

            var best = nameAndRating.OrderByDescending(kv => kv.Value).First();
            // OrderByDescending sortiert eine Liste absteigend (vom Höchsten zum Niedrigsten) nach einem mir belibigen Wert.
            //(kv => kv.Value) ist eine Lambda Funktion
            //.First nimmt das erste Element einer Liste.
            Console.WriteLine($"{best.Key}: {best.Value}");
        }

        public static void SerieSuchen()
        {
            Console.WriteLine();
            Console.WriteLine("Welche Serie würdest du gerne suchen?");

            string? input = Console.ReadLine();
            if (nameAndRating.TryGetValue(input ?? "", out double rating))
            //.TryGetValue prüft bei einem Dictionary, ob ein Schlüssel existiert, und gibt gleichzeitig den Wert zurück.
            //?? = wenn null dann "" einsetzen
            //im out wird der wert gespeichert wenn es einen gibt
            {
                Console.WriteLine($"{input} hat {rating} Punkte bekommen.");
            }
        }

        public static void AlleNamen()
        {
            Console.WriteLine();
            foreach (var name in nameAndRating.Keys)
            {
                Console.WriteLine(name);
            }
        }

        public static void TopThree()
        {
            Console.WriteLine();
            Console.WriteLine("Top 3 Serien:");
            Console.WriteLine();
            
            foreach (var kv in nameAndRating.OrderByDescending(kv => kv.Value).Take(3))
            // OrderByDescending sortiert eine Liste absteigend (vom Höchsten zum Niedrigsten) nach einem mir belibigen Wert.
            //.Take(3) nimmt die ersten 3 Elemente aus einer Liste. Es schneidet sie blödgesagt ab. Man kann es gut verwenden um die Top 3 auszugeben wie hier.
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
        }
    }
}