using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe78
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
            s1.Seriesdict.Add("Breaking Bad", 7.8);


            System.Console.WriteLine("Serien:");
            Series.PrintSeries(s1.getSeries());

            s1.AskFavSeries();
            s1.AskRatingFavSeries();
            s1.PrintRatingComparison();
        }

        
        
    }
}
