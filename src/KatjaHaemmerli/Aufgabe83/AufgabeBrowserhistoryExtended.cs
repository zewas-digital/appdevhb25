namespace Appdevhb25.KatjaHaemmerli.Aufgabe83
{
    class AufgabeBrowserhystoryExtended
    {
        public static void Start()
        {
            Stack<Hystory> webseite = new Stack<Hystory>();

            System.Console.WriteLine(webseite);

            do
            {
                System.Console.WriteLine("Bitte gib eine weitere Webaddresse ein oder wähle 'zurück'.");
                string userInput = Console.ReadLine();
                
                // Stack hier einbringen
                if (userInput == "zurück")
                {
                    if(webseite.Count == 0)
                    {
                        // in Stack zurück
                        System.Console.WriteLine("Programm wurde beendet.");
                        break;
                    }
                    else
                    {
                        Hystory gespeicherteWebsite = webseite.Pop(); // letzte Web-Site entfernen                        
                        System.Console.WriteLine($"Aktuelle Web-Seite: {gespeicherteWebsite.ToString()} wird geschlossen - zurück zur vorherigen");                        
                    }
                }
                else
                {
                    webseite.Push(new Hystory(userInput));
                    System.Console.WriteLine("Neue Web-Seite wird geöffnet." + userInput);                
                }               
            } while(webseite.Count > 0); // solange im Stack elemente enthalten zurück möglich
        }
    }
}