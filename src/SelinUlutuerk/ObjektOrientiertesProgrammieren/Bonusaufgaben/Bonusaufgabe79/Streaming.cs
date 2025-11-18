using System;
using System.Security.Cryptography;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe79
{
    class Streamingplattform
    {
        private readonly Dictionary<Serie, List<double>> bewertungen = new Dictionary<Serie, List<double>>();

        // Bewertung hinzufügen
        public void NeueBewertungHinzufuegen(Serie serie, double wert)
        {
            if (!bewertungen.ContainsKey(serie))
            {
                bewertungen[serie] = new List<double>();
            }
            bewertungen[serie].Add(wert);
        }

        // erste Bewertung für Initialisierung
        private void ErsteBewertung(Serie serie, double ersteBewertung)
        {
            bewertungen[serie] = new List<double> { ersteBewertung };
        }

        public void Initialisierung()
        {
            var s1 = new Serie(1, "The Vampire Diaries");
            s1.AddSchauspieler(new Schauspieler("Nina", "Dobrov"));
            s1.AddSchauspieler(new Schauspieler("Ian", "Somerhalder"));
            ErsteBewertung(s1, 9.0);



            var s2 = new Serie(2, "Peaky Blinders");
            s2.AddSchauspieler(new Schauspieler("Cillian", "Murphy"));
            ErsteBewertung(s2, 8.5);


            var s3 = new Serie(3, "Selling Sunset");
            s3.AddSchauspieler(new Schauspieler("Chrishell", "Stause"));
            ErsteBewertung(s3, 7.0);


            var s4 = new Serie(4, "Outer Banks");
            s4.AddSchauspieler(new Schauspieler("Chase", "Stokes"));
            ErsteBewertung(s4, 6.5);
        }

        public void AlleSerienAusgeben()
        {
            System.Console.WriteLine("Alle Serien:\n");
            foreach (var s in bewertungen.Keys)
            {
                System.Console.WriteLine($"ID:  {s.SerienID}    {s.Name}");
                System.Console.WriteLine($"          Cast: {s.CastAlsText()}");
            }
        }

        public Serie? FindeID(int id)
        {
            return bewertungen.Keys.FirstOrDefault(s => s.SerienID == id);
        }

        public void Top3()
        {
            // Umwandlung zu Liste für Schleife und sortiertung nach höschster Bewertung
            // pro serie
            var sortedDict = bewertungen
            .OrderByDescending(b => b.Value.Max())
            .ToList();

            System.Console.WriteLine(new string('-', 30));
            System.Console.WriteLine("    Deine Top 3 Serien!");
            System.Console.WriteLine(new string('-', 30));

            for (int i = 0; i < 3; i++)
            {
                var serie = sortedDict[i].Key;
                // neue Sortierung jedes mal 
                double beste = sortedDict[i].Value.Max();

                System.Console.WriteLine($"{i + 1}. {serie.Name,-20} (ID {serie.SerienID}) - {beste}");
            }
        }
    }
    
    class Schauspieler
    {
        public string Vorname { get; private set; }
        public string Nachname { get; private set; }

        public Schauspieler(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname}";
        }
    }

    class Serie
    {
        public string Name { get;  init; }
        public int SerienID { get; private set; }

        public List<Schauspieler> Cast { get; private set; } = new List<Schauspieler>();

        public Serie(int serienID, string name)
        {
            Name = name;
            SerienID = serienID;
        }

        public void AddSchauspieler(Schauspieler s)
        {
            Cast.Add(s);
        }

        public string CastAlsText()
        {
            if (Cast.Count == 0)
            {
                return "kein Cast hinterlegt";
            }
            else
            {
                return string.Join(", ", Cast);
            }
        }

        public override string ToString()
        {
            return $"({SerienID}) {Name}";
        }
    }
}