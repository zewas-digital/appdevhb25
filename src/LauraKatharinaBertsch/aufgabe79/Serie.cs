using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe79
{
    public class Serie
    {
        public string _serienName { get; set; }
        public int _serienID { get; set; }
        public string[] _cast { get; set; }
        public static Dictionary<string, int> evaluate = new Dictionary<string, int>();

        public Serie(string serienName, int serienID, params string[] cast)
        {
            _serienName = serienName;
            _serienID = serienID;
            _cast = cast;
        }
        public override string ToString()
        {
            string cast = string.Join(", ", _cast);
            return $"Serienname: {_serienName,-20} | Serien-ID: {_serienID} | Schauspieler: {cast}";
        }
        public static void UserEvaluate()
        {

            Console.WriteLine("Gib eine der gezeigten Serien und eine Bewertung von 1-10 an");
            string userEvaluate = Console.ReadLine() ?? string.Empty;
            string[] split = userEvaluate.Split(" ");

            int rating = Convert.ToInt32(split[1]);
            evaluate.Add(split[0], rating);
        }
        public static void CompareUserEvaluate(Dictionary<string, int> series)
        {
            foreach (KeyValuePair<string, int> serie in series)
            {
                foreach (KeyValuePair<string, int> userSerie in evaluate)
                {
                    if (serie.Key == userSerie.Key)
                    {
                        int serieEvaluation = (serie.Value + userSerie.Value) / 2;
                        series[serie.Key] = serieEvaluation;
                    }
                }
            }
        }
        public static void Top3Series(Dictionary<string, int> series)
        {
            var sortedSeries = series.OrderByDescending(item => item.Value).ToList();
            for (int i = 0; i < 3; i++)
            {
                var content = sortedSeries[i];
                Console.WriteLine(content.Key + " " + content.Value);
            }
        }
    }
}