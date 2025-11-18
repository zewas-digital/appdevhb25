using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe82
{
    public class AufgabeBrowserhystory
    {
        /* Aufgabe:
        Button zurück oder eine neue Webseite eingeben können
        Aufgabe mit Stack lösen*/    
        public static void Start()
        {
            Stack<string> webseite = new Stack<string>();

            do
            {
                System.Console.WriteLine("Bitte gib eine Webaddresse ein oder wähle 'zurück'.");
                string userInput = Console.ReadLine();                
                
                if (userInput == "zurück")
                {
                    if(webseite.Count == 0)
                    {                        
                        System.Console.WriteLine("Programm wurde beendet.");
                        break;
                    }
                    else
                    {
                        string gespeicherteWebsite = webseite.Pop(); // letzte Web-Site entfernen                        
                        System.Console.WriteLine($"Aktuelle Web-Seite: {gespeicherteWebsite} wird geschlossen - zurück zur vorherigen ");                        
                    }
                }
                else
                {
                    webseite.Push(userInput);
                    System.Console.WriteLine("Neue Web-Seite wird geöffnet." + userInput);                
                }               
            } while(webseite.Count > 0); // solange im Stack elemente enthalten zurück möglich
        }
    }
}