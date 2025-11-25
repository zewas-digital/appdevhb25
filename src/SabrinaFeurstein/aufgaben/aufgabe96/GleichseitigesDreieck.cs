namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe96
{
    public class GleichseitigesDreieck : Figur
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
                    Console.WriteLine("Seitenlänge kann nicht negativ oder null sein!");
            }
        }
        private static int _anzahlDreiecke;
        private static int AnzahlDreiecke 
        {
            get { return _anzahlDreiecke; }
            set
            {
                if (value > _anzahlDreiecke)
                    _anzahlDreiecke = value;
                else
                    Console.WriteLine("Anzahl der gleichseitigen Dreiecke erstellt kann nicht verringert werden!");
            }
        }

        public GleichseitigesDreieck(string name, double laenge) : base(name, "Gleichseitiges Dreieck")
        {
            Laenge = laenge;
            AnzahlDreiecke++;
        }

        public static void AnzahlAnzeigen()
        {
            if (AnzahlDreiecke == 1)
                Console.WriteLine($"Es wurde bisher {AnzahlDreiecke} gleichseitiges Dreieck erstellt.");
            else
                Console.WriteLine($"Es wurden bisher {AnzahlDreiecke} gleichseitige Dreiecke erstellt.");
        }

        public override double UmfangBerechnen()
        {
            return Laenge * 3;
        }

        public override double FlaecheninhaltBerechnen()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(Laenge, 2);
        }

        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp:\t\t   {Elementtyp}\nSeitenLänge: {Laenge,10:F2} cm\nUmfang: {UmfangBerechnen(),15:F2} cm\nFlächeninhalt: {FlaecheninhaltBerechnen(),8:F2} cm²";
        }
    }
}