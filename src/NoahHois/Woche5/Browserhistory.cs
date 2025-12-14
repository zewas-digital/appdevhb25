using Appdevhb25.NoahHois.Aufgabe18;

namespace Appdevhb25.NoahHois.Aufgabe82
{
    public class Browserhistory
    {
        public static void Start()
        {
            string input;
            Stack<string> browserHistory = new Stack<string>();

            System.Console.WriteLine("Geben Sie eine Website ein");
            input = Console.ReadLine() ?? string.Empty;
            browserHistory.Push(input);

            do
            {

                System.Console.WriteLine(" Seite: " + browserHistory.Peek());
                System.Console.WriteLine("1) Zurück");
                System.Console.WriteLine("2) Neue suche");
                char inputKey = Console.ReadKey().KeyChar;
                System.Console.WriteLine();
                switch (inputKey)
                {
                    case '1':
                        Console.Clear();
                        System.Console.WriteLine($"Du hast die Seite {browserHistory.Peek()} verlassen");
                        browserHistory.Pop();

                        break;
                    case '2':
                        Console.Clear();
                        System.Console.WriteLine("Geben Sie eine Website ein");
                        input = Console.ReadLine() ?? string.Empty;
                        browserHistory.Push(input);
                        break;
                }

            } while (browserHistory.Count != 0);

        }
    }
}