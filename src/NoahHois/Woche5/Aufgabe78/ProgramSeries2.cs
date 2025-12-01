using Appdevhb25.NoahHois.Aufgabe78;

namespace Appdevhb25.NoahHois.Aufgabe78
{
    public class ProgramBewertungenDesBenutzers
    {
        public static void Start()
        {
            Series2 series = new Series2();
            Dictionary<string, double> /*var*/ sortedSeries = series.Sort();
            Print(sortedSeries);
            System.Console.WriteLine();
            var ratedOver8 = series.RatingOver8();
            Print(ratedOver8);
            System.Console.WriteLine();
            var highestRating = series.HighestRating();
            System.Console.WriteLine($"Serie: {highestRating.Key} Bewertung: {highestRating.Value}");
            System.Console.WriteLine();
            string seriesName = Console.ReadLine();
            series.SearchSeries(seriesName);
            System.Console.WriteLine();
            series.SeriesWithoutRating();
            System.Console.WriteLine();
            series.FavoriteSeries();
        }
        public static void Print(Dictionary<string, double> series)
        {
            foreach (var element in series)
            {
                System.Console.WriteLine($"Serie: {element.Key} Bewertung: {element.Value}");
            }
        }
    }
}