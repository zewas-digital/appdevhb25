using System;
using System.Collections.Generic;

namespace Appdevhb25.SelinUlutuerk.AufgabeV83
{
    public class Browserhistory
    {
        public static void Start()
        {
            Stack<History> website = new Stack<History>();

            do
            {
                System.Console.WriteLine("Gib eine Website ein, welche du besuchen möchtest oder wähle \"back\".");
                string eingabe = Console.ReadLine()?? string.Empty;
                
                if(eingabe != "back")
                {
                    website.Push(new History(eingabe, DateTime.Now));
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
                        History letzteWebsite = website.Pop();
                        System.Console.WriteLine($"Aktuelle Seite '{letzteWebsite}' wird geschlossen - going back");
                    }
                }

            }while(website.Count >= 0);
        }
    }
}