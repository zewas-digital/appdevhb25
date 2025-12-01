using System;

namespace Appdevhb25.OliverBedogg.aufgabe77
{
    public class Aufgabe77
    {
        public static void Start()
        {
            var serienVerwaltung = new Serien();

            // Serien hinzufügen mittels dynamischer Anzahl von Parameter
            // jeder Parameter ist ein Tuple (name, bewertung)
            // die Methode definiert die Typen der Tuple-Elemente als (string, double)
            serienVerwaltung.serienHinzufuegen(
                ("Breaking Bad", 8.5),
                ("Stranger Things", 8.7),
                ("The Witcher", 7.9),
                ("Dark", 8.8),
                ("Wednesday", 7.6)
            );

            Console.WriteLine("Alle Serien und Bewertungen (alphabetisch):");
            foreach (var kvp in serienVerwaltung.AlleSerienAlphabetisch())
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            Console.WriteLine();

            Console.WriteLine("Serien mit Bewertung über 8.0:");
            foreach (var kvp in serienVerwaltung.SerienMitBewertungUeber(8.0))
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            Console.WriteLine();

            var beste = serienVerwaltung.BesteSerie();
            Console.WriteLine($"Beste Serie: {beste.Key} ({beste.Value})");

            Console.WriteLine();

            Console.Write("Gib den Namen einer Serie ein: ");
            string eingabe = Console.ReadLine() ?? string.Empty;
            
            if (serienVerwaltung.BewertungSuchen(eingabe, out double bewertung))
                Console.WriteLine($"Bewertung von {eingabe}: {bewertung}");
            else {
                Console.WriteLine("Serie nicht gefunden.");
            }
        }
    }
}