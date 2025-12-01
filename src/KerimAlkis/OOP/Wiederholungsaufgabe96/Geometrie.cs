using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.KerimAlkis.Wiederholungsaufgabe96
{
    public class Geometrie
    {
        public static void Start()
        {
            List<Figur> figuren = new();

            Rechteck r1 = new Rechteck("Rechteck A", 10, 5);
            figuren.Add(r1);
            //figuren.Add(new Rechteck("Rechteck B", 5, 2));
            //figuren.Add(new Rechteck("Rechteck C", 3.9, 2.3));
            //figuren.Add(new Rechteck("Rechteck D", 25, 8.92));

            Kreis k1 = new Kreis("Kreis A", 2);
            figuren.Add(k1);
            //figuren.Add(new Kreis("Kreis B", 4.8));
            //figuren.Add(new Kreis("Kreis C", 8));

            GleichseitigesDreieck d1 = new GleichseitigesDreieck("Dreieck A", 3);
            figuren.Add(d1);
            //figuren.Add(new GleichseitigesDreieck("Dreieck B", 5.5));

            Console.WriteLine("---------------");
            foreach (Figur f in figuren)
            {
                Console.Write(f.ToString());
                Console.WriteLine("---------------");
            }
            r1.Skalierbar(2);
            k1.Skalierbar(3);
            foreach (Figur f in figuren)
            {
                Console.Write(f.ToString());
                Console.WriteLine("---------------");
            }

            System.Console.WriteLine("Zaehler");
            Console.WriteLine("Anzahl Figuren: " + Figur.AnzahlDerFiguren);
            Console.WriteLine("Anzahl Rechtecke: " + Rechteck.AnzahlDerRechtecke);
            Console.WriteLine("Anzahl Kreise: " + Kreis.AnzahlDerKreise);
            Console.WriteLine("Anzahl Dreiecke: " + GleichseitigesDreieck.AnzahlDerDreiecke);
            Console.WriteLine("---------------");
        }

    }
    public interface ISkalierbar
    {
        public double Faktor{get;}
        public void Skalierbar(double faktor);
    }
    public abstract class Figur
    {
        public string Name {get; protected set;}
        public string? Elementtyp {get; protected set;}

        public double Umfang{get; protected set;}
        public double Flaecheninhalt{get; protected set;}


        public static int AnzahlDerFiguren {get; private set;}

        public Figur(string name)
        {
            Name = name;
            AnzahlDerFiguren++;
        }

        public override string ToString()
        {
            return $"{"Name:", -15} {Name}\n{"Typ:", -15} {Elementtyp}\n{"Umfang:", -15} {Umfang.ToString("F2")}cm\n{"Flaeche:", -15} {Flaecheninhalt.ToString("F2")}cm²\n";
        }
        protected abstract void BerechneUmfang();
        protected abstract void BerechneFlaecheninhalt();
    }
    public class Rechteck : Figur, ISkalierbar
    {
        public double Laenge{get; private set;}
        public double Breite{get; private set;}

        private double _faktor;
        public double Faktor
        {
            get => _faktor;
            set
            {
                _faktor = value;
                BerechneUmfang();
                BerechneFlaecheninhalt();
            }
        }

        public static int AnzahlDerRechtecke{get; private set;}

        public Rechteck(string name, double laenge, double breite) : base(name)
        {
            Elementtyp = "Rechteck";
            Name = name;
            Laenge = laenge;
            Breite = breite;
            
            Faktor = 1;
            AnzahlDerRechtecke++;
        }
        protected override void BerechneUmfang()
        {
            Umfang = Laenge * 2 + Breite * 2;
        }
        protected override void BerechneFlaecheninhalt()
        {
            Flaecheninhalt = Laenge * Breite;
        }

        public void Skalierbar(double faktor)
        {
            double tempLaenge = Laenge;
            double tempBreite = Breite;
            Laenge *= faktor;
            Breite *= faktor;

            Faktor = faktor;

            Laenge = tempLaenge;
            Breite = tempBreite;
        }

        public override string ToString()
        {
            return base.ToString() + $"{"Laenge:", -15} {Laenge}cm\n{"Breite:", -15} {Breite}cm\n{"Faktor:", -15} {Faktor}\n";
        }
    }
    public class Kreis : Figur, ISkalierbar
    {
        public double Radius{get; private set;}
        private double _faktor;
        public double Faktor
        {
            get => _faktor;
            set
            {
                _faktor = value;
                BerechneUmfang();
                BerechneFlaecheninhalt();
            }
        }

        public static int AnzahlDerKreise{get; private set;}

        public Kreis(string name, double radius) : base(name)
        {
            Elementtyp = "Kreis";
            Name = name;
            Radius = radius;

            Faktor = 1;
            AnzahlDerKreise++;
        }

        protected override void BerechneUmfang()
        {
            Umfang = 2 * Math.PI * Radius;
        }
        protected override void BerechneFlaecheninhalt()
        {
            Flaecheninhalt = Math.PI * Math.Pow(Radius, 2);
        }

        public void Skalierbar(double faktor)
        {
            double tempRadius = Radius;
            Radius *= faktor;
            
            Faktor = faktor;

            Radius = tempRadius;
        }
        public override string ToString()
        {
            return base.ToString() + $"{"Laenge:", -15} {Radius}cm\n{"Faktor:", -15} {Faktor}\n";
        }
    }
    public class GleichseitigesDreieck : Figur
    {
        private double _seitenlaenge;
        public double Seitenlaenge
        {
            get => _seitenlaenge;
            set
            {
                _seitenlaenge = value;
                BerechneUmfang();
                BerechneFlaecheninhalt();
            }
        }
        public static int AnzahlDerDreiecke{get; private set;}

        public GleichseitigesDreieck(string name, double seitenlaenge) : base(name)
        {
            Elementtyp = "GleichseitigesDreieck";
            Name = name;
            Seitenlaenge = seitenlaenge;

            AnzahlDerDreiecke++;
        }
        protected override void BerechneUmfang()
        {
            Umfang = Seitenlaenge * 3;
        }
        protected override void BerechneFlaecheninhalt()
        {
            Flaecheninhalt = (Math.Pow(Seitenlaenge, 2) * Math.Sqrt(3)) / 4;
        }
        public override string ToString()
        {
            return base.ToString() + $"{"Seitenlaenge:", -15} {Seitenlaenge}cm\n";
        }
    }
}