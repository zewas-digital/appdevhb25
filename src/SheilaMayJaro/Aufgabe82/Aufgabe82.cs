namespace Appdevhb25.SheilaMayJaro.Aufgabe82
{
    public class Aufgabe82
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 82)");
            //Erstelle ein Programm, mit dem man entweder eine neue Website besuchen (hierzu wird einfach ein String mit dem Website Namen über die Console eingelesen) 
            //oder zur letzten zurückkehren kann.
            // Die Navigation vor/zurück erfolgt durch einen entsprechenden Input von der Konsole. 
            // Wenn der Nutzer eine Website besuchen will, wird diese oben auf den Stack gelegt. 
            // Verwende die Datenstruktur Stack, um diese Aufgabe zu lösen. Wenn er zurück navigiert, 
            // wird die oberste Website vom Stack entfernt und auf der Konsole ausgegeben. 
            // Das Programm beendet sich, wenn der Nutzer zurück navigiert und keine Elemente mehr auf dem Stack sind, also die Browser History leer ist.

            Stack<string> browserTabs = new Stack<string>();
            GoingForwards(browserTabs); 
            GoingBackwards(browserTabs); 
            
        }
        public static void GoingForwards(Stack<string> browserHistory)
        {
            string? temp; 
            do
            {
                System.Console.WriteLine("Welche Website willst du besuchen?");
                temp = Console.ReadLine();
                browserHistory.Push(temp);
                System.Console.WriteLine("Willst du eine weitere Website besuchen gehen?");
                temp = Console.ReadLine();
                if (temp.Contains("Nein"))
                {
                    GoingBackwards(browserHistory);
                }
            } while (temp.Contains("Ja"));

        }
        public static void GoingBackwards (Stack<string> browserTabs)
        {
            string? temp;
            do
            {
                if (browserTabs.Count == 0)
                {
                    System.Console.WriteLine("\nKeine Websiten mehr verfügbar.");
                    break;
                }
                Console.WriteLine($"\nVorige Website: {browserTabs.Pop()}");
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