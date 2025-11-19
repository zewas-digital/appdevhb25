using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe77
{
    public class Serien
    {
        public static Dictionary<string, double> Series = new Dictionary<string, double>();
        public static void Start()
        {
            Series.Add("Lauras Stern", 6);
            Series.Add("Shawn das Schaf", 4);
            Series.Add("Die Sendung mit der Maus", 9);
            Series.Add("Dragons", 7);
            Series.Add("Pumuckl", 10);

            var sortedSeries = SortedNames(Series);
            var highestEvaluation = HighestEvaluation(Series);

            foreach (var series in sortedSeries)
            {
                Console.WriteLine($"Serienname: {series.Key,-25} Bewertung: {series.Value,-2} von 10");
            }
            Console.WriteLine();

            Console.WriteLine("Serien mit einer Bewertung über 8,0:");
            foreach (var series in sortedSeries)
            {
                if (series.Value > 8.0)
                {
                    Console.WriteLine($"Serienname: {series.Key,-25} Bewertung: {series.Value,-2} von 10");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Serie mit der höchsten Bewertung:");
            foreach (var series in highestEvaluation)
            {
                Console.WriteLine($"Serienname: {series.Key,-25} Bewertung: {series.Value} von 10");
            }
            Console.WriteLine();
            Console.WriteLine("Gib eine Serie ein, von der du die Bewertung wissen willst");
            var serieName = LookingForSeries();
            foreach (var serie in Series)
            {
                if (serie.Key.Contains(serieName))
                {
                    Console.WriteLine("Die Bewertung dieser Serie ist: " + serie.Value+ " von 10");
                }
            }
            if (!Series.Keys.Contains(serieName))
            {
                Console.WriteLine("Von dieser Serie habe ich die Bewertung nicht");
            }
        }
        public static Dictionary<string, double> SortedNames(Dictionary<string, double> sortedNames)
        {
            var sortedSeries = sortedNames.OrderBy(sortedSeries => sortedSeries.Key);
            return sortedSeries.ToDictionary(sortedSeries => sortedSeries.Key, sortedSeries => sortedSeries.Value);
        }
        public static Dictionary<string, double> HighestEvaluation(Dictionary<string, double> sortedNames)
        {
            var highestEvaluation = sortedNames.MaxBy(highestEvaluation => highestEvaluation.Value);
            return new Dictionary<string, double> { { highestEvaluation.Key, highestEvaluation.Value } };
        }
        public static string LookingForSeries()
        {
            string lookingForSeries = Console.ReadLine();
            return lookingForSeries;
        }
    }
}