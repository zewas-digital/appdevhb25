using System;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SelinUlutuerk.Aufgabe102
{
    public class DBRead
    {
        public static void Start()
        {
            Bibliotheksverwaltung bib = new Bibliotheksverwaltung();

            // Bücher laden
            bib.LadenDerBuecher();

            // Bücher ausgeben
            Console.WriteLine("\n--- Alle Bücher in der Datenbank ---\n");

            foreach(string titel in bib.Buecher)
            {
                Console.WriteLine("- " + titel);
            }
            System.Console.WriteLine();


            // Abfrage von User 
            Console.Write("Suchbegriff eingeben: ");
            string such = Console.ReadLine() ?? string.Empty;

            List<string> ergebnisse = bib.SucheBuecher(such);

            Console.WriteLine("\n--- Suchergebnisse: ---\n");
            if(ergebnisse.Count == 0)
            {
                Console.WriteLine("Keine passenden Ergebnisse gefunden!");
            }
            else
            {
                foreach(string t in ergebnisse)
                {
                    Console.WriteLine("- "+ t);
                }
            }

            System.Console.WriteLine("\n--- Ende der Suche ---");
        }
    }
}