using Appdevhb25.NoahHois.Aufgabe79;

namespace Appdevhb25.NoahHois.Aufgabe79
{
    public class ProgramSerie3
    {
        public static void Start()
        {
            StreamingPlattform netflix = new StreamingPlattform();
            netflix.InitPlattform();
            Dictionary<Serie, double> allSeries = netflix.Serien;
            foreach (KeyValuePair<Serie, double> oneSeries in allSeries)
            {
                System.Console.WriteLine($"{oneSeries.Key.SeriesID}: {oneSeries.Key.Name} (Bewertung: {oneSeries.Value})");
            }
            int CountSeries = 0;
            string input;
            double ratingInput;
            do
            {
                System.Console.WriteLine("Wähle eine Serie die du bewerten willst (Name der Serie)");
                input = Console.ReadLine().Trim();
                if (input != "")
                {
                    System.Console.WriteLine("Welche bewertung gibst du der Serie (0 - 10)");
                    ratingInput = Convert.ToDouble(Console.ReadLine());
                    netflix.SetRating(input, ratingInput);
                    foreach (KeyValuePair<Serie, double> kvp in netflix.OrderdSeries())
                    {
                        CountSeries++;
                        System.Console.WriteLine(@$"{CountSeries}. {kvp.Key.Name} {kvp.Value}");
                    }
                }
            } while (input != "");
        }
    }
}