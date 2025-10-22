using System;
using Microsoft.VisualBasic;

namespace Appdevhb25.JonaSchnell.Aufgabe43
{
    public class Aufgabe43
    {
        public static void Start43()
        {
            string[] words = ["Rinderkennzeichnungsfleischetikettierungsüberwachungsaufgabenübertragungsgesetz", "Schauspielerbetreuungsflugbuchungsstatisterieleitungsgastspielorganisationsspezialist", "Donaudampfschifffahrtselektrizitätenhauptbetriebswerkbauunterbeamtengesellschaft", "Grundstücksverkehrsgenehmigungszuständigkeitsübertragungsverordnung", "Aufmerksamkeitsdefizit-Hyperaktivitätsstörung", "Straßenentwässerungsinvestitionskostenschuldendienstumlage", "Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch", "Flugzeug-Jet-Turbinenmotor-Assistenz-Mechaniker", "Pneumonoultramicroscopicsilicovolcanoconiosis", "Kraftfahrzeug-Haftpflichtversicherung"];

            string? wordPart = Console.ReadLine();
            if (string.IsNullOrEmpty(wordPart))
            {
                Console.WriteLine("Ungültige Eingabe!");
                return;
            }
            foreach (string word in words)
            {
                if (word.Trim().ToLower().Contains(wordPart.ToLower()))
                {
                    System.Console.WriteLine(word);
                }
            }
        }
    }
}