namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe96
{
    public class Rechteck : Figur, ISkalierbar
    {
        private double _laenge;
        private double Laenge
        {
            get { return _laenge; }
            set
            {
                if (value > 0)
                    _laenge = value;
                else
                    Console.WriteLine("Länge kann nicht negativ oder null sein!");
            }
        }
        private double _breite;
        private double Breite
        {
            get { return _breite; }
            set
            {
                if (value > 0)
                    _breite = value;
                else
                    Console.WriteLine("Breite kann nicht negativ oder null sein!");
            }
        }
        private static int _anzahlRechtecke;
        private static int AnzahlRechtecke
        {
            get { return _anzahlRechtecke; }
            set
            {
                if (value > _anzahlRechtecke)
                    _anzahlRechtecke = value;
                else
                    Console.WriteLine("Anzahl der Rechtecke erstellt kann nicht verringert werden!");
            }
        }

        public Rechteck(string name, double laenge, double breite) : base(name, "Rechteck")
        {
            Laenge = laenge;
            Breite = breite;
            AnzahlRechtecke++;
        }

        public static void AnzahlAnzeigen()
        {
            if (AnzahlRechtecke == 1)
                Console.WriteLine($"Es wurde bisher {AnzahlRechtecke} Rechteck erstellt.");
            else
                Console.WriteLine($"Es wurden bisher {AnzahlRechtecke} Rechtecke erstellt.");
        }

        public void Skalieren(double faktor)
        {
            Laenge *= faktor;
            Breite *= faktor;
        }

        public override double UmfangBerechnen()
        {
            return Laenge * 2 + Breite * 2;
        }

        public override double FlaecheninhaltBerechnen()
        {
            return Laenge * Breite;
        }

        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp:\t\t   {Elementtyp}\nLänge: {Laenge,16:F2} cm\nBreite: {Breite,15:F2} cm\nUmfang: {UmfangBerechnen(),15:F2} cm\nFlächeninhalt: {FlaecheninhaltBerechnen(),8:F2} cm²";
        }
    }
}