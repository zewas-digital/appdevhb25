using System.Runtime.ConstrainedExecution;
using Appdevhb25.LiaLouiseNatter.Aufgabe53;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe78
{
    public class Serien
    {
        public readonly Dictionary<string, double> _serienUndRatings = new Dictionary<string, double>();
        private Queue<string> UserFavSeries = new Queue<string>();
        private Dictionary<string, double> userFavDict = new Dictionary<string, double>();

        public void neueSerie(string serie, double rating)
        {
            _serienUndRatings.Add(serie, rating);
        }

        public void AllSeries()
        {
            foreach (var serie in _serienUndRatings.OrderBy(s => s.Key))
            {
                System.Console.WriteLine($"Series: {serie.Key}");
            }
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

        // Alle serien in denen der string vorkommt
        public void SearchSeries(string searchedSeries)
        {
            foreach (var serie in _serienUndRatings)
            {
                if (serie.Key.Contains(searchedSeries))
                {
                    System.Console.WriteLine($"Serie: {serie.Key} Rating: {serie.Value}");
                }

            }

        }

        public void UserFavoriteSeries()
        {
            string favoriteSeries;
            
            for (int i = 0; i <= 2; i++)
            {
                System.Console.WriteLine($"Your {i+1}. Favorite Series out of the list: ");
                favoriteSeries = Console.ReadLine();
                UserFavSeries.Enqueue(favoriteSeries);
            }
        }

        public void UserRating()
        {
            
            foreach (string serie in UserFavSeries)
            {
                
                System.Console.WriteLine($"How do you rate {serie}: ");
                double userRatings = double.Parse(Console.ReadLine());
                userFavDict.Add(serie, userRatings);
                DictPrinter(userFavDict);
               

            }
            
        }

        public void DictPrinter(Dictionary<string, double> userDict)
        {
            foreach (var item in userDict)
            {
                Console.WriteLine($"Series: {item.Key}, Rating: {item.Value}");
            }
        }
        
        public void CompareUserToInternal()
        {
            foreach (var userSerie in userFavDict)
            {
                string serie = userSerie.Key;
                double rating = userSerie.Value;

                if (_serienUndRatings.TryGetValue(serie, out double internalRating))
                {
                    System.Console.WriteLine($"Your Rating: {serie}: {rating}/10");
                    System.Console.WriteLine($"Internal Rating: {internalRating}/10");
                }
                
              
                
            }
            

        }
    }
}