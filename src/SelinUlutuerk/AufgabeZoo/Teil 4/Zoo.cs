using System;
using System.Collections.Generic;


namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil4
{
    class Zoo
    {
        public string Name { get; private set; }
        public int Gruendungsjahr { get; private set; }
        private List<Gehege> _gehegeListe = new List<Gehege>();
        private List<Pfleger> _pflegerListe = new List<Pfleger>();


        // Alternative Option:
        // public List<Gehege> _gehegeListe { get; private set; } = new List<Gehege>();

        public Zoo(string name, int gruendungsjahr)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
        }

        // Hinzufügen eines Geheges
        public void HinzufuegenGehege(Gehege gehege)
        {
            _gehegeListe.Add(gehege);
        }

        // Entfernen eiens Geheges
        public void EntfernenGehege(Gehege gehege)
        {
            _gehegeListe.Remove(gehege);
        }

        // Futterbedarf - Gesamtmenge
        public Dictionary<Futter, decimal> Futterbedarf()
        {
            var bedarf = new Dictionary<Futter, decimal>();

            foreach (var g in _gehegeListe)
            {
                foreach (var t in g.HoleTiere())
                {
                    foreach (var e in t.Futterbedarf)
                    {
                        Futter futter = e.Key;
                        decimal menge = e.Value;

                        if (!bedarf.ContainsKey(futter))
                        {
                            bedarf[futter] = 0m;
                        }

                        bedarf[futter] += menge;
                    }
                }
            }
            return bedarf;
        }

        // Ausgabe für den Futterbedarf
        public void AusgabeFutterbedarf()
        {
            var bedarf = Futterbedarf();

            Console.WriteLine("Futterbedarf");
            Console.WriteLine(new string('-', 35));

            decimal gesamtKosten = 0m;

            foreach (var eintrag in bedarf)
            {
                Futter futter = eintrag.Key;
                decimal menge = eintrag.Value;
                decimal kosten = menge * futter.Einheitspreis;

                gesamtKosten += kosten;

                Console.WriteLine($"{futter.Name,-10} {menge,8:0.00} {futter.Einheit,-3} {kosten,8:0.00} €");
            }

            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"Summe{gesamtKosten,27:0.00} €");
        }


        public override string ToString()
        {
            string result = $"├── Zoo: {Name}, gegründet {Gruendungsjahr}\n";

            foreach (var g in _gehegeListe)
            {
                result += $"{g}";
            }

            return result;
        }
    }
}