using System.Runtime.ConstrainedExecution;
using Appdevhb25.LiaLouiseNatter.Aufgabe53;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe78
{
    public class Serien
    {
        public readonly Dictionary<string, double> _serienUndRatings = new Dictionary<string, double>();

        public void neueSerie(string serie, double rating)
        {
            _serienUndRatings.Add(serie, rating);
        }

        public void AllSeriesRatingSorted()
        {
            foreach (var serie in _serienUndRatings.OrderBy(s => s.Key))
            {
                System.Console.WriteLine($"Series: {serie.Key} Rating: {serie.Value}");
            }
        }

        public void AllGoodSeries()
        {
            foreach (var serie in _serienUndRatings)
            {
                if (serie.Value > 8.0)
                {
                    System.Console.WriteLine($"Serie: {serie.Key} Rating: {serie.Value}");
                }
            }
        }

        public void BestSeries()
        {
            var bestSeries = _serienUndRatings.MaxBy(s => s.Value);
            System.Console.WriteLine($"Series: {bestSeries.Key} Rating: {bestSeries.Value}");

        }
        
        public void SearchSeries(string searchedSeries)
        {
            foreach (var serie in _serienUndRatings)
            {
                if (serie.Key == searchedSeries)
                {
                    System.Console.WriteLine($"Serie: {serie.Key} Rating: {serie.Value}");
                }

            }
            
        }
    }
}