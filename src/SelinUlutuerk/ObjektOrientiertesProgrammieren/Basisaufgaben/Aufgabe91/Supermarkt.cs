using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe91
{
    class Produkt
    {
        public string Artikelnummer { get; }
        public string Name { get; }
        public double Preis { get; }

        public Produkt(string artikelnummer, string name, double preis)
        {
            Artikelnummer = artikelnummer;
            Name = name;
            Preis = preis;
        }

        public override string ToString()
        {
            return $"[{Artikelnummer}] {Name} - {Preis:F2} €";
        }
    }

    class Kasse
    {
        public double Tagesumsatz { get; private set; }

        public void Bezahlen(Warenkorb warenkorb)
        {
            double betrag = warenkorb.WarenkorbGesamtwert();
            Tagesumsatz += betrag;
            System.Console.WriteLine($"Zu bezahlender Betrag {betrag:F2} €");
            warenkorb.Leeren();
            System.Console.WriteLine("--- Vielen Dank für deinen Einkauf ---");
        }

        public void PrintTagesumsatz()
        {
            System.Console.WriteLine(new string('-', 40));
            System.Console.WriteLine($"Der Tagesumsatz dieser Kasse beläuft sich auf: {Tagesumsatz:F2} €");
            System.Console.WriteLine(new string('-', 40));
        }
    }

    class Warenkorb
    {
        public List<WarenkorbInhalt> Inhalt = new List<WarenkorbInhalt>();
        public double Gesamtwert => Inhalt.Sum(p => p.Gesamtpreis);
        // zur verwendung vom Gesamtwert in der Kasse
        public double WarenkorbGesamtwert() => Gesamtwert;


        // P hinzufügen
        public void Hinzufuegen(Produkt produkt, int menge)
        {
            var pos = Inhalt.FirstOrDefault(p => p.Produkt == produkt);
            if (pos == null)
            {
                Inhalt.Add(new WarenkorbInhalt(produkt, menge));
            }
            else
            {
                pos.Menge += menge;
            }

            WarenkorbInhaltAusgeben();
        }

        // P löschen
        public void Loeschen(Produkt produkt)
        {
            Inhalt.RemoveAll(p => p.Produkt == produkt);
            WarenkorbInhaltAusgeben();
        }

        // P bearbeiten
        public void Bearbeiten(Produkt produkt, int neueMenge)
        {
            var pos = Inhalt.FirstOrDefault(p => p.Produkt == produkt);
            if (pos != null)
            {
                if (neueMenge <= 0)
                    Inhalt.Remove(pos);
                else
                    pos.Menge = neueMenge;
            }

            WarenkorbInhaltAusgeben();
        }

        // Inhalt ausgabe
        public void WarenkorbInhaltAusgeben()
        {
            System.Console.WriteLine("\n------- Aktueller Warenkorb -------");
            if (!Inhalt.Any())
            {
                System.Console.WriteLine("*** Leerer Warenkorb ***");
            }
            else
            {
                foreach (var p in Inhalt)
                {
                    System.Console.WriteLine(p);
                }
            }
            System.Console.WriteLine($"Gesamt: {Gesamtwert:F2} €");
            System.Console.WriteLine(new string('-', 40));
        }

        // Warenkorb nach bezahlen leeren
        public void Leeren()
        {
            Inhalt.Clear();
        }
    }

    class WarenkorbInhalt
    {
        public Produkt Produkt { get; }
        public int Menge { get; set; }

        public double Gesamtpreis => Produkt.Preis * Menge;

        public WarenkorbInhalt(Produkt produkt, int menge)
        {
            Produkt = produkt;
            Menge = menge;
        }

        public override string ToString()
        {
            return $"{Produkt.Name,-20} x {Menge,2} = {Gesamtpreis,5:F2} €";
        }
    }
}