using System.Runtime.InteropServices;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe78
{
    public class Serien
    {
        public static Dictionary<string, double> Series = new Dictionary<string, double>();
        public static Dictionary<string, double> userEvaluation = new Dictionary<string, double>();
        public static void Start()
        {
            Series.Add("Lauras Stern", 6);
            Series.Add("Shawn das Schaf", 4);
            Series.Add("Die Sendung mit der Maus", 9);
            Series.Add("Dragons", 7);
            Series.Add("Pumuckl", 10);

            foreach (var series in Series)
            {
                Console.WriteLine($"Serienname: {series.Key,-25}");
            }
            Console.WriteLine();
            Console.WriteLine("Welche aus dieser Liste sind deine drei liebsten Serien?");
            FavouriteSeries();
        }

        public static void FavouriteSeries()
        {
            Queue<string> favouriteSeries = new Queue<string>();

            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Gib die " + (count + 1) + ". Serie ein");
                string favouriteSerie = Console.ReadLine();
                favouriteSeries.Enqueue(favouriteSerie);
                count++;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Was ist deine Bewertung der " + (i + 1) + ". Serie von 0 - 10?");
                double evaluation = Convert.ToDouble(Console.ReadLine());

                string firstSeries = favouriteSeries.Dequeue();
                string userSerie = firstSeries;
                userEvaluation.Add(userSerie, evaluation);

            }
            CompareEvaluation();
        }
        public static void CompareEvaluation()
        {
            foreach (KeyValuePair<string, double> serie in Series)
            {
                foreach (KeyValuePair<string, double> userSerie in userEvaluation)
                {
                    if (serie.Key == userSerie.Key && serie.Value == userSerie.Value)
                    {
                        Console.WriteLine($"Die Serie: {serie.Key} hat von dir und von mir die gleiche Bewertung: {serie.Value} von 10");
                    }
                    else if (serie.Key == userSerie.Key && serie.Value != userSerie.Value)
                    {
                        Console.WriteLine($"Die Serie: {serie.Key} hat von dir die Bewertung: {userSerie.Value} von 10, von mir aber: {serie.Value} von 10");
                    }
                }
            }
        }
    }
}