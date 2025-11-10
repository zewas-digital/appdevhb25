namespace Appdevhb25.LiaLouiseNatter.Aufgabe70
{
    public class Fahrzeuge
    {
        private string _farbe;
        public string Farbe
        {
            get
            {
                return _farbe;
            }
            private set
            {
                _farbe = value;
            }
        }

        private string _kennzeichen;
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    System.Console.WriteLine("Kennzeichen zu lang/kurz");
                }
                else
                {
                    _kennzeichen = value;
                }
            }
        }

        private double _kilometerstand;
        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value > Kilometerstand)
                {
                    _kilometerstand = value;
                }
                else
                {
                    System.Console.WriteLine("Kilometerstand muss Positiv sein");
                }
            }
        }

        public static int AnzahlDerProduziertenFahrzeuge = 0;
        public Fahrzeuge(string farbe, string kennzeichen, double kilometerstand)
        {
            Farbe = farbe;
            Kennzeichen = kennzeichen;
            Kilometerstand = kilometerstand;
            AnzahlDerProduziertenFahrzeuge++;
        }

        public virtual void DruckeDatenblatt()
        {
            System.Console.WriteLine($"Farbe: {Farbe}\nKennzeichen: {Kennzeichen}\nKilometerstand: {Kilometerstand}\nAnzahl der Produzierten Fahrzeuge: {AnzahlDerProduziertenFahrzeuge}");
        }

    }
}