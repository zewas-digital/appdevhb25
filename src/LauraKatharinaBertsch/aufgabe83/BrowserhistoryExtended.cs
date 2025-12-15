namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe83
{
    public class BrowserhistoryExtended
    {
        public static void Start()
        {
            Console.WriteLine("Gib eine Website ein, die du besuchen möchtest. Wenn du keine Website besuchen wolltest schreibe CLOSE ");
            string websiteInput = Console.ReadLine() ?? string.Empty;
            if (websiteInput == "CLOSE")
            {
                return;
            }
            else
            {
                Stack<History> websites = new Stack<History>();
                websites.Push(new History(websiteInput));

                while (websites.Count > 0)
                {
                    Console.WriteLine("Möchtest du eine neue Website aufmachen? ja oder nein");
                    string answer = Console.ReadLine() ?? string.Empty;
                    if (answer == "ja")
                    {
                        Console.WriteLine("Gib den Namen der Website ein");
                        websiteInput = Console.ReadLine() ?? string.Empty;
                        websites.Push(new History(websiteInput));
                    }
                    else if (answer == "nein")
                    {
                        Console.WriteLine("Dann gehen wir eine Website zurück");
                        Console.WriteLine("Wir sind jetzt auf: " + websites.Pop().ToString());
                    }
                }
            }
        }
    }
}