namespace Appdevhb25.LiaLouiseNatter.Aufgabe79
{
    public class Serienstarter
    {
        public static void Start()
        {

            StreamingPlattform newSeries = new StreamingPlattform();
            System.Console.WriteLine("=========Current ratings==========");
            newSeries.makeSeries();

            while (true)
            {
                
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("Search for a Series!");
                string UserSeriesName = Console.ReadLine();
                Series seriesName = new Series { _name = UserSeriesName };
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("How do you Rate this Series?");
                double seriesRating = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("========New Ratings=========");
                newSeries.UserRateSeries(seriesName, seriesRating);
                
                System.Console.WriteLine("Press ESC to end the Pogram");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if(keyInfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            
            
            

        }
    }
}