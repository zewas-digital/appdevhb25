using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Appdevhb25.OliverBedogg.aufgabe75;

namespace Appdevhb25.OliverBedogg.dyndatenstrukturen
{
    public class DictionaryExample
    {
        public static void Start()
        {
            Console.Clear();
            // BasisBeispiele();
            WertMitTryGetValue();
            SucheMitWhere();
            EintraegeAggregieren();
        }

        // Beispiel für die Abfrage des Werts mit TryGetValue
        // um einen Wert sicher anhand eines Schlüssels zu finden
        public static void WertMitTryGetValue()
        {
            // Wörterbuch mit englischen und deutschen Wörtern
            Dictionary<string, string> woerterbuch =
                new Dictionary<string, string>()
                {
                    {"cat", "Katze" },
                    {"dog", "Hund" },
                    {"house", "Haus" },
                    {"car", "Auto" },
                    {"tree", "Baum" }
                };

            string englischesWort = "car";
            if (woerterbuch.TryGetValue(englischesWort, out string? deutschesWort))
            {
                Console.WriteLine(
                    "Das deutsche Wort für {0} ist {1}",
                    englischesWort,
                    deutschesWort);
            }
            else
            {
                Console.WriteLine(
                    "Das Wort {0} ist nicht im Wörterbuch vorhanden.",
                    englischesWort);
            }
        }

        // Beispiel für die Suche mit LINQ's Where-Methode
        // um Einträge basierend auf einem Kriterium zu filtern
        public static void SucheMitWhere()
        {
            // Schülerliste mit Namen und Alter
            Dictionary<string, int> schuelerAlter =
                new Dictionary<string, int>()
                {
                    {"Anna", 15 },
                    {"Ben", 16 },
                    {"Clara", 15 },
                    {"David", 17 },
                    {"Eva", 16 }
                };

            // Suche nach Schülern, die 16 Jahre und älter sind
            var ergebnis = schuelerAlter
                .Where(pair => pair.Value >= 16);
        }

        // Beispiel für das Aggregieren von Einträgen
        public static void EintraegeAggregieren()
        {
            // Produktliste mit Produktnamen und Preisen
            Dictionary<string, double> produktPreise =
                new Dictionary<string, double>()
                {
                    {"Apfel", 0.50 },
                    {"Banane", 0.30 },
                    {"Kirsche", 0.20 },
                    {"Mango", 1.50 }
                };

            // das Produkt mit höchstem Preis finden
            var teuerstesProdukt = produktPreise.Aggregate((thisPair, nextPair) =>
                nextPair.Value > thisPair.Value ? nextPair : thisPair);
                // Pair steht für KeyValuePair<string, double>
                // thisPair ist der aktuell höchste Eintrag
                // nextPair ist der nächste Eintrag in der Iteration
        }

        public static void BasisBeispiele()
        {
            // Trainer-Liste mit Trainernamen und Kursstunden
            // Schlüssel: Name (string)
            // Wert: Kursstunden (int)
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Add-Methode erwartet sich den Schlüssel und den Wert
            dict.Add("Sandro", 13);
            dict.Add("Lukas", 7);
            dict.Add("Hassan", 14);
            dict.Add("Berna", 6);

            // Alternative Syntax zum Hinzufügen von Einträgen
            dict["Gyula"] = 42;
            // Schreiben und Lesen sind identisch
            Console.WriteLine("Gyula hat {0} Kursstunden", dict["Gyula"]);

            // Alle Schlüssel (Namen) ausgeben
            foreach (string name in dict.Keys)
            {
                Console.WriteLine("Name: {0}", name);
            }

            // Alle Werte (Kursstunden) ausgeben
            foreach (int stunden in dict.Values)
            {
                Console.WriteLine("Kursstunden: {0}", stunden);
            }

            // Alle Schlüssel-Wert-Paare ausgeben
            foreach (KeyValuePair<string, int> eintrag in dict)
            {
                Console.WriteLine(
                    "Trainer {0} hat {1} Kursstunden",
                    eintrag.Key,
                    eintrag.Value
                    );
            }
            // kurzschreibweise mit var
            // foreach (var eintrag in dict)

            dict.Remove("Gyula");

            Console.WriteLine(
                "Sandro hat {0} Kursstunden pro Woche",
                dict["Sandro"]);

            dict["Sandro"] += 7;

            Console.WriteLine(
                "Sandro hat nächste Woche {0} Kursstunden",
                dict["Sandro"]);


            Console.WriteLine("Ist Jovo ein Trainer? {0}",
                dict.ContainsKey("Jovo"));
            Console.WriteLine("Ist Lukas ein Trainer? {0}",
                dict.ContainsKey("Lukas"));

            dict.Remove("UFO");
            Console.WriteLine(
                "Es gibt {0} aktive Trainer.",
                dict.Count
                );
        }
    }
}
