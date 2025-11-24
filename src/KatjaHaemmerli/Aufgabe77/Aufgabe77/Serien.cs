using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe77
{
    public class Serien
    {
        // Infos der Serien gespeichert in einem Dictionary
        string SerienName;
        double Bewertung;
        Dictionary<string, double> serien = new Dictionary<string, double>();

        // Konstruktor
        public Serien(string serienName, double bewertung)
        {
            SerienName = serienName;
            Bewertung = bewertung;
        }
        public Serien()
        {

        }
        // public Dictionary<string, double> SortNachNamen()
        public void SortNachNamen()
        {
            System.Console.WriteLine("Sortierte Serien nach Namen: ");
            System.Console.WriteLine(new string('-', 35));
            IEnumerable<KeyValuePair<string, double>> sortierteSerien = serien.OrderBy(serie => serie.Key);

            foreach (var item in sortierteSerien)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }

        }
        public void SerienHinzufuegen(string serienname, double bewertung) // ojektgebunden !nicht! statisch
        {
            serien.Add(serienname, bewertung);
        }

        // Abfragen  
        public void BesteBewertungErmitteln()
        {
            KeyValuePair<string, double> beste = serien.MaxBy(serien => serien.Value);

            System.Console.WriteLine($"Die best bewerteste Serie ist:\n{beste.Key} Bewertung: {beste.Value}");
        }

        public void BewertungUeber8()
        {
            System.Console.WriteLine("Serien mit der Bewertung über 8.0: ");
            System.Console.WriteLine(new string('-', 35));

            foreach (KeyValuePair<string, double> eintrag in serien)
            {
                if (eintrag.Value >= 8)
                {
                    // werte der Liste* hinzufügen                    
                    Console.WriteLine($"{eintrag.Key} Bewertung: {eintrag.Value}");
                }

            }
            
        }
        public void BewertungsSuche()
        {
            // // User soll über Seriennameneingabe die Bewertung der jeweiligen Serien raussuchen können
            // // wenn User bestimmter case (serie) eintippt wird die Bewerung ausgegeben
            System.Console.WriteLine("Bewertungssuche nach Usereingabe:");
            System.Console.WriteLine(new string('-', 35));
            System.Console.WriteLine("Bitte gib die Serie ein zu welcher du die Bewertung sehen möchtest.");
            string input = Console.ReadLine();

            // Alle Schlüssel-Wert-Paare ausgeben
            foreach (KeyValuePair<string, double> eintrag in serien)
            {
                if (eintrag.Key == input)
                {
                    Console.WriteLine($"Bewertung: {eintrag.Value}");
                }
            }

            // switch(input)
            // {
            //     case "Stranger Things":
            //         System.Console.WriteLine("Stranger Things Bewertung: 10"); // Anpassen keine direkte Ausgabe Werte in einer Queue speichern
            //         break;
            //     case "Atypical":
            //         System.Console.WriteLine("Atypical Bewertung: 9.5");
            //         break;
            //     case "Alice in Borderland":
            //         System.Console.WriteLine("Alice in borderland Bewertung: 8.7");
            //         break;
            //     case "Dark":
            //         System.Console.WriteLine("Dark Bewertung: 7.7");
            //         break;
            //     case "Money Heist":
            //         System.Console.WriteLine("Money Heist Bewertung: 6.4");
            //         break; 
            // } 
        }
    }
}