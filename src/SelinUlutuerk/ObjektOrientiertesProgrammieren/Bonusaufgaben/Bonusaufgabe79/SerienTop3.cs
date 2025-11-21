using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe79
{
    public class SerienTopDrei
    {
        public static void Start()
        {
            Streamingplattform plattform = new Streamingplattform();
            // 1. Schritt
            plattform.Initialisierung();

            // 2. Schritt
            System.Console.WriteLine(new string('-', 50));
            System.Console.WriteLine("    Willkommen zur Serienbewertungsplattform!");
            System.Console.WriteLine(new string('-', 50));

            plattform.AlleSerienAusgeben();


            while (true)
            {
                System.Console.WriteLine("Wähle eine Serien-ID um diese zu Bewerten (oder 'quit' zum Beenden):");
                string? eingabe = Console.ReadLine();

                // Überprüfen ob das Programm beendet werden soll
                if (string.Equals(eingabe, "quit", StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine(new string('-', 30));
                    System.Console.WriteLine("Programm wird beendet...");
                    System.Console.WriteLine(new string('-', 30));
                    break;
                }

                // Überprüfung der ID (richtiger Wert?)
                if (!int.TryParse(eingabe, out int serienID))
                {
                    System.Console.WriteLine(new string('-', 30));
                    System.Console.WriteLine("Ungültige Eingabe. Bitte eine gültige ID eingeben.");
                    System.Console.WriteLine(new string('-', 30));
                    continue;
                }

                // Existenz prüfen
                Serie? auswahl = plattform.FindeID(serienID);
                if (auswahl == null)
                {
                    System.Console.WriteLine(new string('-', 30));
                    System.Console.WriteLine("Keine Serie mit dieser ID gefunden.");
                    System.Console.WriteLine(new string('-', 30));
                    continue;
                }

                System.Console.WriteLine($"Deine Bewertung für \"{auswahl}\" (0-10):");
                string? bewertungEingabe = Console.ReadLine();

                if (!double.TryParse(bewertungEingabe, out double wert) || wert < 0 || wert > 10)
                {
                    System.Console.WriteLine("Ungültige Bewertung. Bitte eine Zahl zwischen 0 und 10 eingeben!");
                    continue;
                }

                plattform.NeueBewertungHinzufuegen(auswahl, wert);

                System.Console.WriteLine(new string('-', 30));
                System.Console.WriteLine("Bewertung wurde gespeichert!");
                

                plattform.Top3();
            }
        }
    }
}