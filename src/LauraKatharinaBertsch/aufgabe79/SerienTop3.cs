namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe79
{
    public class SerienTop3
    {
        public static void Start()
        {   StreamingPlattform.InitializeSeries();

            var listOfSeries = StreamingPlattform.serienList.ToDictionary(item => item.Key._serienName, item => item.Value);

            Console.WriteLine();
            Serie.UserEvaluate();
            Serie.CompareUserEvaluate(listOfSeries);
            Console.WriteLine();
            Console.WriteLine("Die Top 3 Serien:");
            Serie.Top3Series(listOfSeries);
        }
    }
}