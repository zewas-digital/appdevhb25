using System.Collections;
using Appdevhb25.NoahHois.Aufgabe18;

namespace Appdevhb25.NoahHois.Aufgabe78
{
    public class Series2
    {
        private Dictionary<string, double> series = new Dictionary<string, double> { { "One Piece", 10 }, { "Bleach", 9.3 }, { "Naruto", 3.8 }, { "Digimon", 8.9 }, { "Cyberpunk", 7.90 } };
        public Dictionary<string, double> Sort()
        {
            return series.OrderBy(b => b.Key).ToDictionary();
        }
        public Dictionary<string, double> RatingOver8()
        {

            var ergebnis = series
                .Where(pair => pair.Value >= 8.0).ToDictionary();
            return ergebnis;
        }
        public KeyValuePair<string, double> HighestRating()
        {
            var highestRating = series.MaxBy(b => b.Value);
            return highestRating;
        }
        public void SearchSeries(string search)
        {
            if (series.ContainsKey(search))
            {
                System.Console.WriteLine($"Serie: {search} Bewertung: {series[search]}");
            }
        }
        public void SeriesWithoutRating()
        {
            foreach (var seriesWithoutRating in series)
            {
                System.Console.WriteLine($"Serie: {seriesWithoutRating.Key}");
            }
        }
        protected Queue<string> queue = new();
        public void FavoriteSeries()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("1) One Piece");
                Console.WriteLine("2) Bleach");
                Console.WriteLine("3) Naruto");
                Console.WriteLine("4) Digimon");
                Console.WriteLine("5) Cyberpunk");
                Console.Write("Eingabe: ");

                string input = Console.ReadLine() ?? string.Empty;
                switch (input)
                {
                    case "1":
                        input = "One Piece";
                        queue.Enqueue("One Piece");
                        break;
                    case "2":
                        input = "Bleach";
                        queue.Enqueue(input);
                        break;
                    case "3":
                        input = "Naruto";
                        queue.Enqueue(input);
                        break;
                    case "4":
                        input = "Digimon";
                        queue.Enqueue(input);
                        break;
                    case "5":
                        input = "Cyberpunk";
                        queue.Enqueue(input);
                        break;
                    default:
                        input = "Ungültige Eingabe, One Piece wird ausgewählt.";
                        queue.Enqueue(input);
                        break;
                }
                System.Console.WriteLine();
            }
            Dictionary<string, double> userRatings = new();
            while (queue.Count > 0)
            {
                string name = queue.Dequeue();
                System.Console.WriteLine($"Bewerte die Serie {name} von 0 - 10");
                double rating = Convert.ToDouble(Console.ReadLine());
                userRatings.Add(name, rating);
            }
            foreach (KeyValuePair<string, double> kvp in userRatings)
            {
                System.Console.WriteLine($@"
Deine Bewertung: {Math.Round(kvp.Value, 2)}
Eigene Bewertung: {Math.Round(series[kvp.Key], 2)}
Differenz: {Math.Round(kvp.Value < series[kvp.Key] ? series[kvp.Key] - kvp.Value : kvp.Value - series[kvp.Key], 2)}
");
            }

        }
    }
}