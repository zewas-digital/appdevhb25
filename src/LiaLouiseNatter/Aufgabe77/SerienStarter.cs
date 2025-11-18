namespace Appdevhb25.LiaLouiseNatter.Aufgabe77
{
    public class Serienstarter
    {
        public static void Start()
        {
            Serien serie = new Serien();
            serie.neueSerie("Bojack Horseman", 9.5);
            serie.neueSerie("Breaking Bad", 9.0);
            serie.neueSerie("Cyberpunk Edgerunners", 8.7);
            serie.neueSerie("Arcane", 9.0);
            serie.neueSerie("The Walking Dead", 7.0);

            System.Console.WriteLine("------------All Series-------------\n");
            serie.AllSeriesRatingSorted();
            System.Console.WriteLine("\n------------All Series Over 8.0-------------\n");
            serie.AllGoodSeries();
            System.Console.WriteLine("\n------------Best rated Series-------------\n");
            serie.BestSeries();
            System.Console.WriteLine("\n------------Search Series Rating-------------\n");
            System.Console.Write("\nWich series are you looking for? ");
            string series = Console.ReadLine();
            serie.SearchSeries(series);

        }
    }
}