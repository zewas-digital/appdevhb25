using System.Runtime.InteropServices;

namespace Appdevhb25.SheilaMayJaro.Aufgabe78
{
    public class Series
    {
        private string? _seriesName; 
        private double _rating; 
        public string? SeriesName
        {
            get{return _seriesName;}
            set{_seriesName = value;}
        }
        public double Rating
        {
            get{return _rating;}
            set{_rating = value;}
        }
        public static Dictionary<string, double> seriesRating = new Dictionary<string, double>();

        public Series(string name, double number)
        {
            SeriesName = name;
            Rating = number;
        }
        public Series()
        {

        }
        public void AddSeries(string seriesName, double rating)
        {
            seriesRating.Add(seriesName, rating);
        }
        public Dictionary<string, double> SortSeriesByName()
        {
            return seriesRating.OrderBy(SeriesRating => SeriesName).ToDictionary();
        }
        public void HighRatingSeries()
        {
            System.Console.WriteLine("\nSerien mit einer Bewertung von über 8.0: ");
            foreach (KeyValuePair<string, double> entry in seriesRating)
            {
                if (entry.Value >= 8.0)
                {
                    System.Console.WriteLine($"\nSerien:\nSerienname: {entry.Key}\nmeine Bewertung: {entry.Value}");
                }
            }
        }
        public void BestSeries()
        {
            KeyValuePair<string, double> bestSeries = seriesRating.MaxBy(SeriesRating => Rating);
            System.Console.WriteLine($"\nSerien:\nSerienname: {bestSeries.Key}\nmeine Bewertung: {bestSeries.Value}");

        }
        public void FindSeries()
        {
            System.Console.WriteLine("Von welcher Serie willst du die Bewertung wissen?");
            //Kommentare von Oliver
            string? userInput = Console.ReadLine(); // entspricht/erwartet den Schlüssel


            // Suchen über Vergleich der Schlüssel aller Einträge
            // foreach (KeyValuePair<string, double> entry in seriesRating)
            // {
            //     if (entry.Key == userInput)
            //     {
            //         System.Console.WriteLine($"\nSerien:\nSerienname: {entry.Key}\nmeine Bewertung: {entry.Value}");
            //     }
            // }

            // da Schlüssel bekannt (userInput) ... es kann nur über den richtigen Schlüssel gefunden werden
            // seriesRating[userInput]

            // alternativ:
            if (seriesRating.TryGetValue(userInput, out double rating))
            {
                System.Console.WriteLine($"\nSerien:\nSerienname: {userInput}\nmeine Bewertung: {rating}");
                //gibt den out double aus  
            }
            else
            {
                //option: über Where-Methode nach Schlüsseln filtern, die den userInput beinhalten --> string.Contains
                // alle gefundenen Einträge ausgeben
                foreach (KeyValuePair<string, double> entry in seriesRating)
                {
                    if (entry.Key.Contains(userInput))
                    {
                        System.Console.WriteLine($"\nSerien:\nSerienname: {entry.Key}\nmeine Bewertung: {entry.Value}");
                    }
                }
            }
        }
        public void DisplayDictionary()
        {
            foreach (KeyValuePair<string, double> entry in seriesRating)
            {
                System.Console.WriteLine($"\nSerien:\nSerienname: {entry.Key}\nmeine Bewertung: {entry.Value}");
            }
        }
        public void DisplaySeriesNames()
        {
            foreach (KeyValuePair<string, double> entry in seriesRating)
            {
                System.Console.WriteLine($"\nSerie:\nSerienname: {entry.Key}");
            }
        }
    }
}