using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe82
{
    public class Browserhistory
    {
        public static void Start()
        {
            Stack<string> website = new Stack<string>();

            do
            {
                System.Console.WriteLine("Gib eine Website ein, welche du besuchen möchtest oder wähle \"back\".");
                string? eingabe = Console.ReadLine();

                if(eingabe != "back")
                {
                    website.Push(eingabe);
                    System.Console.WriteLine($"Gewünschte Website '{eingabe}' wird geöffnet.");
                    continue;
                }
                else if (eingabe == "back")
                {
                    if(website.Count == 0)
                    {
                        System.Console.WriteLine("Keine weiteren Seiten vorhanden... Programm wird beendet!");
                        break;
                    }
                    else if ( website.Count > 0)
                    {
                        string letzteWebsite = website.Pop();
                        System.Console.WriteLine($"Aktuelle Seite '{letzteWebsite}' wird geschlossen - going back");
                    }
                }

            }while(website.Count >= 0);
        }
    }
}