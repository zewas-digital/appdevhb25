using System;
using System.Collections;
using System.Collections.Generic;
using Appdevhb25.JulianMatt.Aufgabe78;

namespace Appdevhb25.JulianMatt.Aufgabe78
{
    public class Output
    {
        public static void Start78()
        {
            Serien series = new Serien();

            series.FillRatingUp();

            System.Console.WriteLine($"Die Bewertungen aufgelisted bei Namen");
            List<KeyValuePair<string, double>> sortedByName = series.SortByName();
            Print(sortedByName);

            Dictionary<string, double> seriesRatings = QueueProcces();
            PrintQueue(seriesRatings, sortedByName);
        }

        public static void Print(List<KeyValuePair<string, double>> listToPrint)
        {
            foreach (var entry in listToPrint)
            {
                System.Console.WriteLine($"{entry.Key}");
            }
        }

        public static Dictionary<string, double> QueueProcces()
        {
            Queue favoriteSeries = new Queue();
            Dictionary<string, double> seriesRatings = new Dictionary<string, double>();

            System.Console.WriteLine();
            System.Console.WriteLine("Bitte geben Sie Ihre 3 Lieblingsserien ein:");
            for (int i = 0; i < 3; i++)
            {
                string seriesName = Console.ReadLine();
                favoriteSeries.Enqueue(seriesName);
            }

            System.Console.WriteLine("Geben sie die bewertungen für ihre 3 Lieblingsserien ein:");
            for (int i = 0; i < 3; i++)
            {
                System.Console.Write("Bewertung für " + favoriteSeries.Peek() + ": ");
                double rating = Convert.ToDouble(Console.ReadLine());
                seriesRatings.Add(favoriteSeries.Dequeue().ToString(), rating);
                System.Console.WriteLine();

            }

            return seriesRatings;
        }

        public static void PrintQueue(Dictionary<string, double> seriesRatings, List<KeyValuePair<string, double>> sortedByName)
        {
            System.Console.WriteLine("Ihre Lieblingsserien und deren Bewertungen:");
            foreach (var entry in sortedByName)
            {
                if (seriesRatings.ContainsKey(entry.Key))
                {
                    System.Console.WriteLine($"{entry.Key}: Ihre Bewertung: {seriesRatings[entry.Key]}/10 Interne Bewertung: {entry.Value}/10");
                }
            }
        }

    }
}