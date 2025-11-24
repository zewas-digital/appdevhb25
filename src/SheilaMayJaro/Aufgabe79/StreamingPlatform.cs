namespace Appdevhb25.SheilaMayJaro.Aufgabe79
{
    public class StreamingPlatform
    {
        public Series Series = new Series();
        public static Dictionary<string, double> RatingOfSeries = new Dictionary<string, double>();

        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 79)");
            StreamingPlatform listOfSeries = new StreamingPlatform();
            listOfSeries.AddSeries("Haikyu", 8.5);
            listOfSeries.AddSeries("The Amazing Digital Circus", 8.8);
            listOfSeries.AddSeries("Tagebücher der Apothekerin", 7.8);
            listOfSeries.AddSeries("With you in the Rain", 7.4);
            listOfSeries.AddSeries("Bluey", 8.2);
            listOfSeries.PrintSeries();
            listOfSeries.AddRating();
            listOfSeries.PrintTopSeries();



        }
        public void AddRating()
        {
            System.Console.WriteLine("Zu welcher Serie willst du eine Bewertung hinzufügen?");
            string userInputWhichSeries = Console.ReadLine();
            System.Console.WriteLine("Welche Bewertung erhält die Serie?");
            double userInputSeriesRating = Convert.ToDouble(Console.ReadLine());
            RatingOfSeries.Remove(userInputWhichSeries);
            RatingOfSeries.Add(userInputWhichSeries, userInputSeriesRating);
        }
        //Ausgabe der Top 3
        public void PrintSeries()
        {
            System.Console.WriteLine("Serien:");
            foreach (KeyValuePair<string, double> item in RatingOfSeries)
            {
                System.Console.WriteLine($"\nSerienname: {item.Key}\nBewertung: {item.Value}");
            }
        }
        public void PrintTopSeries()
        {
            System.Console.WriteLine("Top 3 Serien:");
            RatingOfSeries = RatingOfSeries.OrderBy(RatingOfSeries => RatingOfSeries.Value).Reverse().ToDictionary();
            int count = 0; 
            foreach (var item in RatingOfSeries)
            {
                if (count < 3)
                {
                    System.Console.WriteLine($"Serienname: {item.Key}\nBewertung: {item.Value}");
                    count++; 
                }
                else
                {
                    break; 
                }
            }
        }
        public void AddSeries(string seriesName, double rating)
        {
            RatingOfSeries.Add(seriesName, rating);
        }
    }
}