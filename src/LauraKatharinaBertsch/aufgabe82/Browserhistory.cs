using System.Security.Cryptography;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe82
{
    public class Browserhistory
    {
        public static void Start()
        {
            Stack();
        }
        public static void Stack()
        {
            Console.WriteLine("Gib eine Website ein, die du besuchen möchtest. Wenn du keine Website besuchen wolltest schreibe CLOSE ");
            string websiteInput = Console.ReadLine();
            if (websiteInput == "CLOSE")
            {
                return;
            }
            else
            {
                Stack<string> websites = new Stack<string>();
                websites.Push(websiteInput);

                while (websites.Count > 0)
                {
                    Console.WriteLine("Möchtest du eine neue Website aufmachen? ja oder nein");
                    string answer = Console.ReadLine();
                    if (answer == "ja")
                    {
                        Console.WriteLine("Gib den Namen der Website ein");
                        websiteInput = Console.ReadLine();
                        websites.Push(websiteInput);
                    }
                    else if (answer == "nein")
                    {
                        Console.WriteLine("Dann gehen wir eine Website zurück");
                        Console.WriteLine("Wir sind jetzt auf: " + websites.Pop());
                    }
                }
            }
        }
    }
}