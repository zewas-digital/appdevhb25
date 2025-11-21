using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe77
{
    public class SeriesCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Series s1 = new Series();
            s1.Seriesdict.Add("Haus des Geldes", 10);
            s1.Seriesdict.Add("Stranger Things", 10);
            s1.Seriesdict.Add("Prision Break", 8.6);
            s1.Seriesdict.Add("x", 5);


            System.Console.WriteLine("Serien:");
            PrintSeries(s1.getSeries());
            System.Console.WriteLine();
            System.Console.WriteLine("Serien mit Rating über 8.0:");
            PrintSeries(s1.getGoodSeries());
            System.Console.WriteLine();
            System.Console.WriteLine("Beste Serie(n):");
            PrintSeries(s1.getBestSeries());
            System.Console.WriteLine();
            System.Console.WriteLine("Welche Serie möchtest du suchen?");
            string series = Helper.checkUserInputString();
            s1.SearchSeries(series);

        }
        
        public static void PrintSeries(Dictionary<string, double> series)
        {
            foreach (var item in series)
            {
                System.Console.WriteLine(item.Key + " - Rating: " + item.Value);
            }
        }
    }
}
