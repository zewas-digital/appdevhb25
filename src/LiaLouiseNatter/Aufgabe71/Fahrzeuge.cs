using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe71
{
    public abstract class Fahrzeuge
    {
        private string _farbe;
        public virtual string Farbe
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
        public virtual string Kennzeichen
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
        public virtual double Kilometerstand
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
            string Fahrzeugtyp = "";
            System.Console.WriteLine($"{Fahrzeugtyp}");
            System.Console.WriteLine($"Farbe: {Farbe}\nKennzeichen: {Kennzeichen}\nKilometerstand: {Kilometerstand}\nAnzahl der Produzierten Fahrzeuge: {AnzahlDerProduziertenFahrzeuge}");
        }

        public abstract void Fahren(double distanz);

    }
}