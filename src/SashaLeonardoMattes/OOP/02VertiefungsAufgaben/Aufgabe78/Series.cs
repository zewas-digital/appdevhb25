using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe78
{

    public class Series
    {
        public Dictionary<string, double> Seriesdict = new Dictionary<string, double>();
        public Queue<string> userFavSeries = new Queue<string>();
        public Dictionary<string, double> userFavSeriesDict = new Dictionary<string, double>();

        public Dictionary<string, double> getSeries()
        {
            Dictionary<string, double>? orderedSeries = Seriesdict?.OrderBy(s => s.Key).ToDictionary();
            if (orderedSeries != null)
            {
                return orderedSeries;
            }
            return new Dictionary<string, double>();
        }

        public Dictionary<string, double> getGoodSeries()
        {
            return Seriesdict.Where(s => s.Value > 8.0).ToDictionary();
        }

        public Dictionary<string, double> getBestSeries()
        {
            double max = Seriesdict.Max(s => s.Value);
            return Seriesdict.Where(s => s.Value == max).ToDictionary();
        }

        public void SearchSeries(string name)
        {
            Dictionary<string, double>? result = Seriesdict.Where(s => s.Key == name).ToDictionary();
            if (result.Count == 0)
            {
                System.Console.WriteLine("Serie nicht gefunden");
            }
            else
            {
                System.Console.WriteLine("Serie gefunden Rating: " + result[name]);
            }

        }

        public static void PrintSeries(Dictionary<string, double> series)
        {
            int i = 1;
            foreach (var item in series)
            {
                System.Console.WriteLine(i + ". " + item.Key);
                i++;
            }
        }

        public void AskFavSeries()
        {
            bool seriesFound = false;

            for (int i = 1; i < 4; i++)
            {
                System.Console.WriteLine("Welche dieser Serien findest du am " + i + ". besten?");
                do
                {
                    string input = Helper.checkUserInputString();
                    if (Seriesdict.ContainsKey(input))
                    {
                        seriesFound = true;
                        userFavSeries.Enqueue(input);
                    }
                    else
                    {
                        System.Console.WriteLine("Diese Serie gibt es nicht!");
                        seriesFound = false;
                    } 
                } while (!seriesFound);
               
                
            }
        }

        public void AskRatingFavSeries()
        {
            for (int i = 1; i < 4; i++)
            {
                string series = userFavSeries.Dequeue();
                System.Console.WriteLine("Wie viele Punkte würdest du von 1-10 geben für die Serie: " + series);
                userFavSeriesDict.Add(series, Helper.checkUserInputDouble());
            }
        }

        public void PrintRatingComparison()
        {
            foreach (var item in userFavSeriesDict)
            {
                System.Console.WriteLine($"Serie: {item.Key}\n Dein Rating: {item.Value} \nRating: {Seriesdict[item.Key]}");
            }
        }
    
    }
}
