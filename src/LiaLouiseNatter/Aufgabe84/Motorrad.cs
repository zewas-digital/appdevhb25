namespace Appdevhb25.LiaLouiseNatter.Aufgabe84
{
    public class Motorrad : IGegenstand
    {
        public static int AnzVerkaufteMotorraeder = 0;
        private static float Umsatz = 0;
        private float _kilometerstand ;
        public float Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value < _kilometerstand)
                {
                    System.Console.WriteLine("----------------------------------------------");
                    System.Console.WriteLine("Der Kilometerstand kann nicht verringert werden");

                }
                else
                {
                    _kilometerstand = value;
                }
            }
        }
        public string Farbe;
        private int _leistung;
        public int Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Die Leistung kann nicht negativ sein");
                }
                else
                {
                    _leistung = value;
                }
            }
        }
        public float Kaufpreis;
        public string Kennzeichen;

        // Gebrauchtes Motorrad
        public Motorrad(int kilometerstand, string farbe, int leistung, float kaufpreis, string kennzeichen, string Inventarnummer)
        {
            Kilometerstand = kilometerstand;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;
            AnzVerkaufteMotorraeder++;
            Umsatz += Kaufpreis;
            inventarnummer = Inventarnummer;
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"Kilometerstand: {Kilometerstand}\nFarbe: {Farbe}\nLeistung:{Leistung}\nPreis: {Kaufpreis}\nKennzeichen: {Kennzeichen}");
        }
        // Neues Motorrad
        public Motorrad(string farbe, int leistung, float kaufpreis, string kennzeichen)
        {
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;
            AnzVerkaufteMotorraeder++;
            Umsatz += Kaufpreis;
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"Farbe: {Farbe}\nLeistung:{Leistung}\nPreis: {Kaufpreis}\nKennzeichen: {Kennzeichen}");
        }

        public static double BerechneDurchschnittsUmsatz()
        {
            double durchschnittUmsatzProMotorrad = 0;
            durchschnittUmsatzProMotorrad = Umsatz / AnzVerkaufteMotorraeder;
            return durchschnittUmsatzProMotorrad;

        }


        public string inventarnummer{get;set;}
        public string GegenstandInfo()
        {
            return $"{inventarnummer}, {Farbe}, {Kennzeichen}";
        }


    }
}