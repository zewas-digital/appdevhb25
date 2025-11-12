using System;
using System.Collections.Generic;
using Appdevhb25.OliverBedogg.aufgabe75;

namespace Appdevhb25.OliverBedogg.dyndatenstrukturen
{
    public class DictionaryExample
    {
        public static void Start()
        {
            Console.Clear();


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
