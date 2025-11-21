using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe79
{
    public class StreamingPlatform
    {
        public Dictionary<Series, double> series = new Dictionary<Series, double>();

        public void InitSeries()
        {
            Series s1 = new Series("1", "Haus des Geldes");
            Series s2 = new Series("2", "Stranger Things");
            Series s3 = new Series("3", "Prision Break");
            Series s4 = new Series("4", "Breaking Bad");

            series.Add(s1, 10);
            series.Add(s2, 10);
            series.Add(s3, 8.7);
            series.Add(s4, 7.3);
        }

        public void RateSeries(string id)
        {
            Series? seriesSelected = series.Where(s => s.Key.ID == id).Select(s => s.Key).FirstOrDefault();
            if (seriesSelected == null)
            {
                System.Console.WriteLine("Diese Serie gibt es nicht!");
                return;
            }
            else
            {
                System.Console.WriteLine("Gib dein Rating für die Serie " + seriesSelected.Name);
                double rating = Helper.checkUserInputDouble();
                series[seriesSelected] = rating;
                System.Console.WriteLine("Bewertung wurde aktualisiert");
            }
        }

        public void printSeries()
        {
            System.Console.WriteLine("----------- Serien -----------");
            foreach (var singleSeries in series)
            {
                System.Console.WriteLine("ID: " + singleSeries.Key.ID + " Name: " + singleSeries.Key.Name + " Rating: " + singleSeries.Value);
            }
        }

        public void printTop3()
        {
            System.Console.WriteLine("----------- Top 3 Serien -----------");

            Dictionary<Series, double> topThree = series.OrderByDescending(s => s.Value).Take(3).ToDictionary();

            foreach (var singleSeries in topThree)
            {
                System.Console.WriteLine("ID: " + singleSeries.Key.ID + " Name: " + singleSeries.Key.Name + " Rating: " + singleSeries.Value);
            }
        }

    }
}