using System.Text.RegularExpressions;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe71
{
    public abstract class AbstrakteFahrzeuge
    {
        public static int AnzahlDerProduziertenFahrzeuge;
        private string _farbe;
        public string _kennzeichen;
        public double _kilometerstand;
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
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^(?=.*[A-Z])(?=.*[0-9])$"))
                {
                    _kennzeichen = value;
                }
                else
                {
                    Console.WriteLine("Ein Kennzeichen braucht Buchstaben und Zahlen");
                }
            }
        }
        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value >= _kilometerstand)
                {
                    _kilometerstand = value;
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand kann nicht weniger werden");
                }
            }
        }

        public AbstrakteFahrzeuge(string farbe, string kennzeichen, double kilometerstand)
        {
            Farbe = farbe;
            Kennzeichen = kennzeichen;
            Kilometerstand = kilometerstand;
            AnzahlDerProduziertenFahrzeuge++;
        }
        public virtual void DruckeDatenblatt()
        {
            Console.WriteLine("Farbe: " + Farbe);
            Console.WriteLine("Kennzeichen: " + Kennzeichen);
            Console.WriteLine("Kilometerstand: " + Kilometerstand);

        }
        public static void PrintAnzahlDerProduziertenFahrzeuge()
        {
            Console.WriteLine("Anzahl der produzierten Fahrzeuge: " + AnzahlDerProduziertenFahrzeuge);
        }
        public abstract void Fahren(double distanz);
    }
}