namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe96
{
    public class Kreis : Figur, ISkalierbar
    {
        private double _radius;
        private double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                    _radius = value;
                else
                    Console.WriteLine("Radius kann nicht negativ oder null sein!");
            }
        }
        private static int _anzahlKreise;
        private static int AnzahlKreise 
        {
            get { return _anzahlKreise; }
            set
            {
                if (value > _anzahlKreise)
                    _anzahlKreise = value;
                else
                    Console.WriteLine("Anzahl der Kreise erstellt kann nicht verringert werden!");
            }
        }

        public Kreis(string name, double radius) : base(name, "Kreis")
        {
            Radius = radius;
            AnzahlKreise++;
        }

        public static void AnzahlAnzeigen()
        {
            if (AnzahlKreise == 1)
                Console.WriteLine($"Es wurde bisher {AnzahlKreise} Kreis erstellt.");
            else
                Console.WriteLine($"Es wurden bisher {AnzahlKreise} Kreise erstellt.");
        }

        public void Skalieren(double faktor)
        {
            Radius *= faktor;
        }

        public override double UmfangBerechnen()
        {
            return Radius * 2 * Math.PI;
        }

        public override double FlaecheninhaltBerechnen()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp:\t\t   {Elementtyp}\nRadius: {Radius,15:F2} cm\nUmfang: {UmfangBerechnen(),15:F2} cm\nFlächeninhalt: {FlaecheninhaltBerechnen(),8:F2} cm²";
        }
    }
}