using System.Dynamic;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil4
{
    public class Zoo(string name, int gruendungsjahr)
    {
        public string Name { get; private set; } = name;
        public int Gruendungsjahr { get; private init; } = gruendungsjahr;
        public List<Gehege> Gehege { get; private set; } = new List<Gehege>();
        public List<Pfleger> Pfleger { get; private set; } = new List<Pfleger>();
        public Dictionary<Futter, double> FutterbedarfGesamt { get; private set; } = new Dictionary<Futter, double>();

        public void GehegeHinzufuegen(string name)
        {
            Gehege.Add(new Gehege(name));
        }
        public void GehegeEntfernen(string name)
        {
            bool gehegeEntfernt = false;
            foreach (Gehege gehege in Gehege)
            {
                if (gehege.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    Gehege.Remove(gehege);
                    gehegeEntfernt = true;
                    break;
                }
            }
            if (!gehegeEntfernt)
                Console.WriteLine("Unbekanntes Gehege. Gehege wurde nicht entfernt!");
        }

        public void PflegerHinzufuegen(string name)
        {
            Pfleger.Add(new Pfleger(name));
        }

        public void FutterbedarfGesamtSpeichern()
        {
            FutterbedarfGesamt.Clear();
            foreach (var gehege in Gehege)
            {
                foreach (var tier in gehege.Tiere)
                {
                    foreach (var futterbedarf in tier.Futterbedarf)
                    {
                        bool futterbedarfGesamtErgaenzt = false;
                        foreach (var futterbedarfGesamt in FutterbedarfGesamt)
                        {
                            if (futterbedarfGesamt.Key.Name == futterbedarf.Key.Name)
                            {
                                FutterbedarfGesamt[futterbedarf.Key] += futterbedarf.Value;
                                futterbedarfGesamtErgaenzt = true;
                                break;
                            }
                        }
                        if (!futterbedarfGesamtErgaenzt)
                            FutterbedarfGesamt.Add(futterbedarf.Key, futterbedarf.Value);
                    }
                }
            }
        }

        public void FutterbedarfAusgeben()
        {
            FutterbedarfGesamtSpeichern();
            double summe = 0;

            Console.WriteLine($"Futterbedarf\n----------------------------------------");
            foreach (var futterbedarf in FutterbedarfGesamt)
            {
                summe += futterbedarf.Value * futterbedarf.Key.Einheitspreis;
                Console.WriteLine($"{futterbedarf.Key.Name,-10}{futterbedarf.Value,10:F2} {futterbedarf.Key.Einheit,-2}{futterbedarf.Value * futterbedarf.Key.Einheitspreis,13:F2} EUR");
            }
            Console.WriteLine($"----------------------------------------\nSumme{summe,31:F2} EUR");
        }

        public override string ToString()
        {
            return $"{Name}, gegründet {Gruendungsjahr}";
        }
    }
}