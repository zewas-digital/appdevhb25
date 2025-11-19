using System;
using Appdevhb25.SheilaMayJaro.Aufgabe78;
namespace Appdevhb25.SheilaMayJaro.Aufgabe78
{
    public class Aufgabe78
    {
       public static void Start()
        {
            System.Console.WriteLine("Aufgabe 78)");

            /*
            Erweitere die Aufgabe 77 um folgende Funktionalität.
            
            Das Programm soll folgende Schritte ausführen:
                1. Ausgabe aller Serien ohne Bewertungen
                2. Benutzeraufforderung seine/ihre drei liebsten Serien aus der Liste zu wählen.
                --> die drei Serien sollen in einer Queue abgelegt werden
                3. Pro Eintrag in der Queue soll die Bewertung der Serie abgefragt werden
                --> die Benutzerbewertungen werden in einem eigenen Dictonary gespeichert
                4. Das Programm gibt die internen Bewertungen im Vergleich zu den Benutzerbewertungen zurück
            */

            Series seriesList = new Series();
            seriesList.AddSeries("Haikyu", 8.5);
            seriesList.AddSeries("Bluey", 8.2);
            seriesList.AddSeries("The Amazing Digital Circus", 8.8);
            seriesList.AddSeries("Tagebücher der Apothekerin", 7.8);
            seriesList.AddSeries("With you in the Rain", 7.4);
            seriesList.DisplayDictionary();
            seriesList.SortSeriesByName();
            seriesList.HighRatingSeries();
            seriesList.BestSeries();
            seriesList.FindSeries();
            seriesList.DisplaySeriesNames();
            Series series0 = new Series("Haikyu", 8.5); 
            Series series1 = new Series("Bluey", 8.2); 
            Series series2 = new Series("The Amazing Digital Circus", 8.8); 
            Queue<Series> FavSeriesList = new Queue<Series>();
            FavSeriesList.Enqueue(series0);
            FavSeriesList.Enqueue(series1); 
            FavSeriesList.Enqueue(series2);
            foreach (var item in FavSeriesList)
            {
                System.Console.WriteLine($"\nBewertung von {item.SeriesName}: {item.Rating} von 10 Sternen.");
            }
            Dictionary<string, double> ratingOfFavSeries = new Dictionary<string, double>();
            foreach (var item in FavSeriesList)
            {
                System.Console.WriteLine($"Gib deine Bewertung zur Serie {item.SeriesName} an:");
                double userRating = Convert.ToDouble(Console.ReadLine()); 
                ratingOfFavSeries.Add(item.SeriesName,userRating);
            }
            //Vergleich der Benutzerbewertungen und meine Bewertungen 
            System.Console.WriteLine("\nMeine Bewertungen:");
            foreach (var item in FavSeriesList)
            {
                System.Console.WriteLine($"Serie: {item.SeriesName}, Bewertung: {item.Rating}");
            }
            System.Console.WriteLine("\nBenutzerbewertungen:");
            foreach (var item in ratingOfFavSeries)
            {
                System.Console.WriteLine($"Serie: {item.Key}, Bewertung: {item.Value}");
            }
        }
    }
}