namespace Appdevhb25.JulianMatt.Aufgabe82
{
    public class BrowseHistory
    {
        public static void Start82()
        {
            Stack<string> browseHistory = new Stack<string>();

            browseHistory.Push("google.com/start.window");
            string input = "";
            while(true)
            {
                System.Console.WriteLine($"Die jetzige Websie ist: {browseHistory.Peek()}");

                System.Console.WriteLine("Welche option wollen sie benutzen 1 um eine seite zurück zu gehen 2 um zu einer neuen seite zu kommen");
                string whatToDo = Console.ReadLine();
                
                if (whatToDo == "1")
                {
                    browseHistory.Pop();

                    if (browseHistory.Count == 0)
                    {
                        break;
                    }
                }

                else if (whatToDo == "2")
                {
                    System.Console.Write($"Suche: ");
                    input = Console.ReadLine();
                    System.Console.WriteLine();

                    browseHistory.Push(input);
                }
                
            }
            
        }
    }
}