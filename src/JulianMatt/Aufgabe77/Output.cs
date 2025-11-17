using System;
using System.Collections.Generic;
using Appdevhb25.JulianMatt.Aufgabe77;

namespace Appdevhb25.JulianMatt.Aufgabe77
{
    public class Output
    {
        public static void Start77()
        {
            Serien series = new Serien();

            series.FillRatingUp();

            System.Console.WriteLine($"Die Bewertungen aufgelisted bei Namen");
            List<KeyValuePair<string, double>> sortedByName = series.SortByName();
            Print(sortedByName);

            System.Console.WriteLine();
            System.Console.WriteLine($"Serien die über 8.0 bewertet wurden");
            List<KeyValuePair<string, double>> vilteredRating = series.IsRatingAboveValue(8);
            Print(vilteredRating);

            System.Console.WriteLine();
            System.Console.WriteLine($"Die Serie mit der besten Bewertung ist: ");
            KeyValuePair<string, double> tmphighestRating = series.SearchSeriesForHighestRating();
            List<KeyValuePair<string, double>> highestRating = new List<KeyValuePair<string, double>> { tmphighestRating };
            Print(highestRating);

            SearchForRating(series);
            
        }

        public static void Print(List<KeyValuePair<string, double>> listToPrint)
        {
            foreach (var entry in listToPrint)
            {
                System.Console.WriteLine($"{entry.Key} Bewertung: {entry.Value}");
            }
        }

        public static void SearchForRating(Serien series)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Nach welcher Serie wollen sie suchen:");
            string name = Console.ReadLine();
            List<KeyValuePair<string, double>> ratingsOfName = series.SearchRatings(name);
            if(ratingsOfName.Count == 0)
            {
                System.Console.WriteLine("Keine Serie mit dem Namen gefunden");
            }
            else
            {
                System.Console.WriteLine();
                Print(ratingsOfName);
            }
            
        }
    }
}