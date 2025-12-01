namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe83
{
    public class BrowserhistoryExtended
    {
        public static void Start()
        {
            Stack<History> browserVerlauf = new Stack<History>();
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
        public static History NeueSeite()
        {
            System.Console.WriteLine("neue Suche: ");
            System.Console.Write("> ");
            return new History(Console.ReadLine());
        }
    }
    public class History
    {
        public string Name;
        public DateTime Datum;

        public History(string name)
        {
            Name = name;
            Datum = DateTime.Now;
        }

        public override string ToString()
        {
            return Name + " (Datum: " + Datum.ToString("dd.MMM.yyyy | HH:mm")+ ")";
        }
    }
}