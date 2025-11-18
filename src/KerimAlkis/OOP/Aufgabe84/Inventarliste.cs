namespace Appdevhb25.KerimAlkis.Aufgabe84
{
    public class Inventarliste
    {
        public static void Start()
        {
            List<IGegenstand> inventar = new List<IGegenstand>();
            inventar.Add(new Auto("A-001", "BMW", "M3", 420));
            inventar.Add(new Auto("A-002", "Audi", "A6", 245));

            inventar.Add(new Motorrad("M-101", "Kawasaki", 1000, 205.5));
            inventar.Add(new Motorrad("M-102", "Harley-Davidson", 1800, 322.0));

            inventar.Add(new Fotoapparat("F-500", 24, 650));
            inventar.Add(new Fotoapparat("F-501", 48, 720));

            inventar.Add(new Speicherkarte("S-900", 64_000, "SDXC"));
            inventar.Add(new Speicherkarte("S-901", 32_000, "microSD"));

            foreach(IGegenstand gegentand in inventar)
            {
                System.Console.WriteLine(gegentand.GetGegenstand());
            }
        }
    }
    public interface IGegenstand
    {
        public string Inventarnummer { get; }

        public string GetGegenstand();
    }
    public class Auto : IGegenstand
    {
        public string Inventarnummer { get; set; }

        public string Marke { get; set; }
        public string Modell { get; set; }
        public int PS { get; set; }

        public Auto(string inventarnummer, string marke, string modell, int ps)
        {
            Inventarnummer = inventarnummer;
            Marke = marke;
            Modell = modell;
            PS = ps;
        }
        public string GetGegenstand()
        {
            return "Auto mit der Inventarnummer: " + Inventarnummer;
        }
    }
    public class Motorrad : IGegenstand
    {
        public string Inventarnummer { get; set; }
        public string Hersteller { get; set; }
        public int Hubraum { get; set; }
        public double Gewicht { get; set; }

        public Motorrad(string inventarnummer, string hersteller, int hubraum, double gewicht)
        {
            Inventarnummer = inventarnummer;
            Hersteller = hersteller;
            Hubraum = hubraum;
            Gewicht = gewicht;
        }
        public string GetGegenstand()
        {
            return "Motorrad mit der Inventarnummer: " + Inventarnummer;
        }
    }
    public class Fotoapparat : IGegenstand
    {
        public string Inventarnummer { get; set; }
        public int Megapixel { get; set; }
        public double Gewicht { get; set; }

        public Fotoapparat(string inventarnummer, int megapixel, double gewicht)
        {
            Inventarnummer = inventarnummer;
            Megapixel = megapixel;
            Gewicht = gewicht;
        }
        public string GetGegenstand()
        {
            return "Fotoapparat mit der Inventarnummer: " + Inventarnummer;
        }
    }
    public class Speicherkarte : IGegenstand
    {
        public string Inventarnummer { get; set; }
        public int SpeicherGroesseMB { get; set; }
        public string Typ { get; set; }

        public Speicherkarte(string inventarnummer, int speicherGroesseMB, string typ)
        {
            Inventarnummer = inventarnummer;
            SpeicherGroesseMB = speicherGroesseMB;
            Typ = typ;
        }
        public string GetGegenstand()
        {
            return "Speicherkarte mit der Inventarnummer: " + Inventarnummer;
        }
    }
}