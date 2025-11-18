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
        public KeyValuePair<string, double> BesteSerieAnders()
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
            System.Console.WriteLine("Nach welcher Serie (Name) möchtest du suchen?");

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

        // Teil 2/ Vertiefung:
        // Ausgabe aller Serien ohne Bewertung
        public void AusgabeOhneBewertung()
        {
            System.Console.WriteLine("Serien ohne Bewertung:");
            foreach (KeyValuePair<string, double> serie in serien)
            {
                System.Console.WriteLine(serie.Key);
            }
            System.Console.WriteLine(new string('-', 40));
        }


        // Liebsten Serien von Benutzer
        public void LiebsteSerie()
        {
            Queue<string> lserien = new Queue<string>();
            Dictionary<string, double> userBewertung = new Dictionary<string, double>();

            System.Console.WriteLine("Wähle 3 Lieblingsserien aus dieser Liste:");
            AusgabeOhneBewertung();
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"Serie {i + 1}:");
                string? eingabe = Console.ReadLine();
                lserien.Enqueue(eingabe);
                System.Console.WriteLine($"Deine Bewertung für {eingabe}:");
                double bewertung = Convert.ToDouble(Console.ReadLine());
                userBewertung.Add(eingabe, bewertung);
            }

            System.Console.WriteLine("\nDeine Favoriten:");
            foreach (string serie in lserien)
            {
                System.Console.WriteLine(serie);
            }

            Console.WriteLine("\nVergleich: intern vs. deine Bewertung");
            Console.WriteLine(new string('-', 40));
            foreach (var name in lserien)
            {
                double intern = serien[name];
                double user = userBewertung[name];

                Console.WriteLine($"{name,-15} intern: {intern,4:F1}   du: {user,4:F1}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}

