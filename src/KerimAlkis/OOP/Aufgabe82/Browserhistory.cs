using System.Security.Cryptography;
using Appdevhb25.KerimAlkis.Aufgabe04;
using Appdevhb25.KerimAlkis.Aufgabe66;

namespace Appdevhb25.KerimAlkis.Aufgabe82
{
    public class Browserhistory
    {
        public static void Start()
        {
            Stack<string> browserVerlauf = new Stack<string>();
            while (true)
            {
                Console.Clear();
                System.Console.WriteLine("-------Chrome-------");
                if (browserVerlauf.Count == 0)
                {
                    browserVerlauf.Push(NeueSeite()); continue;
                }
                else
                {
                    System.Console.WriteLine("Seite: " + browserVerlauf.Peek());
                    System.Console.WriteLine();
                    System.Console.WriteLine("Druecke 1 um zurückzukehren");
                    System.Console.WriteLine("Druecke 2 um neue Seite zu suchen");
                    char eingabeChar = Console.ReadKey().KeyChar;
                    System.Console.WriteLine();
                    switch (eingabeChar)
                    {
                        case '1': browserVerlauf.Pop(); continue;
                        case '2': break;
                        default: continue;
                    }
                }
                Console.Clear();
                System.Console.WriteLine("-------Chrome-------");
                System.Console.WriteLine("Seite: " + browserVerlauf.Peek());
                browserVerlauf.Push(NeueSeite());
            }
        }
        public static string NeueSeite()
        {
            System.Console.WriteLine("neue Suche: ");
            System.Console.Write("> ");
            return Console.ReadLine();
        }
    }
}