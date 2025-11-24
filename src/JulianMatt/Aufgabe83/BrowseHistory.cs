namespace Appdevhb25.JulianMatt.Aufgabe83
{
    public class BrowseHistory
    {
        public static void Start83()
        {
            Stack<HistoryObjekte> browseHistory = new Stack<HistoryObjekte>();

            browseHistory.Push(new HistoryObjekte { URL = "google.com/start.window", TimeWhenVisited = DateTime.Now });

            string input = "";
            while (browseHistory.Count > 0)
            {
                System.Console.WriteLine($"{browseHistory.Peek()}");

                System.Console.WriteLine("Welche option wollen sie benutzen 1 um eine seite zurück zu gehen 2 um zu einer neuen seite zu kommen");
                string whatToDo = Console.ReadLine();

                if (whatToDo == "1")
                {
                    browseHistory.Pop();
                }

                else if (whatToDo == "2")
                {
                    System.Console.Write($"Suche: ");
                    input = Console.ReadLine();
                    System.Console.WriteLine();
                    browseHistory.Push(new HistoryObjekte { URL = input, TimeWhenVisited = DateTime.Now });
                }

            }

        }
    }
}