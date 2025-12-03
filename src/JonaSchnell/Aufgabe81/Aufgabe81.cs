using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.JonaSchnell.Aufgabe81
{

    // Erstelle eine Klasse Ticketsystem. Diese enthält die Start-Methode. 
    // Erstelle eine Klasse Konzert. 

    // Aus dieser Klasse generierst du Konzert-Objekte für jedes Konzert, für das Tickets verfügbar sein sollen.

    // Für Jedes Konzert-Objekt möchtest du den Namen sowie eine Warteschlange speichern.

    // Die Warteschlange vom Typ Queue speichert sich die Personen als string. 

    // Erstelle eine Klasse TicketAnbieter. Jeder TicketAnbieter speichert sich in einem Dictionary, welche Person welches Konzert besucht. 

    // Der Key des Dictionarys soll der Name der Person und das Value das besuchte Konzert sein.


    public class Ticketsystem
    {
        public static void Start()
        {
            Konzert konzert1 = new Konzert(Konzert.Konzertnamen());
            TicketAnbieter.Besucher(konzert1);
            konzert1.Warteschlange();
        }
    }
    public class Konzert
    {
        public static string Konzertnamen()
        {
            System.Console.WriteLine("Hallo welches Konzert besuchen sie?");
            string konzertname = Console.ReadLine();
            return konzertname;
        }
        public string Name { get; set; }
        private Queue<string> warteschlange;

        public Konzert(string name)
        {
            Name = name;
            warteschlange = new Queue<string>();
        }

        public void HinzufügenBesucher(string besucherName)
        {
            warteschlange.Enqueue(besucherName);
        }

        public void Warteschlange()
        {
            Console.WriteLine($"Warteschlange für Konzert '{Name}':");
            if (warteschlange.Count == 0)
            {
                Console.WriteLine("Es sind noch keine Besucher in der Warteschlange.");
            }
            else
            {
                foreach (var name in warteschlange)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }


    public class TicketAnbieter
    {
        public static void Besucher(Konzert konzert)
        {
            int i = 0;
            Console.WriteLine("Wie heißt der Besucher? (drücken Sie Enter, um die Eingabe zu beenden)");

            while (true)
            {
                string? inputNames = Console.ReadLine();
                if (string.IsNullOrEmpty(inputNames))
                {
                    break;
                }
                else
                {
                    konzert.HinzufügenBesucher(inputNames);
                    i++;
                }
            }

            Console.WriteLine("Es gehen " + i + " Besucher zu " + konzert.Name);
        }
    }
}