namespace Appdevhb25.SheilaMayJaro.Aufgabe83
{
    public class Aufgabe83
    {
        public static void Start()
        {
            Stack<History> browserHistory = new Stack<History>();
            GoingForwards(browserHistory);
            GoingBackwards(browserHistory);



        }
        public static void GoingForwards(Stack<History> browserTabs)
        {
            //damit es auf den Stack gelegt wird, muss es der entsprechende Datentyp sein
            History name = new History();
            string? temp;

            do
            {
                System.Console.WriteLine("Welche Website willst du besuchen?");
                name.WebsiteName = Console.ReadLine();
                browserTabs.Push(name);
                System.Console.WriteLine("Willst du eine weitere Website besuchen gehen?");
                temp = Console.ReadLine();
                if (temp.Contains("Nein"))
                {
                    GoingBackwards(browserTabs);
                }
            } while (temp.Contains("Ja"));
        }
        public static void GoingBackwards(Stack<History> browserTabs)
        {
            string? temp;
            do
            {
                if (browserTabs.Count == 0)
                {
                    System.Console.WriteLine("\nKeine Websiten mehr verfügbar.");
                    break;
                }
                Console.WriteLine(browserTabs.Pop().ToString());
                System.Console.WriteLine("\nWillst du eine weitere Website besuchen gehen?\nWenn nicht, antworte mit 'Nein', dann gehen wir zurück.");
                temp = Console.ReadLine();
                if (temp.Contains("Ja"))
                {
                    GoingForwards(browserTabs);
                }
            } while (temp.Contains("Nein"));
        }
    }
}