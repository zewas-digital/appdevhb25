using System;
using System.Collections.Generic;

namespace Appdevhb25.SelinUlutuerk.AufgabeV78
{
    class Serien
    {
        private readonly Dictionary<string, double> serien = new Dictionary<string, double>();


        public void serienHinzufuegen(params (string name, double bewertung)[] serienListe)
        {
            foreach (var serie in serienListe)
            {
                serien[serie.name] = serie.bewertung;
            }
        }

        // public Serien()
        // {
        //     serien.Add("TVD", 8.5);
        //     serien.Add("Peaky Blinders", 9.0);
        //     serien.Add("Selling Sunset", 6.0);
        //     serien.Add("Brief an die Zukunft", 5.3);
        //     serien.Add("Outer Banks", 2.2);
        // }

        // Alle Serien werden Sortiert
        public void AlleSerienSortiert()
        {
            System.Console.WriteLine("Sortierte Serien:");
            foreach (var serie in serien.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{serie.Key,-20} Bewertung: {serie.Value:F1}");
            }
            System.Console.WriteLine(new string('-', 40));
        }


        // Alle Serien mit Bewertung über 8
        public void SerienUeberAcht(double wert)
        {
            System.Console.WriteLine($"Serien mit einer Bewertung über {wert}:");
            foreach (var serie in serien.Where(x => x.Value > wert))
            {
                Console.WriteLine($"{serie.Key,-20} Bewertung: {serie.Value:F1}");
            }
            System.Console.WriteLine(new string('-', 40));

            
        }

        // Serie mit höchster Bewertung
        public void BesteSerie()
        {
            var besteSerie = serien.OrderByDescending(serie => serie.Value).First();
            System.Console.WriteLine($"Beste Serie: {besteSerie.Key} ({besteSerie.Value:F1})");
            System.Console.WriteLine(new string('-', 40));
        }

        // weitere Lösung:
        public KeyValuePair<string,double> BesteSerieAnders()
        {
            // Aggregate, um das KeyValuePair mit der höchsten Bewertung zu finden
            // dabei wird eine Funktion auf jedes Paar im Dictionary angewendet:
            // Linker Eintrag (l) und rechter Eintrag (r) werden verglichen
            // Der Eintrag mit dem höheren Wert wird beibehalten
            return serien.Aggregate((l, r) => l.Value > r.Value ? l : r);
        }


        // Suche von Serie über Name
        public void SucheSerie()
        {
            System.Console.WriteLine("Nach welcher Serienbewertung möchtest du suchen?");
            string? eingabe = Console.ReadLine();

            if (eingabe != null && serien.ContainsKey(eingabe))
            {
                double bewertung = serien[eingabe];
                System.Console.WriteLine($"Die Bewertung von {eingabe} ist {bewertung}");
            }
            else
            {
                System.Console.WriteLine("Diese Serie wurde noch nicht bewertet.");
            }
            System.Console.WriteLine(new string('-', 40));
        }
        
        //kürzere Lösung:
        public bool Bewertungsuchen(string name, out double bewertung)
        {
            return serien.TryGetValue(name, out bewertung);
        }
    }
}

